using System;
using System.Linq;
using System.Windows.Forms;
using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.Purchases
{
    public class PurchaseService
    {
        private readonly DatabaseRepository _repository;
        private readonly PurchaseSQL _sql;

        public PurchaseService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new PurchaseSQL();
        }

        public void CreatePurchase(PurchaseDto purchase)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@supplierId", purchase.SupplierId),
                    new NpgsqlParameter("@itemName", purchase.ItemName),
                    new NpgsqlParameter("@quantity", purchase.Quantity),
                    new NpgsqlParameter("@unit", purchase.Unit),
                    new NpgsqlParameter("@status", purchase.Status),
                    new NpgsqlParameter("@price", purchase.Price),
                };

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
                MessageBox.Show($"Ошибка при создании закупки: {ex.Message}");
            }
        }
        public void UpdatePurchase(PurchaseDto purchase)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@supplierId", purchase.SupplierId),
                    new NpgsqlParameter("@itemName", purchase.ItemName),
                    new NpgsqlParameter("@quantity", purchase.Quantity),
                    new NpgsqlParameter("@unit", purchase.Unit),
                    new NpgsqlParameter("@id", purchase.Id),
                    new NpgsqlParameter("@price", purchase.Price),
                };

                var rowsAffected = _repository.Execute(_sql.Update, parameters);

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
                MessageBox.Show($"Ошибка при создании закупки: {ex.Message}");
            }
        }
        public void UpdateStatus(int id, string status)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id", id),
                    new NpgsqlParameter("@status", status),
                };

                var rowsAffected = _repository.Execute(_sql.UpdateStatus, parameters);

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
                MessageBox.Show($"Ошибка при создании закупки: {ex.Message}");
            }
        }

        public PurchaseDto GetPurchase(int id)
        {
            return _repository.Query<PurchaseDto>(_sql.GetById, reader => new PurchaseDto
            {
                Id = Convert.ToInt32(reader["id"]),
                SupplierId = Convert.ToInt32(reader["supplier_id"]),
                SupplierName = reader["supplier_name"].ToString(),
                ItemName = reader["item_name"].ToString(),
                Quantity = Convert.ToInt16(reader["quantity"]),
                Unit = Convert.ToString(reader["unit"]),
                Price = Convert.ToString(reader["price"]),
                Status = Convert.ToString(reader["status"]),
                Date = Convert.ToDateTime(reader["date"])
            }, new NpgsqlParameter("@id", id)).SingleOrDefault();
        }

        public PurchaseDto[] GetAllPurchases()
        {
            return _repository.Query<PurchaseDto>(_sql.GetAll, reader => new PurchaseDto
            {
                Id = Convert.ToInt32(reader["id"]),
                SupplierId = Convert.ToInt32(reader["supplier_id"]),
                SupplierName = reader["supplier_name"].ToString(),
                ItemName = reader["item_name"].ToString(),
                Quantity = Convert.ToInt16(reader["quantity"]),
                Unit = Convert.ToString(reader["unit"]),
                Price = Convert.ToString(reader["price"]),
                Status = Convert.ToString(reader["status"]),
                Date = Convert.ToDateTime(reader["date"])
            }).ToArray();
        }

        public PurchaseDto[] SearchPurchases(string searchTerm)
        {
            return _repository.Query<PurchaseDto>(_sql.Search, reader => new PurchaseDto
            {
                Id = Convert.ToInt32(reader["id"]),
                SupplierId = Convert.ToInt32(reader["supplier_id"]),
                SupplierName = reader["supplier_name"].ToString(),
                ItemName = reader["item_name"].ToString(),
                Quantity = Convert.ToInt16(reader["quantity"]),
                Unit = Convert.ToString(reader["unit"]),
                Price = Convert.ToString(reader["price"]),
                Status = Convert.ToString(reader["status"]),
                Date = Convert.ToDateTime(reader["date"])
            }, new NpgsqlParameter("@searchTerm", searchTerm)).ToArray();
        }

        public void DeletePurchase(int id)
        {
            try
            {
                int rowsAffected = _repository.Execute(_sql.Delete, new NpgsqlParameter("@id", id));

                if (rowsAffected > 0)
                    MessageBox.Show("Закупка успешно удалена!");
                else
                    MessageBox.Show("Не удалось удалить закупку!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении закупки: {ex.Message}");
            }
        }
    }
}
