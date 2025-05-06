using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Services.Request
{
    public class RequestDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ID инвентаря")]
        public int InventoryId { get; set; }

        [DisplayName("Инвентарь")]
        public string InventoryName { get; set; }

        [DisplayName("ID пользователя")]
        public int UserId { get; set; }

        [DisplayName("Пользователь")]
        public string UserName { get; set; }

        [DisplayName("Дата")]
        public DateTime Date { get; set; }

        [DisplayName("Проблема")]
        public string Problem { get; set; }

        [DisplayName("Статус")]
        public string Status { get; set; }
    }
}
