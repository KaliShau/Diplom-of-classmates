using System.Windows.Forms;
using EduManage.Services.User;

namespace EduManage.Shared
{
    public class Context
    {
        public UserWithStaffDto User { get; set; }
        public Panel childrenPanel { get; set; }

        // users
        public int staff_id { get; set; }

        // buses
        public int bus_id { get; set; }
    }
}
