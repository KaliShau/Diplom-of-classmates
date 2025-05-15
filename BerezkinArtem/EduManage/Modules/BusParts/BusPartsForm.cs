using System;
using System.Windows.Forms;

namespace EduManage.Modules.BusParts
{
    enum Action { Update, Create }

    public partial class BusPartsForm : Form
    {
        BusPartsController _controller;
        string _selectedId;
        Action _typeAction;
        public BusPartsForm(BusPartsController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.GetBusParts(busPartsGrid);
            _controller.GetPartTypes(partTypeBox);
            _controller.initBusData(busModelBox, busNumberBox);

        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
            quantityUpDown.Value = 1;
            unitBox.Clear();
            defectBox.Clear();

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

        private void defeCtcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (defeCtcheckBox.Checked == true)
            {
                defectLabel.Visible = true;
                defectBox.Visible = true;
                dateDefectLabel.Visible = true;
                defectTimePicker.Visible = true;
            }
            else
            {
                defectLabel.Visible = false;
                defectBox.Visible = false;
                dateDefectLabel.Visible = false;
                defectTimePicker.Visible = false;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (_typeAction == Action.Create)
            {
                _controller.CreateBusPart(partTypeBox, serialBox, statusBox, quantityUpDown, unitBox, installationDatePicker, defectTimePicker, defectBox, defeCtcheckBox);
                _controller.GetBusParts(busPartsGrid);
            }
            if (_typeAction == Action.Update)
            {
                _controller.UpdateBusPart(Convert.ToInt32(_selectedId), partTypeBox, serialBox, statusBox, quantityUpDown, unitBox, installationDatePicker, defectTimePicker, defectBox, defeCtcheckBox);
                _controller.GetBusParts(busPartsGrid);
            }

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
            quantityUpDown.Value = 1;
            unitBox.Clear();
            defectBox.Clear();

            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _controller.GetUpdatedPartType(Convert.ToInt32(_selectedId), partTypeBox, serialBox, statusBox, quantityUpDown, unitBox, installationDatePicker, defectTimePicker, defectBox, defeCtcheckBox);
                _typeAction = Action.Update;
                createPanel.Visible = true;
                createButton.Text = "Обновить";
            }
        }

        private void busPartsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = busPartsGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    busPartsGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = busPartsGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(busPartsGrid, e.Location);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteBusPart(Convert.ToInt32(_selectedId));
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                _controller.GetBusParts(busPartsGrid);
            }
            else
            {
                _controller.GetBusPartsSearch(busPartsGrid, searchTerm);
            }
        }

        private void openBusButton_Click(object sender, EventArgs e)
        {
            _controller.OpenBus();
        }

        private void saveToDocxButton_Click(object sender, EventArgs e)
        {
            _controller.ExportToDocx(busPartsGrid, Convert.ToInt32(_selectedId));
        }

        private void createDefectButton_Click(object sender, EventArgs e)
        {
            _controller.createDefectStatement(busPartsGrid);
        }
    }
}
