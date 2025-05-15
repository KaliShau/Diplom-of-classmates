using System;
using System.Windows.Forms;

namespace EduManage.Modules.Buses
{
    enum Action { Update, Create }
    public partial class BusesForm : Form
    {
        BusesController _controller;
        string _selectedId;
        Action _typeAction;

        public BusesForm(BusesController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetBuses(busesGrid);
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            modelBox.Clear();
            licensePlateBox.Clear();
            notesBox.Clear();

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

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (_typeAction == Action.Create)
            {
                _controller.CreateBus(modelBox, licensePlateBox, purchaseDatePicker, lastTechPicker, nextTechPicker, statusBox, notesBox);
                _controller.GetBuses(busesGrid);
            }
            if (_typeAction == Action.Update)
            {
                _controller.UpdateBus(Convert.ToInt32(_selectedId), modelBox, licensePlateBox, purchaseDatePicker, lastTechPicker, nextTechPicker, statusBox, notesBox);
                _controller.GetBuses(busesGrid);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteBus(Convert.ToInt32(_selectedId));
            _controller.GetBuses(busesGrid);
        }

        private void busesGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = busesGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    busesGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = busesGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(busesGrid, e.Location);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                _controller.GetBuses(busesGrid);
            }
            else
            {
                _controller.GetBusesSearch(busesGrid, searchTerm);
            }
        }

        private void saveToDocxButton_Click(object sender, EventArgs e)
        {
            _controller.ExportToDocx(busesGrid);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelBox.Clear();
            licensePlateBox.Clear();
            notesBox.Clear();

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _controller.GetUpdatedBus(Convert.ToInt16(_selectedId), modelBox, licensePlateBox, purchaseDatePicker, lastTechPicker, nextTechPicker, statusBox, notesBox);
                _typeAction = Action.Update;
                createPanel.Visible = true;
                createButton.Text = "Обновить";
            }
        }

        private void openPartTypesButton_Click(object sender, EventArgs e)
        {
            _controller.OpenPartTypes();
        }

        private void openBusPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.OpenBusParts(Convert.ToInt32(_selectedId));
        }
    }
}
