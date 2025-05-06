using EduManage.Modules.Home;
using EduManage.Shared.Main;

namespace EduManage
{
    public partial class HomeForm : Form
    {
        HomeController _controller;
        public HomeForm(HomeController controller)
        {
            InitializeComponent();
            _controller = controller;   
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            _controller.OpenSignIn(childrenPanel);
        }
    }
}
