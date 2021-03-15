using BTL.configDB;
using BTL.model;
using BTL.View1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class ManagerForm : Form
    {
        private readonly User user;

        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(User data) : this()
        {
            this.user = data;

        }
        public void getUserPublic()
        {
            getUser();
        }
        private void getUser()
        {
            string query = "select * from tblTaiKhoan where tenDangNhap = '" + user.username + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        user.username = (string)reader["tenDangNhap"];

                        user.password = (string)reader["matKhau"];
                    }
                }
                conn.Close();
            }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            addForm(frm);
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(this.user);
            frm.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog();
            Close();
        }
        private void addForm(Form frm)
        {
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void mangerEmp_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            addForm(frm);
        }

        private void managerSalary_Click(object sender, EventArgs e)
        {

        }

        private void managerPosition_Click(object sender, EventArgs e)
        {
            FormChucvu frm = new FormChucvu();
            addForm(frm);
        }

        private void managerProject_Click(object sender, EventArgs e)
        {
            frmDuAn frm = new frmDuAn();
            addForm(frm);
        }

        private void managerComplain_Click(object sender, EventArgs e)
        {

        }

        private void managerDepartment_Click(object sender, EventArgs e)
        {
            FormPhongban frm = new FormPhongban();
            addForm(frm);
        }

        private void managerWordkingProcess_Click(object sender, EventArgs e)
        {

        }
    }
}
