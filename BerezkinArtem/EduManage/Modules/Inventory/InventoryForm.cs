namespace EduManage.Modules.Inventory
{
    public partial class InventoryForm : Form
    {
        InventoryController _controller;
        public InventoryForm(InventoryController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetInventory(inventoryGrid);
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
            }
        }
    }
}
