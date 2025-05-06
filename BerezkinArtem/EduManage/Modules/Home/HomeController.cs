using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Modules.Inventory;
using EduManage.Modules.Requests;
using EduManage.Modules.SignIn;
using EduManage.Modules.Suppliers;
using EduManage.Services.User;
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

        public void OpenSuppliers(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<SuppliersForm>(childrenPanel);
        }

        public void OpenRequests(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<RequestsForm>(childrenPanel);
        }

        public void CheckRole(GroupBox authBox, GroupBox staffBox, GroupBox accountantBox)
        {
            string role = _context.User?.Role.Name;

            if (role == "Admin")
            {
                authBox.Visible = false;
                staffBox.Visible = true;
                accountantBox.Visible = true;
            } 
            if (role == "Accountant")
            {
                authBox.Visible = false;
                staffBox.Visible = true;
                accountantBox.Visible = true;
            }
            if (role == "Staff")
            {
                authBox.Visible = false;
                staffBox.Visible = true;
                accountantBox.Visible = false;
            }

        }
    }
}
