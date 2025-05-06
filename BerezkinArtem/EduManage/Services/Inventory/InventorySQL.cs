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

        public string CreateInventory = @"
        INSERT INTO inventory (name, category, quantity, room, status)
        VALUES (@name, @category, @quantity, @room, @status);
        ";

        public string Search = @"
        SELECT id, name, category, quantity, room, status
        FROM inventory
        WHERE 
            (name ILIKE '%' || @searchTerm || '%' OR 
             category ILIKE '%' || @searchTerm || '%' OR
             room ILIKE '%' || @searchTerm || '%');
        ";

        public string Delete = @"
        DELETE FROM inventory 
        WHERE id = @id;
        ";

        public string Update = @"
        UPDATE inventory
        SET 
            name = @name,
            category = @category,
            quantity = @quantity,
            room = @room,
            status = @status
        WHERE id = @id
        ";

        public string GetById = @"
        SELECT id, name, category, quantity, room, status 
        FROM inventory 
        WHERE id = @id;
        ";
    }
}
