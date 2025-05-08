using System;
using System.Windows.Forms;

namespace EduManage.Modules.Users
{
    enum Action { Update, Create }
    public partial class UsersForm : Form
    {
        UsersController _controller;
        string _selectedId;
        Action _typeAction;

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
            if (_typeAction == Action.Create)
            {

                _controller.CreateUser(loginBox, passwordBox, roleBox, staffBox);
                _controller.GetUsers(usersGrid);
            }
            if (_typeAction == Action.Update)
            {
                _controller.UpdateUser(Convert.ToInt32(_selectedId), loginBox, passwordBox, roleBox, staffBox);
                _controller.GetUsers(usersGrid);
            }
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
            loginBox.Clear();
            passwordBox.Clear();

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _typeAction = Action.Create;
                createPanel.Visible = true;
                createButton.Text = "Добавить";
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteRequest(Convert.ToInt32(_selectedId));
            _controller.GetUsers(usersGrid);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginBox.Clear();
            passwordBox.Clear();

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _controller.GetUpdatedUser(Convert.ToInt16(_selectedId), loginBox, passwordBox, roleBox, staffBox);

                _typeAction = Action.Update;
                createPanel.Visible = true;
                createButton.Text = "Обновить";
            }
        }
    }
}
