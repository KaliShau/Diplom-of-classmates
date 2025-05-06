using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Shared.Main;

namespace EduManage.Services.Inventory
{
    public class InventoryService
    {
        DatabaseRepository _repository;
        InventorySQL _sql;
        public InventoryService(DatabaseRepository databaseRepository)
        {
            _repository = databaseRepository;
            _sql = new InventorySQL();
        }   

        public InventoryDto[] GetInventories()
        {
            return _repository.Query<InventoryDto>(_sql.GetInventoies, reader => new InventoryDto
            {
                Id = Convert.ToInt32(reader["id"]),
                Name = reader["name"].ToString(),
                Category = reader["category"].ToString(),
                Quantity = Convert.ToString(reader["quantity"]),
                Room = reader["room"]?.ToString(), 
                Status = reader["status"]?.ToString()
            }).ToArray();
        }
    }
}
