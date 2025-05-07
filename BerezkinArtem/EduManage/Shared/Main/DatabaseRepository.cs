using System;
using System.Collections.Generic;
using Npgsql;
using System.Windows.Forms;

namespace EduManage.Shared.Main
{
    public class DatabaseException : Exception
    {
        public DatabaseException(string message) : base(message) { }
        public DatabaseException(string message, Exception inner) : base(message, inner) { }
    }

    public class DatabaseRepository : IDisposable
    {
        private string _connectionString = "Server=localhost; port=5432; User Id=postgres; Password=root; database=EduManage;";
        private NpgsqlConnection _connection;
        private NpgsqlTransaction _transaction;

        public DatabaseRepository()
        {
        }

        public NpgsqlTransaction BeginTransaction()
        {
            if (_connection == null)
            {
                _connection = new NpgsqlConnection(_connectionString);
                _connection.Open();
            }

            _transaction = _connection.BeginTransaction();
            return _transaction;
        }

        public List<T> Query<T>(
            string sql,
            Func<NpgsqlDataReader, T> mapper,
            params NpgsqlParameter[] parameters)
        {
            return Query<T>(sql, null, mapper, parameters);
        }

        public List<T> Query<T>(
            string sql,
            NpgsqlTransaction transaction,
            Func<NpgsqlDataReader, T> mapper,
            params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var command = new NpgsqlCommand(sql, transaction?.Connection ?? new NpgsqlConnection(_connectionString)))
                {
                    if (transaction != null)
                    {
                        command.Transaction = transaction;
                    }
                    else if (command.Connection != _connection)
                    {
                        command.Connection.Open();
                    }

                    command.Parameters.AddRange(parameters);

                    var results = new List<T>();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            results.Add(mapper(reader));
                    }

                    if (command.Connection != _connection)
                    {
                        command.Connection.Close();
                    }

                    return results;
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при выполнении запроса к базе данных", ex);
                return new List<T>();
            }
        }

        public int Execute(string sql, params NpgsqlParameter[] parameters)
        {
            return Execute(sql, null, parameters);
        }

        public int Execute(string sql, NpgsqlTransaction transaction, params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var command = new NpgsqlCommand(sql, transaction?.Connection ?? new NpgsqlConnection(_connectionString)))
                {
                    if (transaction != null)
                    {
                        command.Transaction = transaction;
                    }
                    else if (command.Connection != _connection)
                    {
                        command.Connection.Open();
                    }

                    command.Parameters.AddRange(parameters);
                    int result = command.ExecuteNonQuery();

                    if (command.Connection != _connection)
                    {
                        command.Connection.Close();
                    }

                    return result;
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при выполнении команды в базе данных", ex);
                return 0;
            }
        }

        public T ExecuteScalar<T>(string sql, NpgsqlTransaction transaction, params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var command = new NpgsqlCommand(sql, transaction?.Connection ?? new NpgsqlConnection(_connectionString)))
                {
                    if (transaction != null)
                    {
                        command.Transaction = transaction;
                    }
                    else if (command.Connection != _connection)
                    {
                        command.Connection.Open();
                    }

                    command.Parameters.AddRange(parameters);
                    object result = command.ExecuteScalar();

                    if (command.Connection != _connection)
                    {
                        command.Connection.Close();
                    }

                    return (T)Convert.ChangeType(result, typeof(T));
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при выполнении скалярного запроса", ex);
                return default(T);
            }
        }

        public void CommitTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction.Dispose();
                _transaction = null;
            }

            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }

        public void RollbackTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction.Dispose();
                _transaction = null;
            }

            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }

        private void ShowError(string message, Exception ex)
        {
            string fullMessage = $"{message}:\n\n{ex.Message}";
            MessageBox.Show(fullMessage, "Ошибка базы данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }

            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}