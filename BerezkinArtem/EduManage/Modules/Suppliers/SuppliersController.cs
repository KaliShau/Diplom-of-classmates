using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Services.Request;
using EduManage.Services.Suppliers;

namespace EduManage.Modules.Suppliers
{
    public class SuppliersController
    {
        SuppliersService _suppliersService;
        public SuppliersController(SuppliersService suppliersService)
        {
            _suppliersService = suppliersService;
        }

        public void CreateSupplier(string name, string contact, string phone)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _suppliersService.CreateSupplier(new SupplierDto
            {
                Name = name,
                Contact = contact,
                Phone = phone
            });
        }

        public void GetSuppliers(DataGridView suppliersGrid)
        {
            var suppliers = _suppliersService.GetAllSuppliers();
            suppliersGrid.AutoGenerateColumns = true;
            suppliersGrid.DataSource = suppliers;
        }

        public void GetSuppliersSearch(DataGridView suppliersGrid, string searchTerm)
        {
            var suppliers = _suppliersService.GetAllWithSearch(searchTerm);
            suppliersGrid.AutoGenerateColumns = true;
            suppliersGrid.DataSource = suppliers;
        }

        public void DeleteSuplier(int id)
        {
            _suppliersService.DeleteSupplier(id);
        }
    }
}
