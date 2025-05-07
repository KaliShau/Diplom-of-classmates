using EduManage.Services.Inventory;
using EduManage.Services.Purchases;
using EduManage.Services.Suppliers;

namespace EduManage.Modules.Purchases
{
    public class PurchasesController
    {
        PurchaseService _purchaseService;
        SuppliersService _suppliersService;
        public PurchasesController(PurchaseService purchaseService, SuppliersService suppliersService)
        {
            _purchaseService = purchaseService;
            _suppliersService = suppliersService;
        }

        public void AddSuppliersToComboBox(ComboBox supplierBox)
        {
            supplierBox.DataSource = _suppliersService.GetAllSuppliers();
            supplierBox.DisplayMember = "name";
            supplierBox.ValueMember = "id";
        }

        public void CreatePurchases(TextBox nameBox, TextBox amountBox, ComboBox supplierBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(amountBox.Text) || string.IsNullOrEmpty(supplierBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _purchaseService.CreatePurchase(new PurchaseDto
            {
                ItemName = nameBox.Text,
                Amount = amountBox.Text,
                SupplierId = Convert.ToInt16(supplierBox.SelectedValue)
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

    }
}
