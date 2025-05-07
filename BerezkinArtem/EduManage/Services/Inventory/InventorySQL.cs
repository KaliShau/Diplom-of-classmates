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
        SELECT id, name, category, quantity, unit, room, status 
        FROM inventory;
        ";

        public string CreateInventory = @"
        INSERT INTO inventory (name, category, quantity, unit, room, status)
        VALUES (@name, @category, @quantity, @unit, @room, @status);
        ";

        public string Search = @"
        SELECT id, name, category, quantity, unit, room, status
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
            unit = @unit,
            room = @room,
            status = @status
        WHERE id = @id
        ";
        public string UpdateInventoryQuantity = "UPDATE inventory SET quantity = @quantity WHERE id = @id";

        public string GetById = @"
        SELECT id, name, category, quantity, unit, room, status 
        FROM inventory 
        WHERE id = @id;
        ";

        public string GetByNameAndUnit = @"
        SELECT *
        FROM inventory 
        WHERE name = @name AND unit = @unit;
        ";

        public string UpdateStatus = @"
        UPDATE inventory
        SET status = @status
        WHERE id = @id;
        ";
    }
}
