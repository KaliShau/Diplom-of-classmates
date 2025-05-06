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
        public RequestsController(InventoryService inventoryService, Context context, RequestService requestService)
        {
            _inventoryService = inventoryService;
            _requestService = requestService;
            _context = context;
        }

        public void AddInventoryToComboBox(ComboBox inventoruBox)
        {
            inventoruBox.DataSource = _inventoryService.GetInventories();
            inventoruBox.DisplayMember = "name";
            inventoruBox.ValueMember = "id";
        }

        public void CreateRequests(int inventoryId, string problem)
        {
            _requestService.CreateRequest(inventoryId, _context.User.Id, problem);
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
    }
}
