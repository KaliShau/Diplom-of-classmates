using System;
using System.Linq;
using System.Windows.Forms;
using EduManage.Services.PartTypes;
using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.Parts
{
    public class PartTypeService
    {
        private readonly DatabaseRepository _repository;
        private readonly PartTypeSQL _sql;

        public PartTypeService(DatabaseRepository databaseRepository)
        {
            _repository = databaseRepository;
            _sql = new PartTypeSQL();
        }

        public PartTypeDto[] GetAllPartTypes()
        {
            return _repository.Query<PartTypeDto>(_sql.GetAll, reader => new PartTypeDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                PartNumber = reader["part_number"]?.ToString(),
                Description = reader["description"]?.ToString(),
                CompatibleBusModels = reader["compatible_bus_models"]?.ToString()
            }).ToArray();
        }

        public PartTypeDto GetPartTypeById(int id)
        {
            return _repository.Query<PartTypeDto>(_sql.GetById, reader => new PartTypeDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                PartNumber = reader["part_number"]?.ToString(),
                Description = reader["description"]?.ToString(),
                CompatibleBusModels = reader["compatible_bus_models"]?.ToString()
            }, new NpgsqlParameter("id", id)).FirstOrDefault();
        }

        public PartTypeDto[] SearchPartTypes(string searchTerm)
        {
            return _repository.Query<PartTypeDto>(_sql.Search, reader => new PartTypeDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                PartNumber = reader["part_number"]?.ToString(),
                Description = reader["description"]?.ToString(),
                CompatibleBusModels = reader["compatible_bus_models"]?.ToString()
            }, new NpgsqlParameter("searchTerm", searchTerm)).ToArray();
        }

        public PartTypeDto GetPartTypeByNumber(string partNumber)
        {
            return _repository.Query<PartTypeDto>(_sql.GetByPartNumber, reader => new PartTypeDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                PartNumber = reader["part_number"]?.ToString()
            }, new NpgsqlParameter("partNumber", partNumber)).FirstOrDefault();
        }

        public void CreatePartType(string name, string partNumber, string description, string compatibleBusModels)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", name),
                new NpgsqlParameter("@partNumber", partNumber ?? (object)DBNull.Value),
                new NpgsqlParameter("@description", description ?? (object)DBNull.Value),
                new NpgsqlParameter("@compatibleBusModels", compatibleBusModels ?? (object)DBNull.Value)
            };

            try
            {
                var rowsAffected = _repository.Execute(_sql.Create, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Тип запчасти успешно создан!");
                }
                else
                {
                    MessageBox.Show("Ошибка при создании типа запчасти!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании типа запчасти: {ex.Message}");
            }
        }

        public void UpdatePartType(int id, string name, string partNumber, string description, string compatibleBusModels)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@name", name),
                new NpgsqlParameter("@partNumber", partNumber ?? (object)DBNull.Value),
                new NpgsqlParameter("@description", description ?? (object)DBNull.Value),
                new NpgsqlParameter("@compatibleBusModels", compatibleBusModels ?? (object)DBNull.Value)
            };

            var rowsAffected = _repository.Execute(_sql.Update, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Тип запчасти успешно обновлен!");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении типа запчасти!");
            }
        }

        public void DeletePartType(int id)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", id)
            };

            var rowsAffected = _repository.Execute(_sql.Delete, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Тип запчасти успешно удален!");
            }
            else
            {
                MessageBox.Show("Ошибка при удалении типа запчасти!");
            }
        }
    }
}