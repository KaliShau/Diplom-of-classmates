using System;
using System.Linq;
using System.Windows.Forms;
using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.Buses
{
    public class BusService
    {
        private readonly DatabaseRepository _repository;
        private readonly BusSQL _sql;

        public BusService(DatabaseRepository databaseRepository)
        {
            _repository = databaseRepository;
            _sql = new BusSQL();
        }

        public BusDto[] GetBuses()
        {
            return _repository.Query<BusDto>(_sql.GetBuses, reader => new BusDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Model = reader["model"].ToString(),
                LicensePlate = reader["license_plate"].ToString(),
                PurchaseDate = reader["purchase_date"] as DateTime?,
                LastTechInspection = reader["last_tech_inspection"] as DateTime?,
                NextTechInspection = reader["next_tech_inspection"] as DateTime?,
                Status = reader["status"]?.ToString(),
                Notes = reader["notes"]?.ToString()
            }).ToArray();
        }

        public BusDto GetById(int id)
        {
            return _repository.Query<BusDto>(_sql.GetById, reader => new BusDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Model = reader["model"].ToString(),
                LicensePlate = reader["license_plate"].ToString(),
                PurchaseDate = reader["purchase_date"] as DateTime?,
                LastTechInspection = reader["last_tech_inspection"] as DateTime?,
                NextTechInspection = reader["next_tech_inspection"] as DateTime?,
                Status = reader["status"]?.ToString(),
                Notes = reader["notes"]?.ToString()
            }, new NpgsqlParameter("id", id)).Single();
        }

        public BusDto[] SearchBuses(string searchTerm)
        {
            return _repository.Query<BusDto>(_sql.Search, reader => new BusDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Model = reader["model"].ToString(),
                LicensePlate = reader["license_plate"].ToString(),
                PurchaseDate = reader["purchase_date"] as DateTime?,
                LastTechInspection = reader["last_tech_inspection"] as DateTime?,
                NextTechInspection = reader["next_tech_inspection"] as DateTime?,
                Status = reader["status"]?.ToString(),
                Notes = reader["notes"]?.ToString()
            }, new NpgsqlParameter("searchTerm", searchTerm)).ToArray();
        }

        public BusDto GetBusByLicensePlate(string licensePlate)
        {
            return _repository.Query<BusDto>(
                _sql.GetByLicensePlate,
                reader => new BusDto
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Model = reader["model"].ToString(),
                    LicensePlate = reader["license_plate"].ToString()
                },
                new NpgsqlParameter("@licensePlate", licensePlate)).FirstOrDefault();
        }

        public void CreateBus(string model, string licensePlate, DateTime? purchaseDate,
                             DateTime? lastTechInspection, DateTime? nextTechInspection,
                             string status, string? notes)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@model", model),
                new NpgsqlParameter("@licensePlate", licensePlate),
                new NpgsqlParameter("@purchaseDate", purchaseDate ?? (object)DBNull.Value),
                new NpgsqlParameter("@lastTechInspection", lastTechInspection ?? (object)DBNull.Value),
                new NpgsqlParameter("@nextTechInspection", nextTechInspection ?? (object)DBNull.Value),
                new NpgsqlParameter("@status", status),
                new NpgsqlParameter("@notes", notes ?? (object)DBNull.Value)
            };

            var rowsAffected = _repository.Execute(_sql.CreateBus, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Автобус добавлен!");
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении автобуса!");
            }
        }

        public void UpdateBus(int id, string model, string licensePlate, DateTime? purchaseDate,
                            DateTime? lastTechInspection, DateTime? nextTechInspection,
                            string status, string notes)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@model", model),
                new NpgsqlParameter("@licensePlate", licensePlate),
                new NpgsqlParameter("@purchaseDate", purchaseDate ?? (object)DBNull.Value),
                new NpgsqlParameter("@lastTechInspection", lastTechInspection ?? (object)DBNull.Value),
                new NpgsqlParameter("@nextTechInspection", nextTechInspection ?? (object)DBNull.Value),
                new NpgsqlParameter("@status", status),
                new NpgsqlParameter("@notes", notes ?? (object)DBNull.Value)
            };

            var rowsAffected = _repository.Execute(_sql.Update, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Автобус обновлен!");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении автобуса!");
            }
        }

        public void DeleteBus(int id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
            };

            var rowsAffected = _repository.Execute(_sql.Delete, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Автобус удален!");
            }
            else
            {
                MessageBox.Show("Ошибка при удалении автобуса!");
            }
        }

        public void UpdateBusStatus(int busId, string newStatus)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", busId),
                new NpgsqlParameter("@status", newStatus)
            };

            try
            {
                int rowsAffected = _repository.Execute(_sql.UpdateStatus, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Статус автобуса #{busId} успешно изменен на '{newStatus}'");
                }
                else
                {
                    MessageBox.Show($"Автобус с ID {busId} не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении статуса: {ex.Message}");
            }
        }
    }
}