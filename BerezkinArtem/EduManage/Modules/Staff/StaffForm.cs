using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduManage.Modules.Staff
{
    public partial class StaffForm : Form
    {
        StaffController _controller;
        string _selectedId;
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
            _controller.CreateStaff(nameBox, positionBox, departmentBox, phoneBox, hireDatePicker);
            _controller.GetStaff(staffGrid);
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
    }
}
