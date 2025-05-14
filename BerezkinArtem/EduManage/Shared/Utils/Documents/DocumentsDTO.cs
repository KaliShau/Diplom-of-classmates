using System.ComponentModel;

namespace EduManage.Shared.Utils.Documents
{
    // Для дефектной ведомости
    public class BusDefectDto
    {
        [DisplayName("Наименование запасных частей")]
        public string PartName { get; set; }

        [DisplayName("Ед.изм.")]
        public string Unit { get; set; }

        [DisplayName("Количество")]
        public int Quantity { get; set; }

        [DisplayName("Причина")]
        public string Reason { get; set; }
    }

    // Для акта установки запчастей
    public class PartsInstallationDto
    {
        [DisplayName("Наименование запасных частей")]
        public string PartName { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [DisplayName("Примечание")]
        public string Note { get; set; }
    }

    // Для сметы расходов
    public class ExpenseDto
    {
        [DisplayName("Наименование расходов")]
        public string ExpenseName { get; set; }

        [DisplayName("Количество")]
        public int Quantity { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [DisplayName("Сумма")]
        public decimal Amount { get; set; }
    }
}
