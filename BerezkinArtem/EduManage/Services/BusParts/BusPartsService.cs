using System;
using System.Linq;
using System.Windows.Forms;
using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.BusParts
{
    public class BusPartService
    {
        private readonly DatabaseRepository _repository;
        private readonly BusPartSQL _sql;

        public BusPartService(DatabaseRepository databaseRepository)
        {
            _repository = databaseRepository;
            _sql = new BusPartSQL();
        }

        public BusPartDto[] GetAllBusParts()
        {
            return _repository.Query<BusPartDto>(_sql.GetAll, reader => new BusPartDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartTypeId = Convert.ToInt32(reader["part_type_id"]),
                BusId = Convert.ToInt32(reader["bus_id"]),
                SerialNumber = reader["serial_number"]?.ToString(),
                Status = reader["status"].ToString(),
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                InstallationDate = reader["installation_date"] as DateTime?,
                DefectDate = reader["defect_date"] as DateTime?,
                DefectDescription = reader["defect_description"]?.ToString(),
                PartTypeName = reader["part_type_name"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString()
            }).ToArray();
        }

        public BusPartDto GetBusPartById(int id)
        {
            return _repository.Query<BusPartDto>(_sql.GetById, reader => new BusPartDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartTypeId = Convert.ToInt32(reader["part_type_id"]),
                BusId = Convert.ToInt32(reader["bus_id"]),
                SerialNumber = reader["serial_number"]?.ToString(),
                Status = reader["status"].ToString(),
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                InstallationDate = reader["installation_date"] as DateTime?,
                DefectDate = reader["defect_date"] as DateTime?,
                DefectDescription = reader["defect_description"]?.ToString(),
                PartTypeName = reader["part_type_name"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString()
            }, new NpgsqlParameter("id", id)).FirstOrDefault();
        }

        public BusPartDto[] SearchBusParts(string searchTerm)
        {
            return _repository.Query<BusPartDto>(_sql.Search, reader => new BusPartDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartTypeId = Convert.ToInt32(reader["part_type_id"]),
                BusId = Convert.ToInt32(reader["bus_id"]),
                SerialNumber = reader["serial_number"]?.ToString(),
                Status = reader["status"].ToString(),
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                InstallationDate = reader["installation_date"] as DateTime?,
                DefectDate = reader["defect_date"] as DateTime?,
                DefectDescription = reader["defect_description"]?.ToString(),
                PartTypeName = reader["part_type_name"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString()
            }, new NpgsqlParameter("searchTerm", searchTerm)).ToArray();
        }

        public BusPartDto[] GetBusPartsByBusId(int busId)
        {
            return _repository.Query<BusPartDto>(_sql.GetByBusId, reader => new BusPartDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartTypeId = Convert.ToInt32(reader["part_type_id"]),
                BusId = Convert.ToInt32(reader["bus_id"]),
                SerialNumber = reader["serial_number"]?.ToString(),
                Status = reader["status"].ToString(),
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                InstallationDate = reader["installation_date"] as DateTime?,
                DefectDate = reader["defect_date"] as DateTime?,
                DefectDescription = reader["defect_description"]?.ToString(),
                PartTypeName = reader["part_type_name"]?.ToString()
            }, new NpgsqlParameter("busId", busId)).ToArray();
        }

        public BusPartDto[] GetBusPartsByPartTypeId(int partTypeId)
        {
            return _repository.Query<BusPartDto>(_sql.GetByPartTypeId, reader => new BusPartDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartTypeId = Convert.ToInt32(reader["part_type_id"]),
                BusId = Convert.ToInt32(reader["bus_id"]),
                SerialNumber = reader["serial_number"]?.ToString(),
                Status = reader["status"].ToString(),
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                InstallationDate = reader["installation_date"] as DateTime?,
                DefectDate = reader["defect_date"] as DateTime?,
                DefectDescription = reader["defect_description"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString()
            }, new NpgsqlParameter("partTypeId", partTypeId)).ToArray();
        }

        public int CreateBusPart(int partTypeId, int busId, string serialNumber, string status,
                              int? quantity, string unit, DateTime? installationDate,
                              DateTime? defectDate, string defectDescription)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@partTypeId", partTypeId),
                new NpgsqlParameter("@busId", busId),
                new NpgsqlParameter("@serialNumber", serialNumber ?? (object)DBNull.Value),
                new NpgsqlParameter("@status", status),
                new NpgsqlParameter("@quantity", quantity ?? (object)DBNull.Value),
                new NpgsqlParameter("@unit", unit ?? (object)DBNull.Value),
                new NpgsqlParameter("@installationDate", installationDate ?? (object)DBNull.Value),
                new NpgsqlParameter("@defectDate", defectDate ?? (object)DBNull.Value),
                new NpgsqlParameter("@defectDescription", defectDescription ?? (object)DBNull.Value)
            };

            try
            {
                var result = _repository.Execute(_sql.Create, parameters);
                if (result != null)
                {
                    MessageBox.Show("Запчасть автобуса успешно добавлена!");
                    return Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении запчасти автобуса!");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении запчасти автобуса: {ex.Message}");
                return -1;
            }
        }

        public void UpdateBusPart(int id, int partTypeId, int busId, string serialNumber, string status,
                                int? quantity, string unit, DateTime? installationDate,
                                DateTime? defectDate, string defectDescription)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@partTypeId", partTypeId),
                new NpgsqlParameter("@busId", busId),
                new NpgsqlParameter("@serialNumber", serialNumber ?? (object)DBNull.Value),
                new NpgsqlParameter("@status", status),
                new NpgsqlParameter("@quantity", quantity ?? (object)DBNull.Value),
                new NpgsqlParameter("@unit", unit ?? (object)DBNull.Value),
                new NpgsqlParameter("@installationDate", installationDate ?? (object)DBNull.Value),
                new NpgsqlParameter("@defectDate", defectDate ?? (object)DBNull.Value),
                new NpgsqlParameter("@defectDescription", defectDescription ?? (object)DBNull.Value)
            };

            var rowsAffected = _repository.Execute(_sql.Update, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Запчасть автобуса успешно обновлена!");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении запчасти автобуса!");
            }
        }

        public void DeleteBusPart(int id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id)
            };

            var rowsAffected = _repository.Execute(_sql.Delete, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Запчасть автобуса успешно удалена!");
            }
            else
            {
                MessageBox.Show("Ошибка при удалении запчасти автобуса!");
            }
        }

        public void UpdateBusPartStatus(int id, string newStatus)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@status", newStatus)
            };

            try
            {
                int rowsAffected = _repository.Execute(_sql.UpdateStatus, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Статус запчасти #{id} успешно изменен на '{newStatus}'");
                }
                else
                {
                    MessageBox.Show($"Запчасть с ID {id} не найдена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении статуса: {ex.Message}");
            }
        }
    }
}