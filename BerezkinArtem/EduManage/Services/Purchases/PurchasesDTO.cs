using System;
using System.ComponentModel;

namespace EduManage.Services.Purchases
{
    public class PurchaseDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ID поставщика")]
        public int SupplierId { get; set; }

        [DisplayName("Имя поставщика")]
        public string SupplierName { get; set; }

        [DisplayName("Предмет закупкм")]
        public string ItemName { get; set; }

        [DisplayName("Количество")]
        public int Quantity { get; set; }

        [DisplayName("Единица измерения")]
        public string Unit { get; set; }

        [DisplayName("Цена за единицу")]
        public string Price { get; set; }

        [DisplayName("Статус")]
        public string Status { get; set; }

        [DisplayName("Дата закупки")]
        public DateTime Date { get; set; }
    }
}
