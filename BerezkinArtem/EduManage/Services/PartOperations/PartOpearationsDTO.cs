using System;
using System.ComponentModel;

namespace EduManage.Services.PartOperations
{
    public class PartOperationDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ID запчасти")]
        public int? PartId { get; set; }

        [DisplayName("Тип операции")]
        public string OperationType { get; set; }

        [DisplayName("ID автобуса")]
        public int? BusId { get; set; }

        [DisplayName("ID типа запчасти")]
        public int? PartTypeId { get; set; }

        [DisplayName("Количество")]
        public int? Quantity { get; set; }

        [DisplayName("Единица измерения")]
        public string Unit { get; set; }

        [DisplayName("Цена")]
        public string Price { get; set; }

        [DisplayName("Дата операции")]
        public DateTime OperationDate { get; set; }

        [DisplayName("Выполнил")]
        public int? PerformedBy { get; set; }

        [DisplayName("Поставщик")]
        public int? SupplierId { get; set; }

        [DisplayName("Примечания")]
        public string Notes { get; set; }

        // Дополнительные поля для отображения
        [DisplayName("Запчасть")]
        public string PartInfo { get; set; }

        [DisplayName("Автобус")]
        public string BusInfo { get; set; }

        [DisplayName("Тип запчасти")]
        public string PartTypeInfo { get; set; }

        [DisplayName("Сотрудник")]
        public string StaffInfo { get; set; }

        [DisplayName("Поставщик")]
        public string SupplierInfo { get; set; }
    }
}