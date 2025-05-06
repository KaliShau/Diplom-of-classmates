namespace EduManage.Modules.Inventory
{
    enum Action { Update, Create }
    public partial class InventoryForm : Form
    {
        InventoryController _controller;
        string _selectedId;
        Action _typeAction;
        public InventoryForm(InventoryController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetInventory(inventoryGrid);

        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            categoryBox.Clear();
            quantityBox.Clear();
            roomBox.Clear();
            statusBox.Clear();

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
                _controller.CreateInventory(nameBox, categoryBox, quantityBox, roomBox, statusBox);
                _controller.GetInventory(inventoryGrid);
            }
            if (_typeAction == Action.Update)
            {
                _controller.UpdateInventory(Convert.ToInt32(_selectedId), nameBox, categoryBox, quantityBox, roomBox, statusBox);
                _controller.GetInventory(inventoryGrid);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                _controller.GetInventory(inventoryGrid);
            }
            else
            {
                _controller.GetInventorySearch(inventoryGrid, searchTerm);
            }
        }

        private void inventoryGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = inventoryGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    inventoryGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = inventoryGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(inventoryGrid, e.Location);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteInventory(Convert.ToInt32(_selectedId));
            _controller.GetInventory(inventoryGrid);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _typeAction = Action.Update;
            createPanel.Visible = true;
            createButton.Text = "Обновить";

            _controller.GetByIdToUpdate(Convert.ToInt32(_selectedId), nameBox, categoryBox, quantityBox, roomBox, statusBox);
        }

        private void updateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string status = toolStripStatusBox.Text;

            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Выберите статус!");
                return;
            }

            _controller.ChangeStatus(Convert.ToInt32(_selectedId), status);
            _controller.GetInventory(inventoryGrid);
        }
    }


}
