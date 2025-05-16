using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EduManage.Modules.Buses;
using EduManage.Modules.PartOperations;
using EduManage.Services.Buses;
using EduManage.Services.BusParts;
using EduManage.Services.Parts;
using EduManage.Shared;
using EduManage.Shared.Main;

namespace EduManage.Modules.BusParts
{
    public class BusPartsController
    {
        BusPartService _busPartService;
        BusService _busService;
        PartTypeService _partTypeService;
        Context _context;
        Documents _documents;
        FormManager _formManager;
        public BusPartsController(BusPartService busPartService, Context context, FormManager formManager, PartTypeService partTypeService, BusService busService)
        {
            _busPartService = busPartService;
            _context = context;
            _documents = new Documents();
            _formManager = formManager;
            _partTypeService = partTypeService;
            _busService = busService;
        }

        public void initBusData(TextBox modelBox, TextBox serialBox)
        {
            var bus = _busService.GetById(_context.bus_id);

            modelBox.Text = bus.Model;
            serialBox.Text = bus.LicensePlate;
        }

        public void OpenOperation(string type)
        {
            _context.type_operation = type;
            _formManager.OpenChidrenForm<PartOperationsForm>(_context.childrenPanel);
        }

        public void GetPartTypes(ComboBox partTypeBox)
        {
            var partTypes = _partTypeService.GetAllPartTypes();
            partTypeBox.DataSource = partTypes;
            partTypeBox.DisplayMember = "name";
            partTypeBox.ValueMember = "id";
        }

        public void OpenBus()
        {
            _formManager.OpenChidrenForm<BusesForm>(_context.childrenPanel);
        }

        public void GetBusParts(DataGridView busPartGrid)
        {
            var busParts = _busPartService.GetBusPartsByBusId(_context.bus_id);
            busPartGrid.AutoGenerateColumns = true;
            busPartGrid.DataSource = busParts;
        }

        public void GetBusPartsSearch(DataGridView partTypesGrid, string searchTerm)
        {
            var buses = _busPartService.SearchBusParts(searchTerm);
            partTypesGrid.AutoGenerateColumns = true;
            partTypesGrid.DataSource = buses;
        }

        public void CreateBusPart(ComboBox partTypeBox, ComboBox statusBox, NumericUpDown quantityUpDown, TextBox unitBox, DateTimePicker installationDatePickerm, DateTimePicker defectDatePicker, TextBox defectBox, CheckBox defectCheckBox)
        {
            if (defectCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(partTypeBox.Text) || string.IsNullOrEmpty(statusBox.Text) || string.IsNullOrEmpty(quantityUpDown.Text) || string.IsNullOrEmpty(unitBox.Text) || string.IsNullOrEmpty(installationDatePickerm.Text) || string.IsNullOrEmpty(defectDatePicker.Text) || string.IsNullOrEmpty(defectBox.Text))
                {
                    MessageBox.Show("Заполните поля!");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(partTypeBox.Text) || string.IsNullOrEmpty(statusBox.Text) || string.IsNullOrEmpty(quantityUpDown.Text) || string.IsNullOrEmpty(unitBox.Text) || string.IsNullOrEmpty(installationDatePickerm.Text))
                {
                    MessageBox.Show("Заполните поля!");
                    return;
                }
            }

            string searial = this.GenerateSerialNumber(Convert.ToInt32(partTypeBox.SelectedValue), _context.bus_id);

            _busPartService.CreateBusPart(Convert.ToInt32(partTypeBox.SelectedValue), _context.bus_id, searial, statusBox.Text, Convert.ToInt32(quantityUpDown.Value), unitBox.Text, installationDatePickerm.Value, defectCheckBox.Checked ? defectDatePicker.Value : (DateTime?)null, defectCheckBox.Checked ? defectBox.Text : null);
        }
        public void DeleteBusPart(int id)
        {
            _busPartService.DeleteBusPart(id);
        }

        public void UpdateBusPart(int id, ComboBox partTypeBox, ComboBox statusBox, NumericUpDown quantityUpDown, TextBox unitBox, DateTimePicker installationDatePickerm, DateTimePicker defectDatePicker, TextBox defectBox, CheckBox defectCheckBox)
        {
            if (defectCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(partTypeBox.Text) || string.IsNullOrEmpty(statusBox.Text) || string.IsNullOrEmpty(quantityUpDown.Text) || string.IsNullOrEmpty(unitBox.Text) || string.IsNullOrEmpty(installationDatePickerm.Text) || string.IsNullOrEmpty(defectDatePicker.Text) || string.IsNullOrEmpty(defectBox.Text))
                {
                    MessageBox.Show("Заполните поля!");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(partTypeBox.Text) || string.IsNullOrEmpty(statusBox.Text) || string.IsNullOrEmpty(quantityUpDown.Text) || string.IsNullOrEmpty(unitBox.Text) || string.IsNullOrEmpty(installationDatePickerm.Text))
                {
                    MessageBox.Show("Заполните поля!");
                    return;
                }
            }


            _busPartService.UpdateBusPart(id, Convert.ToInt32(partTypeBox.SelectedValue), _context.bus_id, statusBox.Text, Convert.ToInt32(quantityUpDown.Value), unitBox.Text, installationDatePickerm.Value, defectCheckBox.Checked ? defectDatePicker.Value : (DateTime?)null, defectCheckBox.Checked ? defectBox.Text : null);
        }

        public void GetUpdatedPartType(int id, ComboBox partTypeBox, ComboBox statusBox, NumericUpDown quantityUpDown, TextBox unitBox, DateTimePicker installationDatePickerm, DateTimePicker defectDatePicker, TextBox defectBox, CheckBox defectCheckBox)
        {
            var busPart = _busPartService.GetBusPartById(id);

            partTypeBox.SelectedValue = busPart.PartTypeId;
            statusBox.Text = busPart.Status;
            quantityUpDown.Value = busPart.Quantity ?? 0;
            unitBox.Text = busPart.Unit;
            installationDatePickerm.Value = busPart.InstallationDate ?? DateTime.Now;

            if (busPart.DefectDate != null)
            {
                defectCheckBox.Checked = true;
            }
            else
            {
                defectCheckBox.Checked = false;
            }

            defectDatePicker.Value = busPart.DefectDate ?? DateTime.Now;
            defectBox.Text = busPart.DefectDescription;
        }

        public void ExportToDocx(DataGridView grid, int id)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                var bus = _busService.GetById(_context.bus_id);
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить автобусы как DOCX";
                saveFileDialog.FileName = $"Запчасти автобуса_{bus.LicensePlate}_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<BusPartDto>;
                    if (dataSource != null)
                    {
                        _documents.SaveToDocx(
                            saveFileDialog.FileName,
                            DocumentTemplateType.GeneralInventory,
                            $"Запчасти автобуса_{bus.LicensePlate}",
                            dataSource);
                    }
                }
            }
        }

        public void createDefectStatement(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                var bus = _busService.GetById(_context.bus_id);
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить дефектную ведомость";
                saveFileDialog.FileName = $"Дефектная ведомость_{bus.LicensePlate}_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<BusPartDto>;
                    if (dataSource != null)
                    {
                        var defectiveParts = dataSource.Where(p => p.Status == "Дефект");

                        if (!defectiveParts.Any())
                        {
                            MessageBox.Show("Нет запчастей со статусом 'Дефект' для формирования ведомости",
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
                            DocumentTemplateType.DefectReport,
                            "ДЕФЕКТНАЯ ВЕДОМОСТЬ",
                            defectiveParts.Select(p => new
                            {
                                Наименование = p.PartTypeName,
                                Единица = p.Unit,
                                Количество = p.Quantity?.ToString() ?? "1",
                                Причина = p.DefectDescription ?? "Не указана"
                            }),
                            additionalFields);
                    }
                }
            }
        }

        public string GenerateSerialNumber(int partTypeId, int busId)
        {
            DateTime now = DateTime.Now;
            return $"BP-{partTypeId}-{busId}-{now:yyyyMMdd}-{now:HHmmss}";
        }
    }
}
