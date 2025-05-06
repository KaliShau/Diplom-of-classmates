using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Services.Inventory
{
    public class InventorySQL
    {
        public string GetInventoies = @"
        SELECT id, name, category, quantity, room, status 
        FROM inventory;
        ";
    }
}
