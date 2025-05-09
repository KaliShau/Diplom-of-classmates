using System;
using System.Linq;
using System.Windows.Forms;
using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.Request
{
    public class RequestService
    {
        DatabaseRepository _repository;
        RequestSQL _sql;
        public RequestService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new RequestSQL();
        }

        public void CreateRequest(int inventoryId, int userId, string problem)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
            new NpgsqlParameter("@inventoryId", inventoryId),
            new NpgsqlParameter("@userId", userId),
            new NpgsqlParameter("@problem", problem)
            };

            try
            {
                var rowsAffected = _repository.Execute(_sql.Create, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Заявка добавлена!");
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заявки: {ex.Message}");
            }
        }

        public RequestDto GetById(int id)
        {
            return _repository.Query<RequestDto>(_sql.GetById, reader => new RequestDto
            {
                Id = Convert.ToInt32(reader["id"]),
                InventoryId = Convert.ToInt32(reader["inventory_id"]),
                InventoryName = reader["inventory_name"].ToString(),
                UserId = Convert.ToInt32(reader["user_id"]),
                UserName = reader["user_name"].ToString(),
                Date = Convert.ToDateTime(reader["date"]),
                Problem = reader["problem"].ToString(),
                Status = reader["status"].ToString()
            }, new NpgsqlParameter("id", id)).Single();
        }

        public RequestDto[] GetAllRequests()
        {
            return _repository.Query<RequestDto>(_sql.GetAll, reader => new RequestDto
            {
                Id = Convert.ToInt32(reader["id"]),
                InventoryId = Convert.ToInt32(reader["inventory_id"]),
                InventoryName = reader["inventory_name"].ToString(),
                UserId = Convert.ToInt32(reader["user_id"]),
                UserName = reader["user_name"].ToString(),
                Date = Convert.ToDateTime(reader["date"]),
                Problem = reader["problem"].ToString(),
                Status = reader["status"].ToString()
            }).ToArray();
        }

        public RequestDto[] GetAllWithSearch(string searchTerm = null)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
        new NpgsqlParameter("@searchTerm", searchTerm)
            };

            return _repository.Query<RequestDto>(_sql.GetAllWithSearch, reader => new RequestDto
            {
                Id = Convert.ToInt32(reader["id"]),
                InventoryId = Convert.ToInt32(reader["inventory_id"]),
                InventoryName = reader["inventory_name"].ToString(),
                UserId = Convert.ToInt32(reader["user_id"]),
                UserName = reader["user_name"].ToString(),
                Date = Convert.ToDateTime(reader["date"]),
                Problem = reader["problem"].ToString(),
                Status = reader["status"].ToString()
            }, parameters).ToArray();
        }

        public void DeleteRequest(int id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
            };

            var rowsAffected = _repository.Execute(_sql.Delete, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Предмет удален!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        public void UpdateRequestStatus(int requestId, string newStatus)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@requestId", requestId),
                    new NpgsqlParameter("@status", newStatus)
                };

                int rowsAffected = _repository.Execute(_sql.UpdateStatus, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Статус обновлен!");
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating request status: {ex.Message}");
            }
        }

        public void UpdateRequest(int requestId, string problem, int inventoryId)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@requestId", requestId),
                    new NpgsqlParameter("@problem", problem),
                    new NpgsqlParameter("@inventory_id", inventoryId)
                };

                int rowsAffected = _repository.Execute(_sql.Update, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Заявка обновлена!");
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating request status: {ex.Message}");
            }
        }
    }
}
