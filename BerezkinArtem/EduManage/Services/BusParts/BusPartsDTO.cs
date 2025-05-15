using System;
using System.ComponentModel;

namespace EduManage.Services.BusParts
{
    public class BusPartDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Тип запчасти ID")]
        public int PartTypeId { get; set; }

        [DisplayName("Автобус ID")]
        public int BusId { get; set; }

        [DisplayName("Серийный номер")]
        public string SerialNumber { get; set; }

        [DisplayName("Статус")]
        public string Status { get; set; }

        [DisplayName("Количество")]
        public int? Quantity { get; set; }

        [DisplayName("Единица измерения")]
        public string Unit { get; set; }

        [DisplayName("Дата установки")]
        public DateTime? InstallationDate { get; set; }

        [DisplayName("Дата выхода из строя")]
        public DateTime? DefectDate { get; set; }

        [DisplayName("Описание неисправности")]
        public string? DefectDescription { get; set; }

        // Дополнительные поля для отображения (не из таблицы)
        [DisplayName("Тип запчасти")]
        public string PartTypeName { get; set; }

        [DisplayName("Автобус")]
        public string BusInfo { get; set; }
    }
}