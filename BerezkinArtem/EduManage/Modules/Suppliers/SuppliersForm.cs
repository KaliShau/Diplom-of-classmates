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

namespace EduManage.Modules.Suppliers
{
    public partial class SuppliersForm : Form
    {
        SuppliersController _controller;
        string _selectedId;
        public SuppliersForm(SuppliersController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetSuppliers(suppliersGrid);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _controller.CreateSupplier(nameBox.Text, contactBox.Text, phoneBox.Text);
            _controller.GetSuppliers(suppliersGrid);
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            contactBox.Clear();
            phoneBox.Clear();

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

        private void suppliersGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = suppliersGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    suppliersGrid.Rows[hitTest.RowIndex].Selected = true;
                    _selectedId = suppliersGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(suppliersGrid, e.Location);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteSuplier(Convert.ToInt32(_selectedId));
            _controller.GetSuppliers(suppliersGrid);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                _controller.GetSuppliers(suppliersGrid);
            }
            else
            {
                _controller.GetSuppliersSearch(suppliersGrid, searchTerm);
            }
        }
    }
}
