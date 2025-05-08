using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Shared.Main;
using Npgsql;
using System.Windows.Forms;


namespace EduManage.Services.Role
{
    public class RoleService
    {
        private readonly DatabaseRepository _repository;
        private readonly RoleSQL _sql;

        public RoleService(DatabaseRepository repository)
        {
            _repository = repository;
            _sql = new RoleSQL();
        }

        public void CreateRole(RoleDto role)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@name", role.Name),
                    new NpgsqlParameter("@description", role.Description ?? (object)DBNull.Value)
                };

                var rowsAffected = _repository.Execute(_sql.Create, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Роль успешно создана!");
                }
                else
                {
                    MessageBox.Show("Ошибка при создании роли!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании роли: {ex.Message}");
            }
        }

        public void UpdateRole(RoleDto role)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id", role.Id),
                    new NpgsqlParameter("@name", role.Name),
                    new NpgsqlParameter("@description", role.Description ?? (object)DBNull.Value)
                };

                var rowsAffected = _repository.Execute(_sql.Update, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Роль успешно обновлена!");
                }
                else
                {
                    MessageBox.Show("Роль не найдена или данные не изменились");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении роли: {ex.Message}");
            }
        }

        public RoleDto GetRole(int id)
        {
            return _repository.Query<RoleDto>(_sql.GetById, reader => new RoleDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Description = reader["description"] != DBNull.Value ? reader["description"].ToString() : null
            }, new NpgsqlParameter("@id", id)).FirstOrDefault();
        }

        public RoleDto[] GetAllRoles()
        {
            return _repository.Query<RoleDto>(_sql.GetAll, reader => new RoleDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Description = reader["description"] != DBNull.Value ? reader["description"].ToString() : null
            }).ToArray();
        }

        public void DeleteRole(int id)
        {
            try
            {
                int rowsAffected = _repository.Execute(_sql.Delete, new NpgsqlParameter("@id", id));

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Роль успешно удалена!");
                }
                else
                {
                    MessageBox.Show("Роль не найдена!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении роли: {ex.Message}");
            }
        }

        public bool RoleExists(string name)
        {
            return _repository.Query<bool>(_sql.Exists,
                reader => Convert.ToBoolean(reader["exists"]),
                new NpgsqlParameter("@name", name)).FirstOrDefault();
        }
    }

}
