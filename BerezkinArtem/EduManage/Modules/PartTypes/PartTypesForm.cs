using System;
using System.Windows.Forms;

namespace EduManage.Modules.PartTypes
{
    enum Action { Update, Create }

    public partial class PartTypesForm : Form
    {
        PartTypesController _controller;
        string _selectedId;
        Action _typeAction;

        public PartTypesForm(PartTypesController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetPartTypes(partTypesGrid);
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            _controller.OpenBus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void openCreateButton_Click_1(object sender, EventArgs e)
        {
            nameBox.Clear();
            numberBox.Clear();
            descriptionBox.Clear();
            modelBox.Clear();

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _typeAction = Action.Create;
                createPanel.Visible = true;
                createButton.Text = "Добавить";
            }
        }

        private void openBusButton_Click(object sender, EventArgs e)
        {
            _controller.OpenBus();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (_typeAction == Action.Create)
            {

                _controller.CreatePartTypes(nameBox, numberBox, descriptionBox, modelBox);
                _controller.GetPartTypes(partTypesGrid);
            }
            if (_typeAction == Action.Update)
            {
                _controller.UpdatePartType(Convert.ToInt32(_selectedId), nameBox, numberBox, descriptionBox, modelBox);
                _controller.GetPartTypes(partTypesGrid);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeletePartType(Convert.ToInt32(_selectedId));
            _controller.GetPartTypes(partTypesGrid);
        }

        private void partTypesGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = partTypesGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    partTypesGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = partTypesGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(partTypesGrid, e.Location);
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            numberBox.Clear();
            descriptionBox.Clear();
            modelBox.Clear();

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _controller.GetUpdatedPartType(Convert.ToInt32(_selectedId), nameBox, numberBox, descriptionBox, modelBox);
                _typeAction = Action.Update;
                createPanel.Visible = true;
                createButton.Text = "Обновить";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                _controller.GetPartTypes(partTypesGrid);
            }
            else
            {
                _controller.GetPartTypesSearch(partTypesGrid, searchTerm);
            }
        }

        private void saveToDocxButton_Click(object sender, EventArgs e)
        {
            _controller.ExportToDocx(partTypesGrid);
        }
    }
}
