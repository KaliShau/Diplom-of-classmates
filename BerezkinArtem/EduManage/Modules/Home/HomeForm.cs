using System;
using System.Windows.Forms;
using EduManage.Modules.Home;

namespace EduManage
{
    public partial class HomeForm : Form
    {
        HomeController _controller;

        public HomeForm(HomeController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.CheckRole(authBox, staffBox, accountantBox, adminBox);
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            _controller.OpenSignIn(childrenPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.OpenInventory(childrenPanel);
        }

        public void UpdateUIAfterLogin()
        {
            _controller.CheckRole(authBox, staffBox, accountantBox, adminBox);
        }

        private void openRequestsButton_Click(object sender, EventArgs e)
        {
            _controller.OpenRequests(childrenPanel);
        }

        private void openSuppliersButton_Click(object sender, EventArgs e)
        {
            _controller.OpenSuppliers(childrenPanel);
        }

        private void openPurchasesButton_Click(object sender, EventArgs e)
        {
            _controller.OpenPurchases(childrenPanel);
        }

        private void openStaffButton_Click(object sender, EventArgs e)
        {
            _controller.OpenStaff(childrenPanel);
        }

        private void openRolesButton_Click(object sender, EventArgs e)
        {
            _controller.OpenRoles(childrenPanel);
        }

        private void openUsersButton_Click(object sender, EventArgs e)
        {
            _controller.OpenUsers(childrenPanel);
        }

        private void openBusesButton_Click(object sender, EventArgs e)
        {
            _controller.OpenBuses(childrenPanel);
        }
    }
}
