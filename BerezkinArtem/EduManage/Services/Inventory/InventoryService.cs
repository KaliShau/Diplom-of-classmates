using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.Inventory
{
    public class InventoryService
    {
        DatabaseRepository _repository;
        InventorySQL _sql;
        public InventoryService(DatabaseRepository databaseRepository)
        {
            _repository = databaseRepository;
            _sql = new InventorySQL();
        }

        public InventoryDto[] GetInventories()
        {
            return _repository.Query<InventoryDto>(_sql.GetInventoies, reader => new InventoryDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Category = reader["category"].ToString(),
                Quantity = Convert.ToString(reader["quantity"]),
                Room = reader["room"]?.ToString(),
                Status = reader["status"]?.ToString()
            }).ToArray();
        }

        public InventoryDto GetById(int id)
        {
            return _repository.Query<InventoryDto>(_sql.GetById, reader => new InventoryDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Category = reader["category"].ToString(),
                Quantity = Convert.ToString(reader["quantity"]),
                Room = reader["room"]?.ToString(),
                Status = reader["status"]?.ToString()
            }, new NpgsqlParameter("id", id)).Single();
        }

        public InventoryDto[] GetInventoriesSearch(string searchTerm)
        {
            return _repository.Query<InventoryDto>(_sql.Search, reader => new InventoryDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Category = reader["category"].ToString(),
                Quantity = Convert.ToString(reader["quantity"]),
                Room = reader["room"]?.ToString(),
                Status = reader["status"]?.ToString()
            }, new NpgsqlParameter("searchTerm", searchTerm)).ToArray();
        }

        public void CreateInventiry(string name, string category, string quantity, string room, string status)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", name),
                new NpgsqlParameter("@category", category),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@room", room),
                new NpgsqlParameter("@status", status),
            };

            var rowsAffected = _repository.Execute(_sql.CreateInventory, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Предмет добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
        public void UpdateInventiry(int id, string name, string category, string quantity, string room, string status)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@name", name),
                new NpgsqlParameter("@category", category),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@room", room),
                new NpgsqlParameter("@status", status),
            };

            var rowsAffected = _repository.Execute(_sql.Update, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Предмет обновлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
        public void DeleteInventory(int id)
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
    }
}

