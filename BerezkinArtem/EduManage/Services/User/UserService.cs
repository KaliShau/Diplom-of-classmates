using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using EduManage.Services.Role;
using EduManage.Services.Staff;
using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.User
{
    public class UserService : IDisposable
    {
        private readonly DatabaseRepository _repository;
        private readonly UserSQL _sql;
        private readonly StaffService _staffService;
        private bool _disposed = false;

        public UserService(DatabaseRepository databaseRepository, StaffService staffService)
        {
            _repository = databaseRepository ?? throw new ArgumentNullException(nameof(databaseRepository));
            _sql = new UserSQL();
            _staffService = staffService ?? throw new ArgumentNullException(nameof(staffService));
        }

        public UserWithStaffDto SignIn(string login, string password)
        {
            try
            {
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@login", login),
                    new NpgsqlParameter("@password", password)
                };

                var result = _repository.Query<UserWithStaffDto>(_sql.SignIn, reader =>
                {
                    var user = new UserWithStaffDto
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Login = reader["login"].ToString(),
                        Password = reader["password"].ToString(),
                        Role = new RoleDto
                        {
                            Id = Convert.ToInt32(reader["role_id"]),
                            Name = reader["role_name"].ToString()
                        }
                    };

                    if (reader["staff_id"] != DBNull.Value)
                    {
                        user.StaffInfo = new StaffDto
                        {
                            Id = Convert.ToInt32(reader["staff_id"]),
                            FullName = reader["full_name"].ToString(),
                            Position = reader["position"]?.ToString(),
                            Department = reader["department"]?.ToString(),
                            Phone = reader["phone"]?.ToString(),
                            HireDate = Convert.ToDateTime(reader["hire_date"]),
                            IsActive = Convert.ToBoolean(reader["is_active"])
                        };
                        user.StaffId = user.StaffInfo.Id;
                    }

                    return user;
                }, parameters).FirstOrDefault();

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при входе: {ex.Message}");
                return null;
            }
        }

        public UserDtoAll[] GetAll()
        {
            try
            {
                return _repository.Query<UserDtoAll>(_sql.GetAll, reader => new UserDtoAll
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Login = reader["login"].ToString(),
                    Password = reader["password"].ToString(),
                    RoleId = Convert.ToInt32(reader["role_id"]),
                    RoleName = reader["role_name"].ToString(),
                    StaffId = reader["staff_id"] != DBNull.Value ? Convert.ToInt32(reader["staff_id"]) : (int?)null,
                    StaffFullName = reader["full_name"]?.ToString(),
                    StaffPosition = reader["position"]?.ToString(),
                    StaffDepartment = reader["department"]?.ToString(),
                    StaffPhone = reader["phone"]?.ToString(),
                    StaffHireDate = reader["hire_date"] != DBNull.Value ? Convert.ToDateTime(reader["hire_date"]) : (DateTime?)null,
                    StaffIsActive = reader["is_active"] != DBNull.Value ? Convert.ToBoolean(reader["is_active"]) : (bool?)null
                }).ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении списка пользователей: {ex.Message}");
                return Array.Empty<UserDtoAll>();
            }
        }

        public UserDtoAll GetById(int id)
        {
            try
            {
                return _repository.Query<UserDtoAll>(_sql.GetById, reader => new UserDtoAll
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Login = reader["login"].ToString(),
                    Password = reader["password"].ToString(),
                    RoleId = Convert.ToInt32(reader["role_id"]),
                    RoleName = reader["role_name"].ToString(),
                    StaffId = reader["staff_id"] != DBNull.Value ? Convert.ToInt32(reader["staff_id"]) : (int?)null,
                    StaffFullName = reader["full_name"]?.ToString(),
                    StaffPosition = reader["position"]?.ToString(),
                    StaffDepartment = reader["department"]?.ToString(),
                    StaffPhone = reader["phone"]?.ToString(),
                    StaffHireDate = reader["hire_date"] != DBNull.Value ? Convert.ToDateTime(reader["hire_date"]) : (DateTime?)null,
                    StaffIsActive = reader["is_active"] != DBNull.Value ? Convert.ToBoolean(reader["is_active"]) : (bool?)null
                }, new NpgsqlParameter("@id", id)).Single();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении пользователя: {ex.Message}");
                return null;
            }
        }

        public bool CreateUser(UserCreateDto userDto)
        {
            var transaction = _repository.BeginTransaction();
            try
            {
                var validationContext = new ValidationContext(userDto);
                Validator.ValidateObject(userDto, validationContext, true);

                var userParams = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@login", userDto.Login),
                    new NpgsqlParameter("@password", userDto.Password),
                    new NpgsqlParameter("@roleId", userDto.RoleId)
                };

                int userId = _repository.ExecuteScalar<int>(_sql.Create, transaction, userParams);

                if (userId == 0)
                {
                    _repository.RollbackTransaction();
                    MessageBox.Show("Не удалось создать пользователя");
                    return false;
                }

                if (userDto.StaffId.HasValue)
                {
                    bool staffHasUser = _repository.ExecuteScalar<bool>(
                        "SELECT EXISTS(SELECT 1 FROM staff WHERE id = @staffId AND user_id IS NOT NULL)",
                        transaction,
                        new NpgsqlParameter("@staffId", userDto.StaffId.Value)
                    );

                    if (staffHasUser)
                    {
                        _repository.RollbackTransaction();
                        MessageBox.Show("Этот сотрудник уже привязан к другому пользователю");
                        return false;
                    }

                    int staffUpdated = _repository.Execute(
                        _sql.UpdateStaffUserId,
                        transaction,
                        new NpgsqlParameter("@userId", userId),
                        new NpgsqlParameter("@staffId", userDto.StaffId.Value)
                    );

                    if (staffUpdated == 0)
                    {
                        _repository.RollbackTransaction();
                        MessageBox.Show("Сотрудник не найден");
                        return false;
                    }
                }

                _repository.CommitTransaction();
                MessageBox.Show("Пользователь успешно создан!");
                return true;
            }
            catch (ValidationException ex)
            {
                _repository.RollbackTransaction();
                MessageBox.Show($"Ошибка валидации: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                _repository.RollbackTransaction();
                MessageBox.Show($"Ошибка при создании пользователя: {ex.Message}");
                return false;
            }
        }

        public bool UpdateUser(UserUpdateDto userDto)
        {
            var transaction = _repository.BeginTransaction();
            try
            {
                var validationContext = new ValidationContext(userDto);
                Validator.ValidateObject(userDto, validationContext, true);

                var userParams = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@id", userDto.Id),
                    new NpgsqlParameter("@login", userDto.Login),
                    new NpgsqlParameter("@password", userDto.Password),
                    new NpgsqlParameter("@roleId", userDto.RoleId),
                    new NpgsqlParameter("@staffId", userDto.StaffId ?? (object)DBNull.Value)
                };

                int rowsAffected = _repository.Execute(_sql.Update, transaction, userParams);

                if (rowsAffected == 0)
                {
                    _repository.RollbackTransaction();
                    MessageBox.Show("Пользователь не найден");
                    return false;
                }

                if (userDto.StaffId.HasValue)
                {
                    bool staffHasOtherUser = _repository.ExecuteScalar<bool>(
                        "SELECT EXISTS(SELECT 1 FROM staff WHERE id = @staffId AND user_id IS NOT NULL AND user_id != @userId)",
                        transaction,
                        new NpgsqlParameter("@staffId", userDto.StaffId.Value),
                        new NpgsqlParameter("@userId", userDto.Id)
                    );

                    if (staffHasOtherUser)
                    {
                        _repository.RollbackTransaction();
                        MessageBox.Show("Этот сотрудник уже привязан к другому пользователю");
                        return false;
                    }
                }

                _repository.CommitTransaction();
                MessageBox.Show("Пользователь успешно обновлен!");
                return true;
            }
            catch (ValidationException ex)
            {
                _repository.RollbackTransaction();
                MessageBox.Show($"Ошибка валидации: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                _repository.RollbackTransaction();
                MessageBox.Show($"Ошибка при обновлении пользователя: {ex.Message}");
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            var transaction = _repository.BeginTransaction();
            try
            {
                int staffUpdated = _repository.Execute(
                    "UPDATE staff SET user_id = NULL WHERE user_id = @id",
                    transaction,
                    new NpgsqlParameter("@id", id)
                );

                int rowsAffected = _repository.Execute(
                    _sql.Delete,
                    transaction,
                    new NpgsqlParameter("@id", id)
                );

                if (rowsAffected == 0)
                {
                    _repository.RollbackTransaction();
                    MessageBox.Show("Пользователь не найден");
                    return false;
                }

                _repository.CommitTransaction();
                MessageBox.Show("Пользователь успешно удален!");
                return true;
            }
            catch (PostgresException ex) when (ex.SqlState == "23503")
            {
                _repository.RollbackTransaction();
                MessageBox.Show("Нельзя удалить пользователя: имеются связанные записи в других таблицах");
                return false;
            }
            catch (Exception ex)
            {
                _repository.RollbackTransaction();
                MessageBox.Show($"Ошибка при удалении пользователя: {ex.Message}");
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _repository?.Dispose();
                }
                _disposed = true;
            }
        }
    }
}