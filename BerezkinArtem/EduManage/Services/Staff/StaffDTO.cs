using System.ComponentModel;

namespace EduManage.Services.Staff
{
    public class StaffDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ID пользователя")]
        public int? UserId { get; set; }

        [DisplayName("Полное имя")]
        public string FullName { get; set; }

        [DisplayName("Должность")]
        public string Position { get; set; }

        [DisplayName("Отдел")]
        public string Department { get; set; }

        [DisplayName("Телефон")]
        public string Phone { get; set; }

        [DisplayName("Дата приема")]
        public DateTime HireDate { get; set; }

        [DisplayName("Активный")]
        public bool IsActive { get; set; }
    }
}
