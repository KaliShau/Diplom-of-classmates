using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduManage.Modules.Home;
using EduManage.Shared.Main;

namespace EduManage.Modules.Purchases
{
    public partial class PurchasesForm : Form
    {
        PurchasesController _controller;
        string _selectedId;
        public PurchasesForm(PurchasesController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetPurchases(purchasesGrid);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;

        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            unitBox.Clear();

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _controller.AddSuppliersToComboBox(supplierBox);
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
            _controller.CreatePurchases(nameBox, numericUpDown, unitBox, supplierBox);
            _controller.GetPurchases(purchasesGrid);
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
    }
}
