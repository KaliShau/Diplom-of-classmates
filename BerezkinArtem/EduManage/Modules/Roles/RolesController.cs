using System.Windows.Forms;
using EduManage.Services.Role;

namespace EduManage.Modules.Roles
{
    public class RolesController
    {
        RoleService _roleService;
        public RolesController(RoleService roleService)
        {
            _roleService = roleService;
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
    }
}
