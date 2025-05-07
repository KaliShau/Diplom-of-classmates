using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Services.Role;
using EduManage.Services.Staff;

namespace EduManage.Services.User
{
    public class UserDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Логин")]
        public string Login { get; set; }


        [DisplayName("Пароль")]
        public string Password { get; set; }


        [DisplayName("Роль")]
        public RoleDto Role { get; set; }


        [DisplayName("Id сотрудника")]
        public int? StaffId { get; set; }
    }

    public class UserWithStaffDto : UserDto
    {
        public StaffDto StaffInfo { get; set; }
    }

    public class UserCreateDto
    {
        [Required(ErrorMessage = "Логин обязателен")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина логина должна быть от 3 до 50 символов")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Пароль обязателен")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Длина пароля должна быть от 6 до 100 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Роль обязательна")]
        public int RoleId { get; set; }

        public int? StaffId { get; set; }
    }

    public class UserDtoAll
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Логин")]
        public string Login { get; set; }

        [DisplayName("Пароль")]
        public string Password { get; set; }

        // Role fields
        [DisplayName("ID роли")]
        public int RoleId { get; set; }

        [DisplayName("Роль")]
        public string RoleName { get; set; }

        // Staff fields
        [DisplayName("ID сотрудника")]
        public int? StaffId { get; set; }

        [DisplayName("ФИО")]
        public string StaffFullName { get; set; }

        [DisplayName("Должность")]
        public string StaffPosition { get; set; }

        [DisplayName("Отдел")]
        public string StaffDepartment { get; set; }

        [DisplayName("Телефон")]
        public string StaffPhone { get; set; }

        [DisplayName("Дата приема")]
        public DateTime? StaffHireDate { get; set; }

        [DisplayName("Активен")]
        public bool? StaffIsActive { get; set; }
    }
}
