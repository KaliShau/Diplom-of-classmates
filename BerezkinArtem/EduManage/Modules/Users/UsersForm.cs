using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduManage.Shared;

namespace EduManage.Modules.Users
{
    public partial class UsersForm : Form
    {
        UsersController _controller;
        string _selectedId;
        public UsersForm(UsersController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.AddRolesToComboBox(roleBox);
            _controller.AddStaffsToComboBox(staffBox);
            _controller.GetUsers(usersGrid);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _controller.CreateUser(loginBox, passwordBox, roleBox, staffBox);
            _controller.GetUsers(usersGrid);
        }

        private void usersGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = usersGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    usersGrid.Rows[hitTest.RowIndex].Selected = true;
                    _selectedId = usersGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();


                    contextMenuStrip1.Show(usersGrid, e.Location);
                }
            }
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteRequest(Convert.ToInt32(_selectedId));
            _controller.GetUsers(usersGrid);
        }
    }
}
