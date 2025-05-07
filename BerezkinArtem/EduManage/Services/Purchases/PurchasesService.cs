using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    new NpgsqlParameter("@amount", purchase.Amount),
                    new NpgsqlParameter("@date", purchase.Date)
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

        public PurchaseDto GetPurchase(int id)
        {
            return _repository.Query<PurchaseDto>(_sql.GetById, reader => new PurchaseDto
            {
                Id = Convert.ToInt32(reader["id"]),
                SupplierId = Convert.ToInt32(reader["supplier_id"]),
                SupplierName = reader["supplier_name"].ToString(),
                ItemName = reader["item_name"].ToString(),
                Amount = reader["amount"].ToString(),
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
                Amount = reader["amount"].ToString(),
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
                Amount = reader["amount"].ToString(),
                Date = Convert.ToDateTime(reader["date"])
            }, new NpgsqlParameter("@searchTerm", searchTerm)).ToArray();
        }

        public void UpdatePurchase(PurchaseDto purchase)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id", purchase.Id),
                    new NpgsqlParameter("@supplierId", purchase.SupplierId),
                    new NpgsqlParameter("@itemName", purchase.ItemName),
                    new NpgsqlParameter("@amount", purchase.Amount),
                    new NpgsqlParameter("@date", purchase.Date)
                };

                int rowsAffected = _repository.Execute(_sql.Update, parameters);

                if (rowsAffected > 0)
                    MessageBox.Show("Закупка успешно обновлена!");
                else
                    MessageBox.Show("Не удалось обновить закупку!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении закупки: {ex.Message}");
            }
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
