using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void  DeleteRequest(int id)
        {
            var request = _requestService.GetById(id);

            if (request.UserId != _context.User.Id)
            {
                MessageBox.Show("Это не ваша заявка! Вы не можете удалить чужую заявку!");
                return;
            }

            _requestService.DeleteRequest(id);
        }
    }
}
