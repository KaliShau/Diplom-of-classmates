using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduManage.Services.User;

namespace EduManage.Shared
{
    public class Context
    {
        public UserWithStaffDto User { get; set; }
        public Panel childrenPanel { get; set; }
    }
}
