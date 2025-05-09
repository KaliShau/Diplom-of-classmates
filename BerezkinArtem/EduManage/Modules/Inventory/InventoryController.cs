using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Services.Inventory;

namespace EduManage.Modules.Inventory
{
    public class InventoryController
    {
        InventoryService _inventoryService;
        DocumentGenerator _documentGenerator;

        public InventoryController(InventoryService inventoryService)
        {
            _inventoryService = inventoryService;
            _documentGenerator = new DocumentGenerator();
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

        public void CreateInventory(TextBox nameBox, TextBox categortBox, NumericUpDown quantity, TextBox unitBox, TextBox roomBox, ComboBox statusBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(categortBox.Text) || string.IsNullOrEmpty(unitBox.Text) || string.IsNullOrEmpty(roomBox.Text) || string.IsNullOrEmpty(statusBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _inventoryService.CreateInventiry(nameBox.Text, categortBox.Text, Convert.ToInt16(quantity.Value), unitBox.Text, roomBox.Text, statusBox.Text);

            nameBox.Clear();
            categortBox.Clear();
            roomBox.Clear();
        }

        public void UpdateInventory(int id, TextBox nameBox, TextBox categortBox, NumericUpDown quantity, TextBox unitBox, TextBox roomBox, ComboBox statusBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(categortBox.Text) || string.IsNullOrEmpty(unitBox.Text) || string.IsNullOrEmpty(roomBox.Text) || string.IsNullOrEmpty(statusBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }


            _inventoryService.UpdateInventiry(id, nameBox.Text, categortBox.Text, Convert.ToInt16(quantity.Value), unitBox.Text, roomBox.Text, statusBox.Text);

        }

        public void DeleteInventory(int id)
        {
            _inventoryService.DeleteInventory(id);
        }

        public void GetByIdToUpdate(int id, TextBox nameBox, TextBox categortBox, NumericUpDown quantity, TextBox unitBox, TextBox roomBox, ComboBox statusBox)
        {
            var inventory = _inventoryService.GetById(id);

            nameBox.Text = inventory.Name;
            categortBox.Text = inventory.Category;
            quantity.Value = inventory.Quantity;
            unitBox.Text = inventory.Unit;

            roomBox.Text = inventory.Room;
            statusBox.Text = inventory.Status;
        }

        public void ChangeStatus(int id, string status)
        {
            _inventoryService.UpdateInventoryStatus(id, status);
        }

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить инвентарь как DOCX";
                saveFileDialog.FileName = $"Инвентарь_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<InventoryDto>;
                    if (dataSource != null)
                    {
                        string description = "Данный документ содержит полный перечень инвентаря образовательного учреждения.";

                        _documentGenerator.SaveToDocx(
                            saveFileDialog.FileName,
                            "Список инвентаря",
                            description,
                            dataSource);
                    }
                }
            }
        }
    }
}
