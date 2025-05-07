using EduManage.Shared;

namespace EduManage.Modules.Requests
{
    public partial class RequestsForm : Form
    {
        RequestsController _controller;
        string _selectedId;
        Context _context;
        public RequestsForm(RequestsController controller, Context context)
        {
            InitializeComponent();
            _controller = controller;
            _context = context;

            _controller.GetRequests(requestsGrid);
        }

        private void openCreateButton_Click(object sender, EventArgs e)
        {
            if (createPanel.Visible == true)
            {
                createPanel.Visible = false;
            }
            else
            {
                _controller.AddInventoryToComboBox(inventoryBox);
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
            if (string.IsNullOrEmpty(problemBox.Text))
            {
                MessageBox.Show("Заполните поля!");
                return;

            }
            _controller.CreateRequests(Convert.ToInt16(inventoryBox.SelectedValue), problemBox.Text);
            _controller.GetRequests(requestsGrid);
        }

        private void requestsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = requestsGrid.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
                {
                    requestsGrid.Rows[hitTest.RowIndex].Selected = true;
                    _selectedId = requestsGrid.Rows[hitTest.RowIndex].Cells[0].Value?.ToString();

                    contextMenuStrip1.Items.Clear();

                    contextMenuStrip1.Items.Add("Удалить", null, (s, ev) => DeleteRequest());

                    if (_context.User.Role.Name == "Accountant" || _context.User.Role.Name == "Admin")
                    {
                        _controller.AddUpdateStatusToMenuStrip(contextMenuStrip1, Convert.ToInt32(_selectedId), requestsGrid);
                    }
                    contextMenuStrip1.Show(requestsGrid, e.Location);
                }
            }
        }



        private void DeleteRequest()
        {
            _controller.DeleteRequest(Convert.ToInt32(_selectedId));
            _controller.GetRequests(requestsGrid);
            problemBox.Clear();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrEmpty(searchTerm))
            {
                _controller.GetRequests(requestsGrid);
            }
            else
            {
                _controller.GetRequestsSearch(requestsGrid, searchTerm);
            }
        }

    }
}
