using System;
using System.Windows.Forms;

namespace EduManage.Modules.WorkSchedule
{
    public partial class WorkScheduleForm : Form
    {
        WorkScheduleController _controller;
        string _selectedId;
        public WorkScheduleForm(WorkScheduleController controller)
        {
            InitializeComponent();
            _controller = controller;

            _controller.initTimeComboBox(startTimeBox, endTimeBox);
            _controller.GetWorkSchedule(workScheduleGrid);
            _controller.initName(label1);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            zoneBox.Clear();
            typeBox.Clear();

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

        private void createButton_Click(object sender, EventArgs e)
        {
            _controller.CreateWorkSchedule(zoneBox, typeBox, startTimeBox, endTimeBox, dateWorkPicker);
            _controller.GetWorkSchedule(workScheduleGrid);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeleteWorkSchedule(Convert.ToInt32(_selectedId));
            _controller.GetWorkSchedule(workScheduleGrid);
        }

        private void workScheduleGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = workScheduleGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    workScheduleGrid.Rows[hitTest.RowIndex].Selected = true;

                    _selectedId = workScheduleGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Show(workScheduleGrid, e.Location);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.GetWorkSchedule(workScheduleGrid);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _controller.GetWorkScheduleToDate(workScheduleGrid, searchPicker);
        }
    }
}
