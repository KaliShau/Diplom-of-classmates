using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduManage.Modules.Requests
{
    public partial class RequestsForm : Form
    {
        RequestsController _controller;
        string _selectedId;
        public RequestsForm(RequestsController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetRequests(requestsGrid);
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _controller.AddInventoryToComboBox(inventoryBox);
                createPanel.Visible = true;
                createButton.Text = "Добавить";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(problemBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;

            }
            _controller.CreateRequests(Convert.ToInt16(inventoryBox.SelectedValue), problemBox.Text);
            _controller.GetRequests(requestsGrid);
        }

        private void requestsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = requestsGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    requestsGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = requestsGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(requestsGrid, e.Location);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteRequest(Convert.ToInt32(_selectedId));
            _controller.GetRequests(requestsGrid);
            problemBox.Clear();
        }
    }
}
