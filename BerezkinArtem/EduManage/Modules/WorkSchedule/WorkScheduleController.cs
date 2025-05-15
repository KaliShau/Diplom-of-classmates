using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Services.Staff;
using EduManage.Services.WorkSchedule;
using EduManage.Shared;

namespace EduManage.Modules.WorkSchedule
{
    public class WorkScheduleController
    {
        Context _context;
        WorkScheduleService _workScheduleService;
        StaffService _staffService;
        Documents _documents;
        public WorkScheduleController(Context context, WorkScheduleService workScheduleService, StaffService staffService)
        {
            _context = context;
            _staffService = staffService;
            _workScheduleService = workScheduleService;
            _documents = new Documents();
        }

        public void initName(Label label, TextBox positionBox, TextBox departmentBox)
        {
            var staff = _staffService.GetStaffById(_context.staff_id);
            label.Text = "График работы сотрудника " + staff.FullName;
            positionBox.Text = staff.Position;
            departmentBox.Text = staff.Department;
        }

        public void initTimeComboBox(ComboBox startTime, ComboBox endTime)
        {
            startTime.Items.Clear();
            endTime.Items.Clear();

            for (int hours = 0; hours < 24; hours++)
            {
                for (int minutes = 0; minutes < 60; minutes += 30)
                {
                    string timeString = $"{hours:00}:{minutes:00}";
                    startTime.Items.Add(timeString);
                    endTime.Items.Add(timeString);
                }
            }

            startTime.SelectedItem = "09:00";
            endTime.SelectedItem = "17:00";
        }

        public void CreateWorkSchedule(TextBox zoneBox, TextBox typeBox, ComboBox startTime, ComboBox endTime, DateTimePicker dateWorkPicker)
        {
            if (string.IsNullOrEmpty(zoneBox.Text) || string.IsNullOrEmpty(typeBox.Text) || string.IsNullOrEmpty(startTime.Text) || string.IsNullOrEmpty(endTime.Text) || string.IsNullOrEmpty(dateWorkPicker.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            TimeSpan start = TimeSpan.Parse(startTime.SelectedItem.ToString());
            TimeSpan end = TimeSpan.Parse(endTime.SelectedItem.ToString());

            _workScheduleService.CreateSchedule(zoneBox.Text, typeBox.Text, _context.staff_id, dateWorkPicker.Value, start, end);
        }

        public void GetWorkSchedule(DataGridView workScheduleGrid)
        {
            var works = _workScheduleService.GetSchedulesByStaff(_context.staff_id);
            workScheduleGrid.AutoGenerateColumns = true;
            workScheduleGrid.DataSource = works;
        }

        public void GetWorkScheduleToDate(DataGridView workScheduleGrid, DateTimePicker timePicker)
        {
            var works = _workScheduleService.GetSchedulesByStaffAndDate(_context.staff_id, timePicker.Value);
            workScheduleGrid.AutoGenerateColumns = true;
            workScheduleGrid.DataSource = works;
        }

        public void DeleteWorkSchedule(int id)
        {
            _workScheduleService.DeleteSchedule(id);

        }

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                var staff = _staffService.GetStaffById(_context.staff_id);
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить роли как DOCX";
                saveFileDialog.FileName = $"График_работы_{staff.FullName}_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<WorkScheduleDto>;
                    if (dataSource != null)
                    {
                        _documents.SaveToDocx(
                            saveFileDialog.FileName,
                            DocumentTemplateType.GeneralInventory,
                            $"График работы сотрудника {staff.FullName}",
                            dataSource);
                    }
                }
            }
        }
    }
}