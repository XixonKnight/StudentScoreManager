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
    public partial class ManagerForm : Form
    {
        private readonly User user;
        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(User data): this()
        {
            this.user = data;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            getUser();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(this.user);
            frm.ShowDialog();
        }
        private void getUser()
        {
            string query = "select * from tblTaiKhoan where username = '" + user.username + "'";
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query,conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        user.username = (string)reader["tenTaiKhoan"];

                        user.password = (string)reader["matKhau"];
                    }
                }
            }
        }
    }
}
