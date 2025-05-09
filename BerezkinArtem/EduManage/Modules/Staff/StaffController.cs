using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduManage.Modules.Inventory;
using EduManage.Services.Inventory;
using EduManage.Services.Staff;
using EduManage.Shared;

namespace EduManage.Modules.Staff
{
    public class StaffController
    {
        StaffService _staffService;
        Context _context;
        DocumentGenerator _documentGenerator;
        public StaffController(StaffService staffService, Context context)
        {
            _staffService = staffService;
            _context = context;
            _documentGenerator = new DocumentGenerator();
        }

        public void GetStaff(DataGridView staffGrid)
        {
            if (_context.User.Role.Name == "Admin")
            {

                var staffs = _staffService.GetAllStaff();
                staffGrid.AutoGenerateColumns = true;
                staffGrid.DataSource = staffs;
            }
            else
            {
                var staffs = _staffService.GetStaffForAccountant();
                staffGrid.AutoGenerateColumns = true;
                staffGrid.DataSource = staffs;
            }
        }

        public void GetStaffsSearch(DataGridView staffGrid, string searchTerm)
        {
            if (_context.User.Role.Name == "Admin")
            {

                var staffs = _staffService.SearchStaff(searchTerm);
                staffGrid.AutoGenerateColumns = true;
                staffGrid.DataSource = staffs;
            }
            else
            {
                var staffs = _staffService.SearchStaffForAccountant(searchTerm);
                staffGrid.AutoGenerateColumns = true;
                staffGrid.DataSource = staffs;
            }
        }

        public void CreateStaff(TextBox nameBox, TextBox positionBox, TextBox departmentBox, TextBox phoneBox, DateTimePicker hireDatePicker)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(positionBox.Text) || string.IsNullOrEmpty(departmentBox.Text) || string.IsNullOrEmpty(phoneBox.Text) || string.IsNullOrEmpty(hireDatePicker.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _staffService.CreateStaff(new StaffDto { FullName = nameBox.Text, Position = positionBox.Text, Department = departmentBox.Text, Phone = phoneBox.Text, HireDate = hireDatePicker.Value });
        }

        public void DeleteStaff(int id)
        {
            _staffService.DeleteStaff(id);
        }

        public void GetUpdatedStaff(int id, TextBox nameBox, TextBox positionBox, TextBox departmentBox, TextBox phoneBox, DateTimePicker hireDatePicker)
        {
            var staff = _staffService.GetStaffById(id);

            nameBox.Text = staff.FullName;
            positionBox.Text = staff.Position;
            departmentBox.Text = staff.Department;
            phoneBox.Text = staff.Phone;
            hireDatePicker.Value = staff.HireDate;
        }

        public void UpdateStaff(int id, TextBox nameBox, TextBox positionBox, TextBox departmentBox, TextBox phoneBox, DateTimePicker hireDatePicker)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(positionBox.Text) || string.IsNullOrEmpty(departmentBox.Text) || string.IsNullOrEmpty(phoneBox.Text) || string.IsNullOrEmpty(hireDatePicker.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }

            _staffService.UpdateStaff(new StaffDto { FullName = nameBox.Text, Position = positionBox.Text, Department = departmentBox.Text, Phone = phoneBox.Text, HireDate = hireDatePicker.Value, Id = id });
        }

        public void ChangeActive(int id)
        {
            _staffService.UpdateIsActive(id);
        }

        public void ExportToDocx(DataGridView grid)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.Title = "Сохранить персонал как DOCX";
                saveFileDialog.FileName = $"Персонал_{DateTime.Now:yyyyMMdd}.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = grid.DataSource as IEnumerable<InventoryDto>;
                    if (dataSource != null)
                    {
                        string description = "Данный документ содержит полный перечень персонала образовательного учреждения.";
                        _documentGenerator.SaveToDocx(
                            saveFileDialog.FileName,
                            "Список персонала",
                            description,
                            dataSource);
                    }
                }
            }
        }
    }
}
