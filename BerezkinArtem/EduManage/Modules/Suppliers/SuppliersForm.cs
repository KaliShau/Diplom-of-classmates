using System;
using System.Windows.Forms;

namespace EduManage.Modules.Suppliers
{
    enum Action { Update, Create }
    public partial class SuppliersForm : Form
    {
        SuppliersController _controller;
        string _selectedId;
        Action _typeAction;

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
            if (_typeAction == Action.Create)
            {
                _controller.CreateSupplier(nameBox.Text, contactBox.Text, phoneBox.Text);
                _controller.GetSuppliers(suppliersGrid);
            }
            if (_typeAction == Action.Update)
            {
                _controller.UpdateSupplier(Convert.ToInt32(_selectedId), nameBox, contactBox, phoneBox);
                _controller.GetSuppliers(suppliersGrid);
            }
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
                _typeAction = Action.Create;
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
            _controller.DeleteSupplier(Convert.ToInt32(_selectedId));
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
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
                _controller.GetUpdatedSupplier(Convert.ToInt32(_selectedId), nameBox, contactBox, phoneBox);
                _typeAction = Action.Update;
                createPanel.Visible = true;
                createButton.Text = "Обновить";
            }
        }

        private void saveToDocxButton_Click(object sender, EventArgs e)
        {
            _controller.ExportToDocx(suppliersGrid);
        }
    }
}
