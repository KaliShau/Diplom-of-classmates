using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduManage.Modules.SignIn;
using EduManage.Shared.Main;

namespace EduManage.Modules.Home
{
    public class HomeController
    {
        FormManager _formManger;
        public HomeController(FormManager formManager)
        {
            _formManger = formManager;
        }

        public void OpenSignIn(Panel childrenPanel)
        {
            _formManger.OpenChidrenForm<SignInForm>(childrenPanel);
        }
    }
}
