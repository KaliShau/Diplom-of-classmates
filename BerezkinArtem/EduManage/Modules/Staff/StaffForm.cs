using System;
using System.Windows.Forms;

namespace EduManage.Modules.Staff
{
    enum Action { Update, Create }
    public partial class StaffForm : Form
    {
        StaffController _controller;
        string _selectedId;
        Action _typeAction;

        public StaffForm(StaffController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetStaff(staffGrid);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            positionBox.Clear();
            departmentBox.Clear();
            phoneBox.Clear();

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

        private void createButton_Click(object sender, EventArgs e)
        {
            if (_typeAction == Action.Create)
            {
                _controller.CreateStaff(nameBox, positionBox, departmentBox, phoneBox, hireDatePicker);
                _controller.GetStaff(staffGrid);
            }
            if (_typeAction == Action.Update)
            {
                _controller.UpdateStaff(Convert.ToInt32(_selectedId), nameBox, positionBox, departmentBox, phoneBox, hireDatePicker);
                _controller.GetStaff(staffGrid);
            }
        }

        private void staffGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = staffGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    staffGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = staffGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(staffGrid, e.Location);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteStaff(Convert.ToInt32(_selectedId));
            _controller.GetStaff(staffGrid);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                _controller.GetStaff(staffGrid);
            }
            else
            {
                _controller.GetStaffsSearch(staffGrid, searchTerm);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            positionBox.Clear();
            departmentBox.Clear();
            phoneBox.Clear();

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _controller.GetUpdatedStaff(Convert.ToInt32(_selectedId), nameBox, positionBox, departmentBox, phoneBox, hireDatePicker);

                _typeAction = Action.Update;
                createPanel.Visible = true;
                createButton.Text = "Обновить";
            }
        }

        private void changeActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ChangeActive(Convert.ToInt32(_selectedId));
            _controller.GetStaff(staffGrid);
        }

        private void saveToDocxButton_Click(object sender, EventArgs e)
        {
            _controller.ExportToDocx(staffGrid);
        }
    }
}
