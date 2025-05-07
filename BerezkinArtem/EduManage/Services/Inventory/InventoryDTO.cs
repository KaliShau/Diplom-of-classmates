using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Services.Inventory
{
    public class InventoryDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Категория")]
        public string Category { get; set; }

        [DisplayName("Количество")]
        public int Quantity { get; set; }

        [DisplayName("Единица измерения")]
        public string Unit { get; set; }

        [DisplayName("Комната")]
        public string? Room { get; set; }

        [DisplayName("Статус")]
        public string? Status { get; set; }
    }
}
