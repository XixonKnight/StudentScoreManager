﻿using System;
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
    public partial class FrmPhongban : Form
    {
        public FrmPhongban()
        {
            InitializeComponent();
        }

        void boqua()
        {
            txtIdpb.Text = "";
            txtTenpb.Text = "";

        }
        private int kiemtra()
        {
            String k = txtIdpb.Text;
            string sql = "select * from tblPhongBan  where id ='" + k.ToString() + "'";
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
        void loadFrmPhongban()
        {
            String constr = ConfigurationManager.ConnectionStrings["QlNhanVien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(" select*from tblPhongBan;", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvPhongban.DataSource = tb;
                        dgvPhongban.Columns[0].HeaderText = "Id ";
                        dgvPhongban.Columns[1].HeaderText = "Tên Phong Ban";
                        dgvPhongban.Columns[2].HeaderText = "Creat date";
                        dgvPhongban.Columns[3].HeaderText = "update Date";


                    }
                }
            }
        }

        private void FrmPhongban_Load(object sender, EventArgs e)
        {
            loadFrmPhongban();
        }
        //Chức năng sửapb
        private void btnSuapb_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QLNhanVien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "update_pb";
                    if (txtIdpb.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập id ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdpb.Focus();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@id", txtIdpb.Text);
                    }
                    if (txtTenpb.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập Tên phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenpb.Focus();
                        return;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@tenPhongBan", txtTenpb.Text);
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
                    loadFrmPhongban();
                }

            }
        }
        //chức năng thoát 
        private void btnThoatpb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //chức năng tìm kiếm phòng ban
        private void btnTimkiempb_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QlNhanVien"].ConnectionString;
            string tim = "select * from tblPhongBan where Id is not null";
            if (txtIdpb.Text != "")
            {
                tim = tim + " and id= '" + txtIdpb.Text + "'";
            }

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(tim, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvPhongban.DataSource = tb;
                    }
                }
            }
        }
        //chức năng thêm phòng ban
        private void btnThempb_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["QlNhanVien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                if (kiemtra() == 1)
                {
                    MessageBox.Show("trùng khóa chính");
                    txtIdpb.Focus();
                }
                else
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "insert_pb";
                        if (txtIdpb.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Bạn phải nhập id", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdpb.Focus();
                            return;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id", txtIdpb.Text);
                        }
                        if (txtTenpb.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Bạn phải nhập Tên phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdpb.Focus();
                            return;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@tenPhongBan", txtTenpb.Text);
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
                        loadFrmPhongban();
                    }
                }
            }
        }
        //Chức năng xóa phòng ban 
        private void btnXoapb_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLNhanVien"].ConnectionString;
            string sql = @"DELETE FROM tblPhongBan WHERE (id=N'" + txtIdpb.Text + @"')";
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
                    loadFrmPhongban();
                }
            }
        }
        //chucnang quay lại
        private void btnquaylai_Click(object sender, EventArgs e)
        {
            boqua();
            loadFrmPhongban();
        }
    }


}
