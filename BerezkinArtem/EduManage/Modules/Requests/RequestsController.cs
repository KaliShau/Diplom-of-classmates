using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Services.Inventory;
using EduManage.Services.Request;
using EduManage.Shared;

namespace EduManage.Modules.Requests
{
    public class RequestsController
    {
        InventoryService _inventoryService;
        RequestService _requestService;
        Context _context;
        Documents _documents;
        public RequestsController(InventoryService inventoryService, Context context, RequestService requestService)
        {
            _inventoryService = inventoryService;
            _requestService = requestService;
            _context = context;
            _documents = new Documents();
        }

        public void AddInventoryToComboBox(ComboBox inventoruBox)
        {
            inventoruBox.DataSource = _inventoryService.GetInventories();
            inventoruBox.DisplayMember = "name";
            inventoruBox.ValueMember = "id";
        }

        public void CreateRequests(TextBox problemBox, ComboBox inventoryBox)
        {
            if (string.IsNullOrEmpty(problemBox.Text) || string.IsNullOrEmpty(inventoryBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;

            }

            _requestService.CreateRequest(Convert.ToInt32(inventoryBox.SelectedValue), _context.User.Id, problemBox.Text);
        }

        public void GetRequests(DataGridView requestsGrid)
        {
            var inventories = _requestService.GetAllRequests();
            requestsGrid.AutoGenerateColumns = true;
            requestsGrid.DataSource = inventories;
        }

        public void GetRequestsSearch(DataGridView requestsGrid, string searchTerm)
        {
            var inventories = _requestService.GetAllWithSearch(searchTerm);
            requestsGrid.AutoGenerateColumns = true;
            requestsGrid.DataSource = inventories;
        }

        public void DeleteRequest(int id)
        {
            var request = _requestService.GetById(id);

            if (request.UserId != _context.User.Id)
            {
                MessageBox.Show("Это не ваша заявка! Вы не можете удалить чужую заявку!");
                return;
            }

            _requestService.DeleteRequest(id);
        }

        public void UpdateStatus(int id, string status)
        {
            _requestService.UpdateRequestStatus(id, status);
        }

        public void AddUpdateStatusToMenuStrip(ContextMenuStrip menu, int id, DataGridView requestsGrid)
        {
            menu.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem statusMenu = new ToolStripMenuItem("Статус");
            menu.Items.Add(statusMenu);

            ToolStripComboBox statusCombo = new ToolStripComboBox("Type Here");
            statusCombo.Items.AddRange(new string[] { "Новая", "В работе", "Выполнена", "Отклонена" });
            statusCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            statusMenu.DropDownItems.Add(statusCombo);

            ToolStripMenuItem changeStatusItem = new ToolStripMenuItem("Сменить");
            changeStatusItem.Click += (sender, e) =>
            {
                if (statusCombo.SelectedItem != null)
                {
                    string selectedStatus = statusCombo.SelectedItem.ToString();
                    this.UpdateStatus(id, selectedStatus);
                    this.GetRequests(requestsGrid);
                }
            };
            statusMenu.DropDownItems.Add(changeStatusItem);

        }

        public void GetUpdatedRequest(int id, TextBox problemBox, ComboBox inventoryBox)
        {
            var request = _requestService.GetById(id);

            problemBox.Text = request.Problem;
            inventoryBox.SelectedValue = request.InventoryId;
        }

        public void UpdateRequest(int id, TextBox problemBox, ComboBox inventoryBox)
        {
            if (string.IsNullOrEmpty(problemBox.Text) || string.IsNullOrEmpty(inventoryBox.Text))
            {
                MessageBox.Show("Заполните поля!");
            }

            _requestService.UpdateRequest(id, problemBox.Text, Convert.ToInt32(inventoryBox.SelectedValue));
        }

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить заявки как DOCX";
                saveFileDialog.FileName = $"Заявки_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<RequestDto>;
                    if (dataSource != null)
                    {
                        _documents.SaveToDocx(
                            saveFileDialog.FileName,
                            DocumentTemplateType.GeneralInventory,
                            "Список заявок",
                            dataSource);
                    }
                }
            }
        }
    }
}
