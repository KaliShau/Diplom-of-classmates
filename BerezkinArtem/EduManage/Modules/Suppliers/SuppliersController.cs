using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Modules.Inventory;
using EduManage.Services.Inventory;
using EduManage.Services.Suppliers;

namespace EduManage.Modules.Suppliers
{
    public class SuppliersController
    {
        SuppliersService _suppliersService;
        DocumentGenerator _documentGenerator;
        public SuppliersController(SuppliersService suppliersService)
        {
            _suppliersService = suppliersService;
            _documentGenerator = new DocumentGenerator();
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

        public void DeleteSupplier(int id)
        {
            _suppliersService.DeleteSupplier(id);
        }

        public void GetUpdatedSupplier(int id, TextBox nameBox, TextBox contactBox, TextBox phoneBox)
        {
            var supplier = _suppliersService.GetById(id);

            nameBox.Text = supplier.Name;
            contactBox.Text = supplier.Contact;
            phoneBox.Text = supplier.Phone;
        }

        public void UpdateSupplier(int id, TextBox nameBox, TextBox contactBox, TextBox phoneBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(contactBox.Text) || string.IsNullOrEmpty(phoneBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _suppliersService.UpdateSupplier(new SupplierDto { Id = id, Contact = contactBox.Text, Name = nameBox.Text, Phone = phoneBox.Text });
        }

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить поставщиков как DOCX";
                saveFileDialog.FileName = $"Поставщики_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<InventoryDto>;
                    if (dataSource != null)
                    {
                        string description = "Данный документ содержит полный перечень поставщиков образовательного учреждения.";
                        _documentGenerator.SaveToDocx(
                            saveFileDialog.FileName,
                            "Список поставщиков",
                            description,
                            dataSource);
                    }
                }
            }
        }
    }
}
