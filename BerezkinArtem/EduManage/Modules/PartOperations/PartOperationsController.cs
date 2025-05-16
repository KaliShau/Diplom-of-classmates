using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EduManage.Modules.BusParts;
using EduManage.Services.Buses;
using EduManage.Services.BusParts;
using EduManage.Services.PartOperations;
using EduManage.Services.Parts;
using EduManage.Services.Staff;
using EduManage.Services.Suppliers;
using EduManage.Shared;
using EduManage.Shared.Main;

namespace EduManage.Modules.PartOperations
{
    public class PartOperationsController
    {
        FormManager _formManager;
        Context _context;
        PartOperationService _partOperationService;
        PartTypeService _partTypeService;
        SuppliersService _suppliersService;
        StaffService _staffService;
        BusPartService _busPartService;
        BusService _busService;
        Documents _documents;
        public PartOperationsController(FormManager formManager, Context context, PartOperationService partOperationService, PartTypeService partTypeService, SuppliersService suppliersService, StaffService staffService, BusPartService busPartService, BusService busService)
        {
            _formManager = formManager;
            _context = context;
            _partOperationService = partOperationService;
            _partTypeService = partTypeService;
            _suppliersService = suppliersService;
            _staffService = staffService;
            _busPartService = busPartService;
            _busService = busService;
            _documents = new Documents();
        }

        public void initComboBoxes(ComboBox supplersBox, ComboBox partTypesBox, ComboBox addStaffBox, ComboBox addTypePartBox, ComboBox delPartBox, ComboBox delStaffBox)
        {
            supplersBox.DataSource = _suppliersService.GetAllSuppliers();
            supplersBox.DisplayMember = "name";
            supplersBox.ValueMember = "id";

            partTypesBox.DataSource = _partTypeService.GetAllPartTypes();
            partTypesBox.DisplayMember = "name";
            partTypesBox.ValueMember = "id";

            addTypePartBox.DataSource = _partTypeService.GetAllPartTypes();
            addTypePartBox.DisplayMember = "name";
            addTypePartBox.ValueMember = "id";

            addStaffBox.DataSource = _staffService.GetAllStaff();
            addStaffBox.DisplayMember = "FullName";
            addStaffBox.ValueMember = "id";

            delStaffBox.DataSource = _staffService.GetAllStaff();
            delStaffBox.DisplayMember = "FullName";
            delStaffBox.ValueMember = "id";

            delPartBox.DataSource = _busPartService.GetBusPartsByBusId(_context.bus_id);
            delPartBox.DisplayMember = "SerialNumber";
            delPartBox.ValueMember = "id";
        }

        public void OpenBusParts()
        {
            _formManager.OpenChidrenForm<BusPartsForm>(_context.childrenPanel);
        }

        public void GetPartOperations(DataGridView grid, ComboBox operationBox)
        {
            var operations = _partOperationService.GetOperationsByBusId(_context.bus_id, operationBox.Text);

            grid.AutoGenerateColumns = false;
            grid.Columns.Clear();

            if (operationBox.Text == "Закупка")
            {
                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID операции"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "OperationType",
                    HeaderText = "Тип операции"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "OperationDate",
                    HeaderText = "Дата операции"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Quantity",
                    HeaderText = "Количество"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Unit",
                    HeaderText = "Единица измерения"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Price",
                    HeaderText = "Цена"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "SupplierInfo",
                    HeaderText = "Поставщик"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "PartTypeInfo",
                    HeaderText = "Тип запчасти"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "BusInfo",
                    HeaderText = "Автобус"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Notes",
                    HeaderText = "Примечания"
                });
            }
            if (operationBox.Text == "Установка")
            {
                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID операции"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "OperationType",
                    HeaderText = "Тип операции"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "OperationDate",
                    HeaderText = "Дата операции"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Quantity",
                    HeaderText = "Количество"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Unit",
                    HeaderText = "Единица измерения"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "PartTypeInfo",
                    HeaderText = "Тип запчасти"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "BusInfo",
                    HeaderText = "Автобус"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "StaffInfo",
                    HeaderText = "Сотрудник"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Notes",
                    HeaderText = "Примечания"
                });
            }

            if (operationBox.Text == "Списание")
            {
                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID операции"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "OperationType",
                    HeaderText = "Тип операции"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "OperationDate",
                    HeaderText = "Дата операции"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Quantity",
                    HeaderText = "Количество"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Unit",
                    HeaderText = "Единица измерения"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "PartInfo",
                    HeaderText = "Запчасть"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "BusInfo",
                    HeaderText = "Автобус"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "StaffInfo",
                    HeaderText = "Сотрудник"
                });

                grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Notes",
                    HeaderText = "Примечания"
                });
            }

            grid.DataSource = operations;
        }

        public void CreateBuyOperations(ComboBox operationBox, ComboBox partTypeBox, NumericUpDown quantityUpDown, TextBox unitBox, TextBox priceBox, ComboBox supplierBox, TextBox notesBox)
        {
            if (string.IsNullOrEmpty(partTypeBox.Text) || string.IsNullOrEmpty(quantityUpDown.Text) || string.IsNullOrEmpty(unitBox.Text) || string.IsNullOrEmpty(priceBox.Text) || string.IsNullOrEmpty(supplierBox.Text) || string.IsNullOrEmpty(notesBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _partOperationService.CreateOperation(null, operationBox.Text, _context.bus_id, Convert.ToInt32(partTypeBox.SelectedValue), Convert.ToInt32(quantityUpDown.Value), unitBox.Text, priceBox.Text, DateTime.Now.Date, _context.User.StaffId, Convert.ToInt32(supplierBox.SelectedValue), notesBox.Text);
        }

        public void CreateAddOperations(ComboBox operationBox, ComboBox partTypeBox, NumericUpDown quantityUpDown, TextBox unitBox, ComboBox staffBox, TextBox notesBox)
        {
            if (string.IsNullOrEmpty(partTypeBox.Text) || string.IsNullOrEmpty(quantityUpDown.Text) || string.IsNullOrEmpty(unitBox.Text) || string.IsNullOrEmpty(staffBox.Text) || string.IsNullOrEmpty(notesBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            string searial = this.GenerateSerialNumber(Convert.ToInt32(partTypeBox.SelectedValue), _context.bus_id);

            _partOperationService.CreateOperation(null, operationBox.Text, _context.bus_id, Convert.ToInt32(partTypeBox.SelectedValue), Convert.ToInt32(quantityUpDown.Value), unitBox.Text, null, DateTime.Now.Date, Convert.ToInt32(staffBox.SelectedValue), null, notesBox.Text);
            _busPartService.CreateBusPart(Convert.ToInt32(partTypeBox.SelectedValue), _context.bus_id, searial, "Новая", Convert.ToInt32(quantityUpDown.Value), unitBox.Text, DateTime.Now.Date, null, null);
        }

        public void CreateDelOperations(ComboBox operationBox, ComboBox partBox, NumericUpDown quantityUpDown, TextBox unitBox, ComboBox staffBox, TextBox notesBox)
        {
            if (string.IsNullOrEmpty(partBox.Text) || string.IsNullOrEmpty(quantityUpDown.Text) || string.IsNullOrEmpty(unitBox.Text) || string.IsNullOrEmpty(staffBox.Text) || string.IsNullOrEmpty(notesBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _partOperationService.CreateOperation(Convert.ToInt32(partBox.SelectedValue), operationBox.Text, _context.bus_id, null, Convert.ToInt32(quantityUpDown.Value), unitBox.Text, null, DateTime.Now.Date, Convert.ToInt32(staffBox.SelectedValue), null, notesBox.Text);
            _busPartService.UpdateBusPartStatus(Convert.ToInt32(partBox.SelectedValue), "Списан");
        }

        public void DeleteOperation(int id)
        {
            _partOperationService.DeleteOperation(id);
        }
        public string GenerateSerialNumber(int partTypeId, int busId)
        {
            DateTime now = DateTime.Now;
            return $"BP-{partTypeId}-{busId}-{now:yyyyMMdd}-{now:HHmmss}";
        }

        public void CreatePartsInstallationAct()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                var bus = _busService.GetById(_context.bus_id);
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить акт установки запасных частей";
                saveFileDialog.FileName = $"Акт установки запасных частей_{bus.LicensePlate}_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var operations = _partOperationService.GetOperationsByBusId(_context.bus_id, "Установка");

                    if (!operations.Any())
                    {
                        MessageBox.Show("Нет запчастей со статусом 'Установка' для формирования акта",
                                      "Информация",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        return;
                    }

                    var additionalFields = new Dictionary<string, string>
            {
                { "BusModel", bus.Model },
                { "LicensePlate", bus.LicensePlate }
            };

                    _documents.SaveToDocx(
                        saveFileDialog.FileName,
                        DocumentTemplateType.PartsInstallationAct,
                        "АКТ УСТАНОВКИ ЗАПАСНЫХ ЧАСТЕЙ",
                        operations.Select(op => new
                        {
                            Наименование = op.PartTypeInfo,
                            Примечание = op.Notes ?? "______"
                        }),
                        additionalFields);
                }
            }
        }
    }

}
