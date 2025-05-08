using EduManage.Shared.Main;
using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;

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
                Quantity = Convert.ToInt16(reader["quantity"]),
                Unit = Convert.ToString(reader["unit"]),
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
                Quantity = Convert.ToInt16(reader["quantity"]),
                Unit = Convert.ToString(reader["unit"]),
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
                Quantity = Convert.ToInt16(reader["quantity"]),
                Unit = Convert.ToString(reader["unit"]),
                Room = reader["room"]?.ToString(),
                Status = reader["status"]?.ToString()
            }, new NpgsqlParameter("searchTerm", searchTerm)).ToArray();
        }

        public InventoryDto GetInventoryByNameAndUnit(string name, string unit)
        {
            var inventoryParams = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", name),
                new NpgsqlParameter("@unit", unit)
            };

            return _repository.Query<InventoryDto>(
                _sql.GetByNameAndUnit,
                reader => new InventoryDto
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Quantity = Convert.ToInt32(reader["quantity"])
                },
                inventoryParams).FirstOrDefault();
        }

        public void CreateInventiry(string name, string category, int quantity, string unit, string room, string status)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", name),
                new NpgsqlParameter("@category", category),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@unit", unit),
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

        public void UpdateInventiryQuantity(int id, int inventoryQuantity, int purchaseQuantity)
        {
            var updateParams = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@quantity", inventoryQuantity + purchaseQuantity)
            };

            int rowsAffected = _repository.Execute(_sql.UpdateInventoryQuantity, updateParams);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Предмет обновлен!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        public void UpdateInventiry(int id, string name, string category, int quantity, string unit, string room, string status)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@name", name),
                new NpgsqlParameter("@category", category),
                new NpgsqlParameter("@quantity", quantity),
                new NpgsqlParameter("@unit", unit),
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

        public void UpdateInventoryStatus(int inventoryId, string newStatus)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", inventoryId),
                new NpgsqlParameter("@status", newStatus)
            };

            try
            {
                int rowsAffected = _repository.Execute(_sql.UpdateStatus, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Статус инвентаря #{inventoryId} успешно изменен на '{newStatus}'");
                }
                else
                {
                    MessageBox.Show($"Инвентарь с ID {inventoryId} не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении статуса: {ex.Message}");
            }
        }
    }
}

