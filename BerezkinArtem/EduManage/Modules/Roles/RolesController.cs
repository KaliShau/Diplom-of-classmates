using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Modules.Inventory;
using EduManage.Services.Role;

namespace EduManage.Modules.Roles
{
    public class RolesController
    {
        RoleService _roleService;
        DocumentGenerator _documentGenerator;
        public RolesController(RoleService roleService)
        {
            _roleService = roleService;
            _documentGenerator = new DocumentGenerator();
        }

        public void GetRoles(DataGridView roleGrid)
        {
            var roles = _roleService.GetAllRoles();
            roleGrid.AutoGenerateColumns = true;
            roleGrid.DataSource = roles;
        }


        public void CreateRole(TextBox nameBox, TextBox descriptionBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(descriptionBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _roleService.CreateRole(new RoleDto { Name = nameBox.Text, Description = descriptionBox.Text });
        }

        public void DeleteRole(int id)
        {
            _roleService.DeleteRole(id);
        }

        public void GetUpdatedRole(int id, TextBox nameBox, TextBox descriptionBox)
        {
            var role = _roleService.GetRole(id);

            nameBox.Text = role.Name;
            descriptionBox.Text = role.Description;
        }

        public void UpdateRole(int id, TextBox nameBox, TextBox descriptionBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(descriptionBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _roleService.UpdateRole(new RoleDto { Id = id, Name = nameBox.Text, Description = descriptionBox.Text });
        }

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить роли как DOCX";
                saveFileDialog.FileName = $"Роли_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<RoleDto>;
                    if (dataSource != null)
                    {
                        string description = "Данный документ содержит полный перечень ролей в этой информационной системе.";
                        _documentGenerator.SaveToDocx(
                            saveFileDialog.FileName,
                            "Список ролей",
                            description,
                            dataSource);
                    }
                }
            }
        }
    }
}
