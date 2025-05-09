using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Shared.Main;
using Npgsql;
using System.Windows.Forms;


namespace EduManage.Services.Suppliers
{
    public class SuppliersService
    {
        DatabaseRepository _repository;
        SupplierSql _sql;

        public SuppliersService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new SupplierSql();
        }

        public void CreateSupplier(SupplierDto supplier)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", supplier.Name),
                new NpgsqlParameter("@contact", supplier.Contact ?? (object)DBNull.Value),
                new NpgsqlParameter("@phone", supplier.Phone ?? (object)DBNull.Value)
            };

            try
            {
                var rowsAffected = _repository.Execute(_sql.Create, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Поставщик добавлен!");
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении поставщика!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании поставщика: {ex.Message}");
            }
        }

        public SupplierDto GetById(int id)
        {
            return _repository.Query<SupplierDto>(_sql.GetById, reader => new SupplierDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Contact = reader["contact"]?.ToString(),
                Phone = reader["phone"]?.ToString()
            }, new NpgsqlParameter("@id", id)).SingleOrDefault();
        }

        public SupplierDto[] GetAllSuppliers()
        {
            return _repository.Query<SupplierDto>(_sql.GetAll, reader => new SupplierDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Contact = reader["contact"]?.ToString(),
                Phone = reader["phone"]?.ToString()
            }).ToArray();
        }

        public SupplierDto[] GetAllWithSearch(string searchTerm = null)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@searchTerm", searchTerm)
            };

            return _repository.Query<SupplierDto>(_sql.GetAllWithSearch, reader => new SupplierDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Contact = reader["contact"]?.ToString(),
                Phone = reader["phone"]?.ToString()
            }, parameters).ToArray();
        }

        public void UpdateSupplier(SupplierDto supplier)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@name", supplier.Name),
                    new NpgsqlParameter("@contact", supplier.Contact ?? (object)DBNull.Value),
                    new NpgsqlParameter("@phone", supplier.Phone ?? (object)DBNull.Value),
                    new NpgsqlParameter("@id", supplier.Id)
                };

                int rowsAffected = _repository.Execute(_sql.Update, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Поставщик обновлен!");
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении поставщика!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении поставщика: {ex.Message}");
            }
        }

        public void DeleteSupplier(int id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id)
            };

            try
            {
                var rowsAffected = _repository.Execute(_sql.Delete, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Поставщик удален!");
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении поставщика!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении поставщика: {ex.Message}");
            }
        }
    }
}
