using EduManage.Services.Inventory;
using EduManage.Services.Purchases;
using EduManage.Services.Suppliers;
using Npgsql;

namespace EduManage.Modules.Purchases
{
    public class PurchasesController
    {
        PurchaseService _purchaseService;
        SuppliersService _suppliersService;
        InventoryService _inventoryService;
        public PurchasesController(PurchaseService purchaseService, SuppliersService suppliersService, InventoryService inventoryService)
        {
            _purchaseService = purchaseService;
            _suppliersService = suppliersService;
            _inventoryService = inventoryService;
        }

        public void AddSuppliersToComboBox(ComboBox supplierBox)
        {
            supplierBox.DataSource = _suppliersService.GetAllSuppliers();
            supplierBox.DisplayMember = "name";
            supplierBox.ValueMember = "id";
        }

        public void CreatePurchases(TextBox nameBox, NumericUpDown quantitu, TextBox unit, ComboBox supplierBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(unit.Text) || string.IsNullOrEmpty(supplierBox.Text))
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
                Status  = "Новая"
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
                _inventoryService.CreateInventiry(purchase.ItemName, "Закупка", purchase.Quantity, purchase.Unit,"Склад", "На складе");
            }
        }

    }
}
