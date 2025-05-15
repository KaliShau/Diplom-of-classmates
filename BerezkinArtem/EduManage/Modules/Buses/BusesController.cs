using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Modules.BusParts;
using EduManage.Modules.PartTypes;
using EduManage.Services.Buses;
using EduManage.Shared;
using EduManage.Shared.Main;

namespace EduManage.Modules.Buses
{
    public class BusesController
    {
        BusService _busService;
        Context _context;
        Documents _documents;
        FormManager _formManager;
        public BusesController(BusService busService, Context context, FormManager formManager)
        {
            _busService = busService;
            _context = context;
            _documents = new Documents();
            _formManager = formManager;
        }

        public void OpenPartTypes()
        {
            _formManager.OpenChidrenForm<PartTypesForm>(_context.childrenPanel);
        }
        public void OpenBusParts(int id)
        {
            _context.bus_id = id;
            _formManager.OpenChidrenForm<BusPartsForm>(_context.childrenPanel);
        }

        public void GetBuses(DataGridView busesGrid)
        {
            var buses = _busService.GetBuses();
            busesGrid.AutoGenerateColumns = true;
            busesGrid.DataSource = buses;
        }

        public void GetBusesSearch(DataGridView busesGrid, string searchTerm)
        {
            var buses = _busService.SearchBuses(searchTerm);
            busesGrid.AutoGenerateColumns = true;
            busesGrid.DataSource = buses;
        }

        public void CreateBus(TextBox modelBox, TextBox licensePlateBox, DateTimePicker purchasePicker, DateTimePicker lastTechPicker, DateTimePicker nextTechPicker, ComboBox statusBox, TextBox notesBox)
        {
            if (string.IsNullOrEmpty(modelBox.Text) || string.IsNullOrEmpty(licensePlateBox.Text) || string.IsNullOrEmpty(statusBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _busService.CreateBus(modelBox.Text, licensePlateBox.Text, purchasePicker.Value, lastTechPicker.Value, nextTechPicker.Value, statusBox.Text, notesBox.Text);
        }
        public void DeleteBus(int id)
        {
            _busService.DeleteBus(id);
        }

        public void UpdateBus(int id, TextBox modelBox, TextBox licensePlateBox, DateTimePicker purchasePicker, DateTimePicker lastTechPicker, DateTimePicker nextTechPicker, ComboBox statusBox, TextBox notesBox)
        {
            if (string.IsNullOrEmpty(modelBox.Text) || string.IsNullOrEmpty(licensePlateBox.Text) || string.IsNullOrEmpty(statusBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _busService.UpdateBus(id, modelBox.Text, licensePlateBox.Text, purchasePicker.Value, lastTechPicker.Value, nextTechPicker.Value, statusBox.Text, notesBox.Text);
        }

        public void GetUpdatedBus(int id, TextBox modelBox, TextBox licensePlateBox, DateTimePicker purchasePicker, DateTimePicker lastTechPicker, DateTimePicker nextTechPicker, ComboBox statusBox, TextBox notesBox)
        {
            var bus = _busService.GetById(id);

            modelBox.Text = bus.Model;
            licensePlateBox.Text = bus.LicensePlate;
            purchasePicker.Value = bus.PurchaseDate ?? DateTime.Now;
            lastTechPicker.Value = bus.LastTechInspection ?? DateTime.Now;
            nextTechPicker.Value = bus.NextTechInspection ?? DateTime.Now;
            statusBox.Text = bus.Status;
            notesBox.Text = bus.Notes;
        }

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить автобусы как DOCX";
                saveFileDialog.FileName = $"Автобусы_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<BusDto>;
                    if (dataSource != null)
                    {
                        _documents.SaveToDocx(
                            saveFileDialog.FileName,
                            DocumentTemplateType.GeneralInventory,
                            $"Список автобусов",
                            dataSource);
                    }
                }
            }
        }
    }
}
