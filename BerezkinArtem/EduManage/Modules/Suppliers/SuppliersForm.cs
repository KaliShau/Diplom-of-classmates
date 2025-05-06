using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduManage.Modules.Suppliers
{
    public partial class SuppliersForm : Form
    {
        SuppliersController _controller;
        public SuppliersForm(SuppliersController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetSuppliers(suppliersGrid);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            _controller.CreateSupplier(nameBox.Text, contactBox.Text, phoneBox.Text);
            _controller.GetSuppliers(suppliersGrid);
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            contactBox.Clear();
            phoneBox.Clear();

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                createPanel.Visible = true;
                createButton.Text = "Добавить";
            }
        }
    }
}
