using System.Windows.Forms;
using EduManage.Modules.Buses;
using EduManage.Modules.Inventory;
using EduManage.Modules.Purchases;
using EduManage.Modules.Requests;
using EduManage.Modules.Roles;
using EduManage.Modules.SignIn;
using EduManage.Modules.Staff;
using EduManage.Modules.Suppliers;
using EduManage.Modules.Users;
using EduManage.Shared;
using EduManage.Shared.Main;

namespace EduManage.Modules.Home
{
    public class HomeController
    {
        FormManager _formManger;
        Context _context;
        public HomeController(FormManager formManager, Context context)
        {
            _formManger = formManager;
            _context = context;
        }

        public void OpenSignIn(Panel childrenPanel)
        {
            _context.childrenPanel = childrenPanel;
            _formManger.OpenChidrenForm<SignInForm>(childrenPanel);
        }

        public void OpenInventory(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<InventoryForm>(childrenPanel);
        }
        public void OpenBuses(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<BusesForm>(childrenPanel);
        }

        public void OpenSuppliers(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<SuppliersForm>(childrenPanel);
        }

        public void OpenRequests(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<RequestsForm>(childrenPanel);
        }
        public void OpenUsers(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<UsersForm>(childrenPanel);
        }
        public void OpenRoles(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<RolesForm>(childrenPanel);
        }

        public void OpenPurchases(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<PurchasesForm>(childrenPanel);
        }

        public void OpenStaff(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<StaffForm>(childrenPanel);
        }

        public void CheckRole(GroupBox authBox, GroupBox staffBox, GroupBox accountantBox, GroupBox adminBox)
        {
            string role = _context.User?.Role.Name;

            if (role == "Admin")
            {
                authBox.Visible = false;
                adminBox.Visible = true;
                staffBox.Visible = true;
                accountantBox.Visible = true;
            }
            if (role == "Accountant")
            {
                authBox.Visible = false;
                adminBox.Visible = false;
                staffBox.Visible = true;
                accountantBox.Visible = true;
            }

        }
    }
}
