using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduManage.Modules.Roles
{
    public partial class RolesForm : Form
    {
        RolesController _controller;
        string _selectedId;
        public RolesForm(RolesController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetRoles(rolesGrid);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                createPanel.Visible = true;
                createButton.Text = "Добавить";
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _controller.CreateRole(nameBox, descriptionBox);
            _controller.GetRoles(rolesGrid);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteRole(Convert.ToInt32(_selectedId));
            _controller.GetRoles(rolesGrid);
        }

        private void rolesGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = rolesGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    rolesGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = rolesGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(rolesGrid, e.Location);
                }
            }
        }
    }
}
