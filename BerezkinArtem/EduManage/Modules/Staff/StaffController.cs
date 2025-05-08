using EduManage.Services.Staff;
using EduManage.Shared;
using System.Windows.Forms;

namespace EduManage.Modules.Staff
{
    public class StaffController
    {
        StaffService _staffServicel;
        Context _context;
        public StaffController(StaffService staffService, Context context)
        {
            _staffServicel = staffService;
            _context = context;
        }

        public void GetStaff(DataGridView staffGrid)
        {
            if (_context.User.Role.Name == "Admin")
            {

                var staffs = _staffServicel.GetAllStaff();
                staffGrid.AutoGenerateColumns = true;
                staffGrid.DataSource = staffs;
            }
            else
            {
                var staffs = _staffServicel.GetStaffForAccountant();
                staffGrid.AutoGenerateColumns = true;
                staffGrid.DataSource = staffs;
            }
        }

        public void GetStaffsSearch(DataGridView staffGrid, string searchTerm)
        {
            if (_context.User.Role.Name == "Admin")
            {

                var staffs = _staffServicel.SearchStaff(searchTerm);
                staffGrid.AutoGenerateColumns = true;
                staffGrid.DataSource = staffs;
            }
            else
            {
                var staffs = _staffServicel.SearchStaffForAccountant(searchTerm);
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



            _staffServicel.CreateStaff(new StaffDto { FullName = nameBox.Text, Position = positionBox.Text, Department = departmentBox.Text, Phone = phoneBox.Text, HireDate = hireDatePicker.Value });


        }


        public void DeleteStaff(int id)
        {
            _staffServicel.DeleteStaff(id);
        }


    }
}
