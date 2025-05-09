using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Modules.Inventory;
using EduManage.Services.Inventory;
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
        DocumentGenerator _documentGenerator;
        public UsersController(UserService userService, RoleService roleService, StaffService staffService)
        {
            _userService = userService;
            _roleService = roleService;
            _staffService = staffService;
            _documentGenerator = new DocumentGenerator();
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

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить пользователей как DOCX";
                saveFileDialog.FileName = $"Пользователи_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<InventoryDto>;
                    if (dataSource != null)
                    {
                        string description = "Данный документ содержит полный перечень пользователей в этой ифнормационной системе.";
                        _documentGenerator.SaveToDocx(
                            saveFileDialog.FileName,
                            "Список пользователей",
                            description,
                            dataSource);
                    }
                }
            }
        }
    }
}
