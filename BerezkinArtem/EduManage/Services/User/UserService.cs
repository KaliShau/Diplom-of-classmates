using System.ComponentModel.DataAnnotations;
using EduManage.Services.Role;
using EduManage.Services.Staff;
using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.User
{
    public class UserService
    {
        DatabaseRepository _repository;
        UserSQL _sql;
        StaffService _staffService;
        public UserService(DatabaseRepository databaseRepository, StaffService staffService)
        {
            _repository = databaseRepository;
            _sql = new UserSQL();
            _staffService = staffService;
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


        public void CreateUser(UserCreateDto userDto)
        {
            var transaction = _repository.BeginTransaction();
            try
            {
                // Валидация
                var validationContext = new ValidationContext(userDto);
                Validator.ValidateObject(userDto, validationContext, true);

                // 1. Создаем пользователя
                var userParams = new NpgsqlParameter[]
                {
            new NpgsqlParameter("@login", userDto.Login),
            new NpgsqlParameter("@password", userDto.Password),
            new NpgsqlParameter("@roleId", userDto.RoleId)
                };

                int userId = _repository.ExecuteScalar<int>(_sql.Create, transaction, userParams);

                if (userId == 0)
                    throw new Exception("Не удалось создать пользователя");

                // 2. Привязываем к сотруднику (если указано)
                if (userDto.StaffId.HasValue)
                {
                    // Проверяем, не привязан ли уже сотрудник
                    bool staffHasUser = _repository.ExecuteScalar<bool>(
                        "SELECT EXISTS(SELECT 1 FROM staff WHERE id = @staffId AND user_id IS NOT NULL)",
                        transaction,
                        new NpgsqlParameter("@staffId", userDto.StaffId.Value)
                    );

                    if (staffHasUser)
                    {
                        throw new Exception("Этот сотрудник уже привязан к другому пользователю");
                    }

                    // Выполняем привязку
                    int staffUpdated = _repository.Execute(
                        _sql.UpdateStaffUserId,
                        transaction,
                        new NpgsqlParameter("@userId", userId),
                        new NpgsqlParameter("@staffId", userDto.StaffId.Value)
                    );

                    if (staffUpdated == 0)
                    {
                        throw new Exception("Сотрудник не найден");
                    }
                }

                _repository.CommitTransaction();
                MessageBox.Show("Пользователь успешно создан!");
            }
            catch (ValidationException ex)
            {
                _repository.RollbackTransaction();
                MessageBox.Show($"Ошибка валидации: {ex.Message}");
            }
            catch (PostgresException ex) when (ex.SqlState == "23505")
            {
                _repository.RollbackTransaction();
                MessageBox.Show("Ошибка: логин уже занят");
            }
            catch (Exception ex)
            {
                _repository.RollbackTransaction();
                MessageBox.Show($"Ошибка при создании пользователя: {ex.Message}");
            }
            finally
            {
                _repository.Dispose();
            }
        }


        public void UpdateUser(UserDto user)
        {
            try
            {
                NpgsqlParameter[] parameters = {
                    new NpgsqlParameter("@id", user.Id),
                    new NpgsqlParameter("@login", user.Login),
                    new NpgsqlParameter("@password", user.Password),
                    new NpgsqlParameter("@roleId", user.Role.Id)
                };

                int rowsAffected = _repository.Execute(_sql.Update, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Пользователь обновлен!");
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении пользователя: {ex.Message}");
            }
        }

        public void DeleteUser(int id)
        {
            using (var transaction = _repository.BeginTransaction())
            {
                try
                {
                    // 1. Сначала обновляем связанного сотрудника (если есть)
                    _repository.Execute(
                        "UPDATE staff SET user_id = NULL WHERE user_id = @id",
                        transaction,
                        new NpgsqlParameter("@id", id)
                    );

                    // 2. Затем удаляем пользователя
                    int rowsAffected = _repository.Execute(
                        _sql.Delete,
                        transaction,
                        new NpgsqlParameter("@id", id)
                    );

                    if (rowsAffected > 0)
                    {
                        transaction.Commit();
                        MessageBox.Show("Пользователь успешно удален!");
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show("Пользователь не найден!");
                    }
                }
                catch (PostgresException ex) when (ex.SqlState == "23503")
                {
                    transaction.Rollback();
                    MessageBox.Show("Нельзя удалить пользователя: имеются связанные записи в других таблицах");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка при удалении пользователя: {ex.Message}");
                }
            }
        }
    }
}
