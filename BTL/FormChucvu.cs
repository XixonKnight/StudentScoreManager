using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormChucvu : Form
    {
        public FormChucvu()
        {
            InitializeComponent();
        }
        void boqua()
        {
            txtIdcv.Text = "";
            txtTenchucvu.Text = "";

        }
        private int kiemtra()
        {
            String k = txtIdcv.Text;
            string sql = "select * from tblChucVu where id ='" + k.ToString() + "'";
            string constr = ConfigurationManager.ConnectionStrings["QlNhanVien"].ConnectionString;
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {
                            DataTable tb = new DataTable();
                            ad.Fill(tb);
                            if (tb.Rows.Count > 0) return 1;
                            else return 0;
                        }
                    }
                }
            }
        }
        void loadFormChucvu()
        {
            String constr = BTL.configDB.ConnectionString.connectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(" select*from tblChucVu;", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvChucvu.DataSource = tb;
                        dgvChucvu.Columns[0].HeaderText = "Id ";
                        dgvChucvu.Columns[1].HeaderText = "Tên Chúc vụ";
                        dgvChucvu.Columns[2].HeaderText = "Creat date";
                        dgvChucvu.Columns[3].HeaderText = "update Date";


                    }
                }
            }
        }

        //load form:
        private void FormChucvu_Load(object sender, EventArgs e)
        {
            loadFormChucvu();
        }
        //Chúc năng sửa chức vụ
        private void btnSuacv_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLNhanVien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_cv";
                    if (txtIdcv.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập id ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdcv.Focus();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@id", txtIdcv.Text);
                    }
                    if (txtTenchucvu.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập Tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenchucvu.Focus();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@tenChucVu", txtTenchucvu.Text);
                    }

                    cmd.Parameters.AddWithValue("@createdDate", Convert.ToDateTime(dateTimePicker1.Text));
                    cmd.Parameters.AddWithValue("@updateDate", Convert.ToDateTime(dateTimePicker1.Text));
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    cnn.Close();
                    loadFormChucvu();
                }

            }
        }
        //Chúc năng thêm cv
        private void btnThemcv_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QlNhanVien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                if (kiemtra() == 1)
                {
                    MessageBox.Show("trùng khóa chính");
                    txtIdcv.Focus();
                }
                else
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "insert_cv";
                        if (txtIdcv.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Bạn phải nhập id", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdcv.Focus();
                            return;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id", txtIdcv.Text);
                        }
                        if (txtTenchucvu.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Bạn phải nhập Tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdcv.Focus();
                            return;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@tenChucVu", txtTenchucvu.Text);
                        }

                        cmd.Parameters.AddWithValue("@createdDate", Convert.ToDateTime(dateTimePicker1.Text));
                        cmd.Parameters.AddWithValue("@updateDate", Convert.ToDateTime(dateTimePicker1.Text));
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                        cnn.Close();
                        loadFormChucvu();
                    }
                }
            }
        }
        //Chức năng thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Chúc năng tìm kiếm
        private void btnTimkiemcv_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QlNhanVien"].ConnectionString;
            string tim = "select * from tblChucVu where Id is not null";
            if (txtIdcv.Text != "")
            {
                tim = tim + " and id= '" + txtIdcv.Text + "'";
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(tim, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvChucvu.DataSource = tb;
                    }
                }
            }
        }
        //Chức năng xóa
        private void btnXoacv_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLNhanVien"].ConnectionString;
            string sql = @"DELETE FROM tblChucVu WHERE (id=N'" + txtIdcv.Text + @"')";
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand(sql, Cnn))
                {
                    // Cmd.CommandType = CommandType.StoredProcedure;
                    // Cmd.Parameters.AddWithValue("@", id);
                    Cnn.Open();
                    int n = Cmd.ExecuteNonQuery();
                    if (n > 0)
                        MessageBox.Show("Xóa Thành Công!");
                    else
                        MessageBox.Show("Xóa không Thành Công!");
                    Cnn.Close();
                    loadFormChucvu();
                }
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            boqua();
            loadFormChucvu();
        }

        private void FormChucvu_Load_1(object sender, EventArgs e)
        {
            loadFormChucvu();
        }
    }
}
