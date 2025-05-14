using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Services.Inventory;
using EduManage.Services.Purchases;
using EduManage.Services.Suppliers;

namespace EduManage.Modules.Purchases
{
    public class PurchasesController
    {
        PurchaseService _purchaseService;
        SuppliersService _suppliersService;
        InventoryService _inventoryService;
        Documents _documents;
        public PurchasesController(PurchaseService purchaseService, SuppliersService suppliersService, InventoryService inventoryService)
        {
            _purchaseService = purchaseService;
            _suppliersService = suppliersService;
            _inventoryService = inventoryService;
            _documents = new Documents();
        }

        public void AddSuppliersToComboBox(ComboBox supplierBox)
        {
            supplierBox.DataSource = _suppliersService.GetAllSuppliers();
            supplierBox.DisplayMember = "name";
            supplierBox.ValueMember = "id";
        }

        public void CreatePurchases(TextBox nameBox, NumericUpDown quantitu, TextBox unit, ComboBox supplierBox, TextBox priceBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(unit.Text) || string.IsNullOrEmpty(supplierBox.Text) || string.IsNullOrEmpty(priceBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _purchaseService.CreatePurchase(new PurchaseDto
            {
                ItemName = nameBox.Text,
                Unit = unit.Text,
                Quantity = Convert.ToInt32(quantitu.Value),
                SupplierId = Convert.ToInt16(supplierBox.SelectedValue),
                Status = "Новая",
                Price = priceBox.Text
            });
        }
        public void GetPurchases(DataGridView purchasesGrid)
        {
            var purchases = _purchaseService.GetAllPurchases();
            purchasesGrid.AutoGenerateColumns = true;
            purchasesGrid.DataSource = purchases;
        }

        public void GetPurchasesSearch(DataGridView purchasesGrid, string searchTerm)
        {
            var purchases = _purchaseService.SearchPurchases(searchTerm);
            purchasesGrid.AutoGenerateColumns = true;
            purchasesGrid.DataSource = purchases;
        }

        public void DeletePurchase(int id)
        {
            _purchaseService.DeletePurchase(id);
        }

        public void AddPurchaseToInventory(int purchaseId)
        {
            var purchase = _purchaseService.GetPurchase(purchaseId);

            var existtingInventory = _inventoryService.GetInventoryByNameAndUnit(purchase.ItemName, purchase.Unit);

            _purchaseService.UpdateStatus(purchase.Id, "Отправлено на склад");

            if (existtingInventory != null)
            {
                _inventoryService.UpdateInventiryQuantity(existtingInventory.Id, existtingInventory.Quantity, purchase.Quantity);
            }
            else
            {
                _inventoryService.CreateInventiry(purchase.ItemName, "Закупка", purchase.Quantity, purchase.Unit, "Склад", "Новая");
            }
        }

        public void GetUpdatedPurchase(int id, TextBox nameBox, NumericUpDown quantitu, TextBox unit, ComboBox supplierBox, TextBox priceBox)
        {
            var purchase = _purchaseService.GetPurchase(id);

            nameBox.Text = purchase.ItemName;
            quantitu.Value = purchase.Quantity;
            unit.Text = purchase.Unit;
            supplierBox.SelectedValue = purchase.SupplierId;
            priceBox.Text = purchase.Price;
        }

        public void UpdatePurchase(int id, TextBox nameBox, NumericUpDown quantitu, TextBox unit, ComboBox supplierBox, TextBox priceBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(unit.Text) || string.IsNullOrEmpty(supplierBox.Text) || string.IsNullOrEmpty(priceBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _purchaseService.UpdatePurchase(new PurchaseDto { ItemName = nameBox.Text, Quantity = Convert.ToInt32(quantitu.Value), Unit = unit.Text, SupplierId = Convert.ToInt32(supplierBox.SelectedValue), Id = id, Price = priceBox.Text });
        }

        public void UpdateStatus(int id, ToolStripComboBox statusBox)
        {
            if (string.IsNullOrEmpty(statusBox.Text))
            {
                MessageBox.Show("Выберите статус");
                return;
            }

            _purchaseService.UpdateStatus(id, statusBox.Text);
        }

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить закупки как DOCX";
                saveFileDialog.FileName = $"Закупки_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<PurchaseDto>;
                    if (dataSource != null)
                    {

                        _documents.SaveToDocx(
                            saveFileDialog.FileName,
                            DocumentTemplateType.GeneralInventory,
                            "Список Закупок",
                            dataSource);
                    }
                }
            }
        }
    }
}
