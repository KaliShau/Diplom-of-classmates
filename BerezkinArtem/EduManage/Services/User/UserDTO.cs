using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Services.User
{
    public class RoleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UserDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public RoleDto Role { get; set; }
    }

    public class StaffDto
    {
        public int Id { get; set; }
        public UserDto User { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string? Phone { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserWithStaffDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public RoleDto Role { get; set; }
        public StaffDto StaffInfo { get; set; }
    }
}
