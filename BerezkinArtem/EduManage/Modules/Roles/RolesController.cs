using EduManage.Services.Role;
using EduManage.Services.Staff;
using System.Windows.Forms;

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

            _roleService.CreateRole(new RoleDto{ Name = nameBox.Text, Description = descriptionBox.Text});
        }

        public void DeleteRole(int id)
        {
            _roleService.DeleteRole(id);
        }
    }
}
