using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Services.Role
{
    public class RoleDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Название роли")]
        public string Name { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }
    }

}
