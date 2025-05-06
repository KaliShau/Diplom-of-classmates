using EduManage.Shared.Main;
using Npgsql;

namespace EduManage.Services.User
{
    public class UserService
    {
        DatabaseRepository _repository;
        UserSQL _sql;
        public UserService(DatabaseRepository databaseRepository)
        {
            _repository = databaseRepository;
            _sql = new UserSQL();
        }

        public UserWithStaffDto SignIn(string login, string password)
        {
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@password", password),
                new NpgsqlParameter("@login", login),
            };

            return _repository.Query<UserWithStaffDto>(_sql.signIn, reader => new UserWithStaffDto
            {
                Id = Convert.ToInt32(reader["ID"]),
                Login = reader["username"].ToString(),
                Password = reader["password"].ToString(),
                Role = new RoleDto
                {
                    Id = Convert.ToInt32(reader["role_id"]),
                    Name = reader["role_name"].ToString()
                },
                StaffInfo = new StaffDto
                {
                    FullName = $"{reader["first_name"]} {reader["last_name"]}",
                    Phone = reader["phone_number"].ToString(),
                    Position = reader["position"]?.ToString(),
                    Department = reader["department"]?.ToString(),
                    HireDate = reader["hire_date"] != DBNull.Value ? Convert.ToDateTime(reader["hire_date"]) : DateTime.MinValue,
                    IsActive = reader["is_active"] != DBNull.Value && Convert.ToBoolean(reader["is_active"])
                }
            }, parameters).FirstOrDefault();
        }
    }
}
