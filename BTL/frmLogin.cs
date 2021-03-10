using BTL.common;
using BTL.configDB;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                string query = "select * from tblTaiKhoan where tenDangNhap = '" + username +
                    "' and matKhau= '" + password + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        this.Hide();
                        ManagerForm managerForm = new ManagerForm();
                        managerForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công",Constants.NOTIFY,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister fRegister = new frmRegister();
            fRegister.ShowDialog();
            this.Close();
        }
    }
}
