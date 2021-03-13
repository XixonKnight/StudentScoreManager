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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCreateRegister_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                string username = txtCreateUsername.Text;
                string password = txtCreatePassword.Text;
                DateTime createdDate = DateTime.Now;

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    if (username != "" && password != "")
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pro_inserUser";
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@createdDate", createdDate);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tạo tài khoản thành công  ", Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showFrmLogin();
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show(e.Message, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập đầy đủ thông tin tài khoản", Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            showFrmLogin();
        }

        private void showFrmLogin()
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
