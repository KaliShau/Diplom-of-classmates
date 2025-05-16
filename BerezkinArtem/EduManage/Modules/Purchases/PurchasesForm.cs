using System;
using System.Windows.Forms;

namespace EduManage.Modules.Purchases
{
    enum Action { Update, Create }
    public partial class PurchasesForm : Form
    {
        PurchasesController _controller;
        string _selectedId;
        Action _typeAction;

        public PurchasesForm(PurchasesController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetPurchases(purchasesGrid);
            _controller.AddSuppliersToComboBox(supplierBox);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            unitBox.Clear();
            priceBox.Clear();
            numericUpDown.Value = 0;

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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                _controller.GetPurchases(purchasesGrid);
            }
            else
            {
                _controller.GetPurchasesSearch(purchasesGrid, searchTerm);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (_typeAction == Action.Create)
            {
                _controller.CreatePurchases(nameBox, numericUpDown, unitBox, supplierBox, priceBox);
                _controller.GetPurchases(purchasesGrid);
            }
            if (_typeAction == Action.Update)
            {
                _controller.UpdatePurchase(Convert.ToInt32(_selectedId), nameBox, numericUpDown, unitBox, supplierBox, priceBox);
                _controller.GetPurchases(purchasesGrid);
            }
        }

        private void purchasesGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = purchasesGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    purchasesGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = purchasesGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(purchasesGrid, e.Location);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeletePurchase(Convert.ToInt32(_selectedId));
            _controller.GetPurchases(purchasesGrid);
        }

        private void addToInventoruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AddPurchaseToInventory(Convert.ToInt32(_selectedId));
            _controller.GetPurchases(purchasesGrid);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            unitBox.Clear();
            priceBox.Clear();
            numericUpDown.Value = 0;

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _controller.GetUpdatedPurchase(Convert.ToInt32(_selectedId), nameBox, numericUpDown, unitBox, supplierBox, priceBox);

                _typeAction = Action.Update;
                createPanel.Visible = true;
                createButton.Text = "Обновить";
            }
        }

        private void updateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.UpdateStatus(Convert.ToInt32(_selectedId), updateStatustoolStripComboBox);
            _controller.GetPurchases(purchasesGrid);
        }

        private void saveToDocxButton_Click(object sender, EventArgs e)
        {
            _controller.ExportToDocx(purchasesGrid);
        }
    }
}
