using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduManage.Modules.SignIn
{
    public partial class SignInForm : Form
    {
        SignInController _controller;
        public SignInForm(SignInController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            _controller.SignIn(loginBox, passwordBox);
        }
    }
}
