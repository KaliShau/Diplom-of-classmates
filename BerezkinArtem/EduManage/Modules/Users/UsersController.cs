using System;
using System.Windows.Forms;
using EduManage.Services.Role;
using EduManage.Services.Staff;
using EduManage.Services.User;

namespace EduManage.Modules.Users
{
    public class UsersController
    {
        UserService _userService;
        RoleService _roleService;
        StaffService _staffService;
        public UsersController(UserService userService, RoleService roleService, StaffService staffService)
        {
            _userService = userService;
            _roleService = roleService;
            _staffService = staffService;
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

            _userService.CreateUser(new UserCreateDto { Login = loginBox.Text, Password = passwordBox.Text, RoleId = Convert.ToInt16(roleBox.SelectedValue), StaffId = Convert.ToInt16(staffBox.SelectedValue) });
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

        public void GetUpdatedUser(int id, TextBox loginBox, TextBox passwordBox, ComboBox roleBox, ComboBox staffBox)
        {
            var user = _userService.GetById(id);

            loginBox.Text = user.Login;
            passwordBox.Text = user.Password;
            roleBox.SelectedValue = user.RoleId;
            staffBox.SelectedValue = user.StaffId;
        }

        public void UpdateUser(int id, TextBox loginBox, TextBox passwordBox, ComboBox roleBox, ComboBox staffBox)
        {
            if (string.IsNullOrEmpty(loginBox.Text) || string.IsNullOrEmpty(passwordBox.Text) || string.IsNullOrEmpty(roleBox.Text) || string.IsNullOrEmpty(staffBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _userService.UpdateUser(new UserUpdateDto { Id = id, Login = loginBox.Text, Password = passwordBox.Text, RoleId = Convert.ToInt32(roleBox.SelectedValue), StaffId = Convert.ToInt32(staffBox.SelectedValue) });
        }
    }
}
