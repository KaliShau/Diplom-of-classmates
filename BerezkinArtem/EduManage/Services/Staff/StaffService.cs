using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Shared.Main;
using Npgsql;
using System.Windows.Forms;


namespace EduManage.Services.Staff
{
    public class StaffService
    {
        private readonly DatabaseRepository _repository;
        private readonly StaffSQL _sql;

        public StaffService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new StaffSQL();
        }

        public void CreateStaff(StaffDto staff)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@full_name", staff.FullName),
                    new NpgsqlParameter("@position", staff.Position),
                    new NpgsqlParameter("@department", staff.Department),
                    new NpgsqlParameter("@phone", staff.Phone ?? (object)DBNull.Value),
                    new NpgsqlParameter("@hire_date", staff.HireDate)
                };

                var rowsAffected = _repository.Execute(_sql.Create, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Сотрудник добавлен!");
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании сотрудника: {ex.Message}");
            }
        }

        public void UpdateStaff(StaffDto staff)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@full_name", staff.FullName),
                    new NpgsqlParameter("@position", staff.Position),
                    new NpgsqlParameter("@department", staff.Department),
                    new NpgsqlParameter("@phone", staff.Phone ?? (object)DBNull.Value),
                    new NpgsqlParameter("@hire_date", staff.HireDate),
                    new NpgsqlParameter("@is_active", staff.IsActive)
                };

                var rowsAffected = _repository.Execute(_sql.Update, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Данные сотрудника обновлены!");
                }
                else
                {
                    MessageBox.Show("Ошибка обновления!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных сотрудника: {ex.Message}");
            }
        }

        public StaffDto GetStaff(int id)
        {
            return _repository.Query<StaffDto>(_sql.GetById, reader => new StaffDto
            {
                Id = Convert.ToInt32(reader["id"]),
                UserId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : (int?)null,
                FullName = reader["full_name"].ToString(),
                Position = reader["position"].ToString(),
                Department = reader["department"].ToString(),
                Phone = reader["phone"] != DBNull.Value ? reader["phone"].ToString() : null,
                HireDate = Convert.ToDateTime(reader["hire_date"]),
                IsActive = Convert.ToBoolean(reader["is_active"])
            }, new NpgsqlParameter("@id", id)).SingleOrDefault();
        }

        public StaffDto[] GetAllStaff()
        {
            return _repository.Query<StaffDto>(_sql.GetAll, reader => new StaffDto
            {
                Id = Convert.ToInt32(reader["id"]),
                UserId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : (int?)null,
                FullName = reader["full_name"].ToString(),
                Position = reader["position"].ToString(),
                Department = reader["department"].ToString(),
                Phone = reader["phone"] != DBNull.Value ? reader["phone"].ToString() : null,
                HireDate = Convert.ToDateTime(reader["hire_date"]),
                IsActive = Convert.ToBoolean(reader["is_active"])
            }).ToArray();
        }

        public StaffDto[] GetStaffForAccountant()
        {
            return _repository.Query<StaffDto>(_sql.GetForAccountant, reader => new StaffDto
            {
                Id = Convert.ToInt32(reader["id"]),
                UserId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : (int?)null,
                FullName = reader["full_name"].ToString(),
                Position = reader["position"].ToString(),
                Department = reader["department"].ToString(),
                Phone = reader["phone"] != DBNull.Value ? reader["phone"].ToString() : null,
                HireDate = Convert.ToDateTime(reader["hire_date"]),
                IsActive = Convert.ToBoolean(reader["is_active"])
            }).ToArray();
        }

        public StaffDto[] SearchStaff(string searchTerm)
        {
            return _repository.Query<StaffDto>(_sql.Search, reader => new StaffDto
            {
                Id = Convert.ToInt32(reader["id"]),
                UserId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : (int?)null,
                FullName = reader["full_name"].ToString(),
                Position = reader["position"].ToString(),
                Department = reader["department"].ToString(),
                Phone = reader["phone"] != DBNull.Value ? reader["phone"].ToString() : null,
                HireDate = Convert.ToDateTime(reader["hire_date"]),
                IsActive = Convert.ToBoolean(reader["is_active"])
            }, new NpgsqlParameter("@searchTerm", searchTerm)).ToArray();
        }

        public StaffDto[] SearchStaffForAccountant(string searchTerm)
        {
            return _repository.Query<StaffDto>(_sql.GetForAccountantSearch, reader => new StaffDto
            {
                Id = Convert.ToInt32(reader["id"]),
                UserId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : (int?)null,
                FullName = reader["full_name"].ToString(),
                Position = reader["position"].ToString(),
                Department = reader["department"].ToString(),
                Phone = reader["phone"] != DBNull.Value ? reader["phone"].ToString() : null,
                HireDate = Convert.ToDateTime(reader["hire_date"]),
                IsActive = Convert.ToBoolean(reader["is_active"])
            }, new NpgsqlParameter("@searchTerm", searchTerm)).ToArray();
        }

        public void DeleteStaff(int id)
        {
            try
            {
                int rowsAffected = _repository.Execute(_sql.Delete, new NpgsqlParameter("@id", id));

                if (rowsAffected > 0)
                    MessageBox.Show("Сотрудник успешно удален!");
                else
                    MessageBox.Show("Не удалось удалить сотрудника!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении сотрудника: {ex.Message}");
            }
        }


    }
}