using BTL.common;
using BTL.configDB;
using BTL.model;
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
    public partial class frmChangePassword : Form
    {
        private User user;
        public frmChangePassword()
        {
            InitializeComponent();
        }
        public frmChangePassword(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                if (checkPassword())
                {
                    DateTime updateDate = DateTime.Now;
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "proc_update_user";
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@password", txtNewPassword.Text);
                        cmd.Parameters.AddWithValue("@updateDate", updateDate);
                        cmd.ExecuteNonQuery();
                        ManagerForm frm = new ManagerForm(user);
                        frm.getUserPublic();
                        MessageBox.Show(Constants.Messeage_Change_Password_Success, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        Close();
                    }
                    conn.Close();
                }
            }
        }

        private bool checkPassword()
        {
            bool flag = true;
            string sql = " select * from tblTaiKhoan where tenDangNhap = '" + user.username +
                "' and matKhau = '" + user.password + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        flag = false;
                    }
                }
                conn.Close();
            }

            if (txtCurrentPassword.Text == "" || txtConfirmPassword.Text == "" || txtNewPassword.Text == "")
            {
                MessageBox.Show(Constants.Messeage_Error_Null, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show(Constants.Messeage_Error_Confirm_Pasword, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!flag)
            {
                MessageBox.Show(Constants.Messeage_Error_Current_Pasword, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
