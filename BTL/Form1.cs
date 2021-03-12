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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void boqua()
        {
            txtId.Text = "";
            txtTencv.Text = "";
            
        }
        private int kiemtra()
        {
            String k = txtId.Text;
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

        void loadForm1()
        {
            String constr = ConfigurationManager.ConnectionStrings["QlNhanVien"].ConnectionString;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            loadForm1();
        }
        //Chức năng sửa

       /* private void btnSuacv_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLNhanVien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_cv";
                    if (txtId.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập id ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Focus();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@id", txtId.Text);
                    }
                    if (txtTencv.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập Tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTencv.Focus();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@tenChucVu", txtTencv.Text);
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
                    loadForm1();
                }

            }
        }*/

        private void btnSuacv_Click_1(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLNhanVien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_cv";
                    if (txtId.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập id ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Focus();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@id", txtId.Text);
                    }
                    if (txtTencv.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập Tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTencv.Focus();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@tenChucVu", txtTencv.Text);
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
                    loadForm1();
                }

            }

        }
        //Chức nang thoát:
        private void btnThoatcv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //cn tim kiem theo id:
        private void btnTimkiemcv_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QlNhanVien"].ConnectionString;
            string tim = "select * from tblChucVu where Id is not null";
            if (txtId.Text != "")
            {
                tim = tim + " and id= '" + txtId.Text + "'";
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
        //Cn them:
        private void btnThemcv_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QlNhanVien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                if (kiemtra() == 1)
                {
                    MessageBox.Show("trùng khóa chính");
                    txtId.Focus();
                }
                else
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "insert_cv";
                        if (txtId.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Bạn phải nhập id", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtId.Focus();
                            return;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id", txtId.Text);
                        }
                        if (txtTencv.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Bạn phải nhập Tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtId.Focus();
                            return;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@tenChucVu", txtTencv.Text);
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
                        loadForm1();
                    }
                }
            }
        }
        //chức năng báo cáo
       
        //chức năng xóa
        private void btnXoacv_Click(object sender, EventArgs e)
        {
            /*   DataRowView drvchucvu = dgvChucvu.CurrentRow.DataBoundItem as DataRowView;
               DialogResult ans = MessageBox.Show(
                   string.Format("bạn có muốn xóa chức vụ này không", drvchucvu["id"]),
                   "xóa chức vụ",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
               if (ans != DialogResult.Yes)
               {
                   return;
               }

               string id = Convert.ToString(drvchucvu["id"]);
               try
               {
                   if (deletecv(id))
                       loadForm1();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "co loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }*/

            string connectionString = ConfigurationManager.ConnectionStrings["QLNhanVien"].ConnectionString;
            string sql = @"DELETE FROM tblChucVu WHERE (id=N'" + txtId.Text + @"')"; 
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand(sql, Cnn))
                {
                   // Cmd.CommandType = CommandType.StoredProcedure;
                   // Cmd.Parameters.AddWithValue("@", id);
                    Cnn.Open();
                    int n=Cmd.ExecuteNonQuery();
                    if (n > 0)
                        MessageBox.Show("Xóa Thành Công!");
                    else
                        MessageBox.Show("Xóa không Thành Công!");
                    Cnn.Close();
                    loadForm1();
                }
            }
        }
        // Xem lại sự kiện này 
       
        private void dgvChucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvChucvu.CurrentRow.Cells["id"].Value.ToString();
            txtTencv.Text = dgvChucvu.CurrentRow.Cells["tenChucVu"].Value.ToString();
            dateTimePicker1.Text = dgvChucvu.CurrentRow.Cells["createdDate"].Value.ToString();
            dateTimePicker2.Text = dgvChucvu.CurrentRow.Cells["updateDate"].Value.ToString();

        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            boqua();
            loadForm1();
        }

        /*private bool deletecv(string id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLNhanVien"].ConnectionString;
            string procname = "del_cv";
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand(procname, Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@", id);
                    Cnn.Open();
                    int affectedRecords = Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    return affectedRecords > 0;
                }
            }
        }*/
    }
}
