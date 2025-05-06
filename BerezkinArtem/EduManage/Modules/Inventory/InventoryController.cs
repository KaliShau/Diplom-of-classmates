using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Services.Inventory;

namespace EduManage.Modules.Inventory
{
    public class InventoryController
    {
        InventoryService _inventoryService;
        public InventoryController(InventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public void GetInventory(DataGridView inventoryGrid)
        {
            var inventories = _inventoryService.GetInventories();
            inventoryGrid.AutoGenerateColumns = true;
            inventoryGrid.DataSource = inventories;
        }

        public void GetInventorySearch(DataGridView inventoryGrid, string searchTerm)
        {
            var inventories = _inventoryService.GetInventoriesSearch(searchTerm);
            inventoryGrid.AutoGenerateColumns = true;
            inventoryGrid.DataSource = inventories;
        }

        public void CreateInventory(TextBox nameBox, TextBox categortBox, TextBox quantityBox, TextBox roomBox, TextBox statusBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(categortBox.Text) || string.IsNullOrEmpty(quantityBox.Text) || string.IsNullOrEmpty(roomBox.Text) || string.IsNullOrEmpty(statusBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            _inventoryService.CreateInventiry(nameBox.Text, categortBox.Text, quantityBox.Text, roomBox.Text, statusBox.Text);

            nameBox.Clear();
            categortBox.Clear();
            quantityBox.Clear();
            roomBox.Clear();
            statusBox.Clear();
        }

        public void UpdateInventory(int id,TextBox nameBox, TextBox categortBox, TextBox quantityBox, TextBox roomBox, TextBox statusBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(categortBox.Text) || string.IsNullOrEmpty(quantityBox.Text) || string.IsNullOrEmpty(roomBox.Text) || string.IsNullOrEmpty(statusBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            _inventoryService.UpdateInventiry(id, nameBox.Text, categortBox.Text, quantityBox.Text, roomBox.Text, statusBox.Text);

        }

        public void DeleteInventory(int id)
        {
            _inventoryService.DeleteInventory(id);
        }

        public void GetByIdToUpdate(int id, TextBox nameBox, TextBox categortBox, TextBox quantityBox, TextBox roomBox, TextBox statusBox)
        {
            var inventory = _inventoryService.GetById(id);  

            nameBox.Text = inventory.Name;
            categortBox.Text = inventory.Category;
            quantityBox.Text = inventory.Quantity;
            roomBox.Text = inventory.Room;
            statusBox.Text = inventory.Status;
        }

        public void ChangeStatus(int id, string status)
        {
            _inventoryService.UpdateInventoryStatus(id, status);
        }
    }
}
