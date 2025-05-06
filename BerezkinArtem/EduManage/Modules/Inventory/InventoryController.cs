using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Services.Inventory;

namespace EduManage.Modules.Inventory
{
    public class InventoryController
    {
        InventoryService _inventoryService;
        public InventoryController(InventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public void GetInventory(DataGridView inventoryGrid)
        {
            var inventories = _inventoryService.GetInventories();
            inventoryGrid.AutoGenerateColumns = true; 
            inventoryGrid.DataSource = inventories;
        }
    }
}
