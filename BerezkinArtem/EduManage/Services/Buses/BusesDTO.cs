using System;
using System.ComponentModel;

namespace EduManage.Services.Buses
{
    public class BusDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Модель")]
        public string Model { get; set; }

        [DisplayName("Гос. номер")]
        public string LicensePlate { get; set; }

        [DisplayName("Дата покупки")]
        public DateTime? PurchaseDate { get; set; }

        [DisplayName("Последний техосмотр")]
        public DateTime? LastTechInspection { get; set; }

        [DisplayName("Следующий техосмотр")]
        public DateTime? NextTechInspection { get; set; }

        [DisplayName("Статус")]
        public string Status { get; set; }

        [DisplayName("Примечания")]
        public string? Notes { get; set; }
    }
}