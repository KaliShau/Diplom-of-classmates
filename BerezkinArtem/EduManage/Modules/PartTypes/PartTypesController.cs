using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Modules.Buses;
using EduManage.Services.Parts;
using EduManage.Services.PartTypes;
using EduManage.Shared;
using EduManage.Shared.Main;

namespace EduManage.Modules.PartTypes
{
    public class PartTypesController
    {
        PartTypeService _partTypesService;
        Context _context;
        Documents _documents;
        FormManager _formManager;
        public PartTypesController(PartTypeService busService, Context context, FormManager formManager)
        {
            _partTypesService = busService;
            _context = context;
            _documents = new Documents();
            _formManager = formManager;
        }

        public void OpenBus()
        {
            _formManager.OpenChidrenForm<BusesForm>(_context.childrenPanel);
        }

        public void GetPartTypes(DataGridView partTypesGrid)
        {
            var buses = _partTypesService.GetAllPartTypes();
            partTypesGrid.AutoGenerateColumns = true;
            partTypesGrid.DataSource = buses;
        }

        public void GetPartTypesSearch(DataGridView partTypesGrid, string searchTerm)
        {
            var buses = _partTypesService.SearchPartTypes(searchTerm);
            partTypesGrid.AutoGenerateColumns = true;
            partTypesGrid.DataSource = buses;
        }

        public void CreatePartTypes(TextBox nameBox, TextBox numberBox, TextBox descriptionBox, TextBox modelBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(numberBox.Text) || string.IsNullOrEmpty(descriptionBox.Text) || string.IsNullOrEmpty(modelBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _partTypesService.CreatePartType(nameBox.Text, numberBox.Text, descriptionBox.Text, modelBox.Text);
        }
        public void DeletePartType(int id)
        {
            _partTypesService.DeletePartType(id);
        }

        public void UpdatePartType(int id, TextBox nameBox, TextBox numberBox, TextBox descriptionBox, TextBox modelBox)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(numberBox.Text) || string.IsNullOrEmpty(descriptionBox.Text) || string.IsNullOrEmpty(modelBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _partTypesService.UpdatePartType(id, nameBox.Text, numberBox.Text, descriptionBox.Text, modelBox.Text);
        }

        public void GetUpdatedPartType(int id, TextBox nameBox, TextBox numberBox, TextBox descriptionBox, TextBox modelBox)
        {
            var partType = _partTypesService.GetPartTypeById(id);

            nameBox.Text = partType.Name;
            numberBox.Text = partType.PartNumber;
            descriptionBox.Text = partType.Description;
            modelBox.Text = partType.CompatibleBusModels;
        }

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить автобусы как DOCX";
                saveFileDialog.FileName = $"Типы_запчастей_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<PartTypeDto>;
                    if (dataSource != null)
                    {
                        _documents.SaveToDocx(
                            saveFileDialog.FileName,
                            DocumentTemplateType.GeneralInventory,
                            $"Список типов запчастей",
                            dataSource);
                    }
                }
            }
        }
    }
}
