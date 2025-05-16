using System;
using System.Linq;
using System.Windows.Forms;
using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.PartOperations
{
    public class PartOperationService
    {
        private readonly DatabaseRepository _repository;
        private readonly PartOperationSQL _sql;

        public PartOperationService(DatabaseRepository databaseRepository)
        {
            _repository = databaseRepository;
            _sql = new PartOperationSQL();
        }

        public PartOperationDto[] GetAllOperations()
        {
            return _repository.Query<PartOperationDto>(_sql.GetAll, reader => new PartOperationDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartId = reader["part_id"] as int?,
                OperationType = reader["operation_type"].ToString(),
                BusId = reader["bus_id"] as int?,
                PartTypeId = reader["part_type_id"] as int?,
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                Price = reader["price"]?.ToString(),
                OperationDate = Convert.ToDateTime(reader["operation_date"]),
                PerformedBy = reader["performed_by"] as int?,
                SupplierId = reader["supplier_id"] as int?,
                Notes = reader["notes"]?.ToString(),
                PartInfo = reader["part_info"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString(),
                PartTypeInfo = reader["part_type_info"]?.ToString(),
                StaffInfo = reader["staff_info"]?.ToString(),
                SupplierInfo = reader["supplier_info"]?.ToString()
            }).ToArray();
        }

        public PartOperationDto GetOperationById(int id)
        {
            return _repository.Query<PartOperationDto>(_sql.GetById, reader => new PartOperationDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartId = reader["part_id"] as int?,
                OperationType = reader["operation_type"].ToString(),
                BusId = reader["bus_id"] as int?,
                PartTypeId = reader["part_type_id"] as int?,
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                Price = reader["price"]?.ToString(),
                OperationDate = Convert.ToDateTime(reader["operation_date"]),
                PerformedBy = reader["performed_by"] as int?,
                SupplierId = reader["supplier_id"] as int?,
                Notes = reader["notes"]?.ToString(),
                PartInfo = reader["part_info"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString(),
                PartTypeInfo = reader["part_type_info"]?.ToString(),
                StaffInfo = reader["staff_info"]?.ToString(),
                SupplierInfo = reader["supplier_info"]?.ToString()
            }, new NpgsqlParameter("id", id)).FirstOrDefault();
        }

        public PartOperationDto[] SearchOperations(string searchTerm)
        {
            return _repository.Query<PartOperationDto>(_sql.Search, reader => new PartOperationDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartId = reader["part_id"] as int?,
                OperationType = reader["operation_type"].ToString(),
                BusId = reader["bus_id"] as int?,
                PartTypeId = reader["part_type_id"] as int?,
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                Price = reader["price"]?.ToString(),
                OperationDate = Convert.ToDateTime(reader["operation_date"]),
                PerformedBy = reader["performed_by"] as int?,
                SupplierId = reader["supplier_id"] as int?,
                Notes = reader["notes"]?.ToString(),
                PartInfo = reader["part_info"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString(),
                PartTypeInfo = reader["part_type_info"]?.ToString(),
                StaffInfo = reader["staff_info"]?.ToString(),
                SupplierInfo = reader["supplier_info"]?.ToString()
            }, new NpgsqlParameter("searchTerm", searchTerm)).ToArray();
        }

        public PartOperationDto[] GetOperationsByPartId(int partId)
        {
            return _repository.Query<PartOperationDto>(_sql.GetByPartId, reader => new PartOperationDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartId = Convert.ToInt32(reader["part_id"]),
                OperationType = reader["operation_type"].ToString(),
                BusId = reader["bus_id"] as int?,
                PartTypeId = reader["part_type_id"] as int?,
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                Price = reader["price"]?.ToString(),
                OperationDate = Convert.ToDateTime(reader["operation_date"]),
                PerformedBy = reader["performed_by"] as int?,
                SupplierId = reader["supplier_id"] as int?,
                Notes = reader["notes"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString(),
                PartTypeInfo = reader["part_type_info"]?.ToString(),
                StaffInfo = reader["staff_info"]?.ToString(),
                SupplierInfo = reader["supplier_info"]?.ToString()
            }, new NpgsqlParameter("partId", partId)).ToArray();
        }

        public PartOperationDto[] GetOperationsByBusId(int busId, string operation_type)
        {
            return _repository.Query<PartOperationDto>(_sql.GetByBusId, reader => new PartOperationDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartId = reader["part_id"] as int?,
                OperationType = reader["operation_type"].ToString(),
                BusId = Convert.ToInt32(reader["bus_id"]),
                PartTypeId = reader["part_type_id"] as int?,
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                Price = reader["price"]?.ToString(),
                OperationDate = Convert.ToDateTime(reader["operation_date"]),
                PerformedBy = reader["performed_by"] as int?,
                SupplierId = reader["supplier_id"] as int?,
                Notes = reader["notes"]?.ToString(),
                PartInfo = reader["part_info"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString(),
                PartTypeInfo = reader["part_type_info"]?.ToString(),
                StaffInfo = reader["staff_info"]?.ToString(),
                SupplierInfo = reader["supplier_info"]?.ToString()
            }, new NpgsqlParameter("busId", busId), new NpgsqlParameter("operation_type", operation_type)).ToArray();
        }

        public PartOperationDto[] GetOperationsByPartTypeId(int partTypeId)
        {
            return _repository.Query<PartOperationDto>(_sql.GetByPartTypeId, reader => new PartOperationDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartId = reader["part_id"] as int?,
                OperationType = reader["operation_type"].ToString(),
                BusId = reader["bus_id"] as int?,
                PartTypeId = Convert.ToInt32(reader["part_type_id"]),
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                Price = reader["price"]?.ToString(),
                OperationDate = Convert.ToDateTime(reader["operation_date"]),
                PerformedBy = reader["performed_by"] as int?,
                SupplierId = reader["supplier_id"] as int?,
                Notes = reader["notes"]?.ToString(),
                PartInfo = reader["part_info"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString(),
                StaffInfo = reader["staff_info"]?.ToString(),
                SupplierInfo = reader["supplier_info"]?.ToString()
            }, new NpgsqlParameter("partTypeId", partTypeId)).ToArray();
        }

        public PartOperationDto[] GetOperationsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _repository.Query<PartOperationDto>(_sql.GetByDateRange, reader => new PartOperationDto
            {
                Id = Convert.ToInt32(reader["id"]),
                PartId = reader["part_id"] as int?,
                OperationType = reader["operation_type"].ToString(),
                BusId = reader["bus_id"] as int?,
                PartTypeId = reader["part_type_id"] as int?,
                Quantity = reader["quantity"] as int?,
                Unit = reader["unit"]?.ToString(),
                Price = reader["price"]?.ToString(),
                OperationDate = Convert.ToDateTime(reader["operation_date"]),
                PerformedBy = reader["performed_by"] as int?,
                SupplierId = reader["supplier_id"] as int?,
                Notes = reader["notes"]?.ToString(),
                PartInfo = reader["part_info"]?.ToString(),
                BusInfo = reader["bus_info"]?.ToString(),
                PartTypeInfo = reader["part_type_info"]?.ToString(),
                StaffInfo = reader["staff_info"]?.ToString(),
                SupplierInfo = reader["supplier_info"]?.ToString()
            },
            new NpgsqlParameter("startDate", startDate),
            new NpgsqlParameter("endDate", endDate)).ToArray();
        }

        public int CreateOperation(
            int? partId, string operationType, int? busId, int? partTypeId, int? quantity,
            string unit, string price, DateTime operationDate,
            int? performedBy, int? supplierId, string notes)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@partId", partId ?? (object)DBNull.Value),
                new NpgsqlParameter("@operationType", operationType),
                new NpgsqlParameter("@busId", busId ?? (object)DBNull.Value),
                new NpgsqlParameter("@partTypeId", partTypeId ?? (object)DBNull.Value),
                new NpgsqlParameter("@quantity", quantity ?? (object)DBNull.Value),
                new NpgsqlParameter("@unit", unit ?? (object)DBNull.Value),
                new NpgsqlParameter("@price", price ?? (object)DBNull.Value),
                new NpgsqlParameter("@operationDate", operationDate),
                new NpgsqlParameter("@performedBy", performedBy ?? (object)DBNull.Value),
                new NpgsqlParameter("@supplierId", supplierId ?? (object)DBNull.Value),
                new NpgsqlParameter("@notes", notes ?? (object)DBNull.Value)
            };

            try
            {
                var result = _repository.Execute(_sql.Create, parameters);
                if (result != null)
                {
                    MessageBox.Show("Операция с запчастью успешно создана!");
                    return Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Ошибка при создании операции с запчастью!");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании операции с запчастью: {ex.Message}");
                return -1;
            }
        }

        public void UpdateOperation(
            int id, int? partId, string operationType, int? busId, int? partTypeId, int? quantity,
            string unit, string price, DateTime operationDate,
            int? performedBy, int? supplierId, string notes)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@partId", partId ?? (object)DBNull.Value),
                new NpgsqlParameter("@operationType", operationType),
                new NpgsqlParameter("@busId", busId ?? (object)DBNull.Value),
                new NpgsqlParameter("@partTypeId", partTypeId ?? (object)DBNull.Value),
                new NpgsqlParameter("@quantity", quantity ?? (object)DBNull.Value),
                new NpgsqlParameter("@unit", unit ?? (object)DBNull.Value),
                new NpgsqlParameter("@price", price ?? (object)DBNull.Value),
                new NpgsqlParameter("@operationDate", operationDate),
                new NpgsqlParameter("@performedBy", performedBy ?? (object)DBNull.Value),
                new NpgsqlParameter("@supplierId", supplierId ?? (object)DBNull.Value),
                new NpgsqlParameter("@notes", notes ?? (object)DBNull.Value)
            };

            var rowsAffected = _repository.Execute(_sql.Update, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Операция с запчастью успешно обновлена!");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении операции с запчастью!");
            }
        }

        public void DeleteOperation(int id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id)
            };

            var rowsAffected = _repository.Execute(_sql.Delete, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Операция с запчастью успешно удалена!");
            }
            else
            {
                MessageBox.Show("Ошибка при удалении операции с запчастью!");
            }
        }
    }
}