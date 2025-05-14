using System;
using System.ComponentModel;

namespace EduManage.Services.WorkSchedule
{
    public class WorkScheduleDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Зона ответственности")]
        public string Zone { get; set; }

        [DisplayName("Тип работы")]
        public string Type { get; set; }

        [DisplayName("ID сотрудника")]
        public int StaffId { get; set; }

        [DisplayName("Сотрудник")]
        public string StaffName { get; set; }

        [DisplayName("День работы")]
        public DateTime Day { get; set; }

        [DisplayName("Время начала")]
        public TimeSpan StartTime { get; set; }

        [DisplayName("Время окончания")]
        public TimeSpan EndTime { get; set; }
    }
}