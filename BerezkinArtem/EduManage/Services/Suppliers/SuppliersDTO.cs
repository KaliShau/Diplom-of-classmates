using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Services.Suppliers
{
    public class SupplierDto
    {
        [DisplayName("ID")]
        public int? Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Контактное лицо")]
        public string Contact { get; set; }

        [DisplayName("Телефон")]
        public string Phone { get; set; }
    }
}
