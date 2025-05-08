using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace EduManage.Shared.Main
{
    public class FormManager
    {
        private readonly IServiceProvider _serviceProvider;
        private Form _currentForm;
        private Form _childrenForm;

        public FormManager(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }
        public void SetMainForm(HomeForm homeForm)
        {
            _currentForm = homeForm;

        }

        public void ClearChildrenPanel(Panel childrenPanel)
        {
            _childrenForm?.Close();

            _childrenForm.Dock = DockStyle.Fill;
            _childrenForm.TopLevel = false;
            _childrenForm.FormBorderStyle = FormBorderStyle.None;
            childrenPanel.Controls.Clear();
        }



        public void OpenChidrenForm<TForm>(Panel childrenPanel) where TForm : Form
        {
            _childrenForm?.Close();
            _childrenForm = _serviceProvider.GetRequiredService<TForm>();

            _childrenForm.Dock = DockStyle.Fill;
            _childrenForm.TopLevel = false;
            _childrenForm.FormBorderStyle = FormBorderStyle.None;
            childrenPanel.Controls.Clear();
            childrenPanel.Controls.Add(_childrenForm);
            _childrenForm.Show();
        }
    }
}
