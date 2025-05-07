using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Services.Inventory;
using EduManage.Services.Request;
using EduManage.Services.Role;
using EduManage.Services.Staff;
using EduManage.Services.User;
using EduManage.Shared;

namespace EduManage.Modules.Users
{
    public class UsersController
    {
        UserService _userService;
        RoleService _roleService;
        StaffService _staffService;
        Context _context;
        public UsersController(Context context, UserService userService, RoleService roleService, StaffService staffService)
        {
            _userService = userService;
            _roleService = roleService;
            _staffService = staffService;
            _context = context;
        }

        public void AddRolesToComboBox(ComboBox rolesBox)
        {
            rolesBox.DataSource = _roleService.GetAllRoles();
            rolesBox.DisplayMember = "name";
            rolesBox.ValueMember = "id";
        }

        public void AddStaffsToComboBox(ComboBox staffsBox)
        {
            staffsBox.DataSource = _staffService.GetAllStaff();
            staffsBox.DisplayMember = "FullName";
            staffsBox.ValueMember = "id";
        }

        public void CreateUser(TextBox loginBox, TextBox passwordBox, ComboBox roleBox, ComboBox staffBox)
        {
            if (string.IsNullOrEmpty(loginBox.Text) || string.IsNullOrEmpty(passwordBox.Text) || string.IsNullOrEmpty(roleBox.Text) || string.IsNullOrEmpty(staffBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _userService.CreateUser(new UserCreateDto{Login = loginBox.Text, Password = passwordBox.Text, RoleId = Convert.ToInt16(roleBox.SelectedValue), StaffId = Convert.ToInt16(staffBox.SelectedValue) });
        }

        public void GetUsers(DataGridView usersGrid)
        {
            var users = _userService.GetAll();
            usersGrid.AutoGenerateColumns = true;
            usersGrid.DataSource = users;
        }

        

        public void DeleteRequest(int id)
        {
            _userService.DeleteUser(id);
        }

        
    }
}
