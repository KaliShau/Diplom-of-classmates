using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace EduManage.Shared.Main
{
    public class DatabaseException : Exception
    {
        public DatabaseException(string message) : base(message) { }
        public DatabaseException(string message, Exception inner) : base(message, inner) { }
    }

    public class DatabaseRepository
    {
        private string _connectionString = "Server=localhost; port=5432; User Id=postgres ;Password=root;database=EduManage;";

        public DatabaseRepository()
        {
        }

        

        public List<T> Query<T>(
            string sql,
            Func<NpgsqlDataReader, T> mapper,
            params NpgsqlParameter[] parameters)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();

                    var results = new List<T>();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            results.Add(mapper(reader));
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
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при выполнении команды в базе данных", ex);
                return 0;
            }
        }

        private void ShowError(string message, Exception ex)
        {
            string fullMessage = $"{message}:\n\n{ex.Message}";
            MessageBox.Show(fullMessage, "Ошибка базы данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
