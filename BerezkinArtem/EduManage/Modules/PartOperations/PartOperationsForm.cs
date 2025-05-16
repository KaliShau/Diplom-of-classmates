using System;
using System.Windows.Forms;
using EduManage.Shared;

namespace EduManage.Modules.PartOperations
{
    public partial class PartOperationsForm : Form
    {
        Context _context;
        PartOperationsController _controller;
        string _selectedId;
        public PartOperationsForm(Context context, PartOperationsController controller)
        {
            InitializeComponent();

            _context = context;
            _controller = controller;

            operationBox.Text = _context.type_operation;

            _controller.GetPartOperations(operationGrid, operationBox);
            _controller.initComboBoxes(suppliersBox, partTypeBox, addStaffBox, addTypePartBox, delPartBox, delStaffBox);
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            if (operationBox.Text == "Закупка")
            {
                if (buyPanel.Visible == true)
                {
                    buyPanel.Visible = false;
                }
                else
                {
                    buyPanel.Visible = true;
                    createBuyButton.Text = "Добавить";
                }
            }

            if (operationBox.Text == "Установка")
            {
                if (addPanel.Visible == true)
                {
                    addPanel.Visible = false;
                }
                else
                {
                    addPanel.Visible = true;
                    createAddButton.Text = "Добавить";
                }
            }

            if (operationBox.Text == "Списание")
            {
                if (delPanel.Visible == true)
                {
                    delPanel.Visible = false;
                }
                else
                {
                    delPanel.Visible = true;
                    createDelButton.Text = "Добавить";
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            buyPanel.Visible = false;
        }

        private void openBusPartsButton_Click(object sender, EventArgs e)
        {
            _controller.OpenBusParts();
        }

        private void operationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.GetPartOperations(operationGrid, operationBox);

            buyPanel.Visible = false;
            addPanel.Visible = false;
            delPanel.Visible = false;
        }

        private void createBuyButton_Click(object sender, EventArgs e)
        {
            _controller.CreateBuyOperations(operationBox, partTypeBox, quantityUpDown, unitBox, priceBox, suppliersBox, notesBox);
            _controller.GetPartOperations(operationGrid, operationBox);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteOperation(Convert.ToInt32(_selectedId));
            _controller.GetPartOperations(operationGrid, operationBox);
        }

        private void operationGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = operationGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    operationGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = operationGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(operationGrid, e.Location);
                }
            }
        }

        private void createAddButton_Click(object sender, EventArgs e)
        {
            _controller.CreateAddOperations(operationBox, addTypePartBox, addQuantityUpDown, addUnitBox, addStaffBox, addNotesBox);
            _controller.GetPartOperations(operationGrid, operationBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delPanel.Visible = false;
        }

        private void createDelButton_Click(object sender, EventArgs e)
        {
            _controller.CreateDelOperations(operationBox, delPartBox, delQuantityupDown, delUnitBox, delStaffBox, delNotesBox);
            _controller.GetPartOperations(operationGrid, operationBox);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            _controller.CreatePartsInstallationAct();
        }
    }
}
