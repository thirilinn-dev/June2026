using June2026.Database.AppDbContextModels;
using Microsoft.VisualBasic.ApplicationServices;

namespace June2026.WinFormsApp1
{
    public partial class FrmUser : Form
    {
        private readonly AppDbContext _db;
        private int editUserId = 0;
        public FrmUser()
        {
            InitializeComponent();
            _db = new AppDbContext();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            var lst = _db.TblUsers.ToList();

            int rowNo = 0;
            List<UserDto> users = new List<UserDto>();

            foreach (var item in lst)
            {
                UserDto user = new UserDto()
                {
                    Username = item.Username,
                    Password = item.Password,
                    UserId = item.Id,
                    RowNo = ++rowNo
                };

                users.Add(user);

                //users.Add(new UserDto
                //{
                //    UserId = item.Id,
                //    Username = item.Username,
                //    Password = item.Password
                //});
            }

            dgvData.DataSource = users;

            ClearControls();
        }

        public class UserDto
        {
            public int RowNo { get; set; }

            public int UserId { get; set; }

            public string Username { get; set; }

            public string Password { get; set; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(editUserId == 0)
            {
                _db.TblUsers.Add(new TblUser
                {
                    Password = txtPassword.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                });

                _db.SaveChanges();

            }
            else
            {
                var item = _db.TblUsers.Where(x => x.Id == editUserId).FirstOrDefault();

                if (item is null) return;

                item.Username = txtUsername.Text.Trim();
                item.Password = txtPassword.Text.Trim();
            }

            editUserId = 0;

            BindData();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
           if(e.ColumnIndex == 0) //Edit
            {
                int userId = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["ColUserId"].Value);
                var item = _db.TblUsers.Where(x => x.Id == userId).FirstOrDefault();

                if (item is null) return;

                txtUsername.Text = item.Username;
                txtPassword.Text = item.Password;
                editUserId = item.Id;
            }
           else if(e.ColumnIndex == 1) //Delete
            {
                var result = MessageBox.Show("Are you sure want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int userId = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["ColUserId"].Value);
                    var item = _db.TblUsers.Where(x => x.Id == userId).FirstOrDefault();

                    if (item is null) return;

                    _db.Remove(item);
                    _db.SaveChanges();

                    BindData();
                }
            }
        }
    }
}
