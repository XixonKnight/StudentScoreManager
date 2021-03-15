using BTL.common;
using BTL.configDB;
using BTL.Control1;
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
    public partial class frmSalary : Form
    {
        private bool flag;
        private int idSalary;
        public frmSalary()
        {
            InitializeComponent();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            flag = true;
            changeEnable(true);
        }

        private void frmSalary_Load(object sender, EventArgs e)
        {
            loadData();
            loadCbxEmp();
            setCbxCoefSalary();
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "proc_select_data_salary";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "salary");
                    lstSalary.DataSource = dataSet.Tables["salary"];
                }
                conn.Close();
            }
        }
        private void loadCbxEmp()
        {
            DataTable dataEmp = new NhanVienCtrl().getDataEmp();
            DataView viewCbxEmp = new DataView(dataEmp);
            viewCbxEmp.Sort = "idNV";
            cbxEmp.DataSource = viewCbxEmp;
            cbxEmp.DisplayMember = "tenNV";
            cbxEmp.ValueMember = "idNV";
        }
        private void setCbxCoefSalary()
        {
            cbxAllowance.Items.Add(500);
            cbxAllowance.Items.Add(1000);
            cbxAllowance.Items.Add(1500);
        }

        private void cbxEmp_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idEmp = int.Parse(cbxEmp.SelectedValue.ToString());
                getCoefByEmp(idEmp);
            }
            catch (Exception)
            {
            }
            
        }

        private void getCoefByEmp(int id)
        {
            string query = "select nv.heSoLuong from tblNhanVien nv where idNV=" + id + "";
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query,conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtCoefSalary.Text = reader[0].ToString();
                    }

                }
                conn.Close();
            }
        }


        private float payroll()
        {
            float basicSalary = float.Parse(txtBasicSalary.Text);
            float coef = float.Parse(txtCoefSalary.Text);
            float allowance = float.Parse(cbxAllowance.SelectedItem.ToString());
            float bonus = float.Parse(txtBonus.Text);

            return (basicSalary * coef) + allowance + bonus;
        }
        private void changeEnable(bool value)
        {
            cbxEmp.Enabled = value;
            txtBasicSalary.Enabled = value;
            txtBonus.Enabled = value;
            txtMedical.Enabled = value;
            txtSocial.Enabled = value;
            cbxAllowance.Enabled = value;
            btnSave.Enabled = value;
            btnCancel.Enabled = value;
            btnPayroll.Enabled = !value;
            btnEdit.Enabled = !value;
            btnRemove.Enabled = !value;
        }
        private void insert()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "proc_insert_salary";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idNhanVien", int.Parse(cbxEmp.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@luongCoBan", float.Parse(txtBasicSalary.Text));
                    cmd.Parameters.AddWithValue("@heSoLuong", float.Parse(txtCoefSalary.Text));
                    cmd.Parameters.AddWithValue("@phuCap", float.Parse(cbxAllowance.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@tienThuong", float.Parse(txtBonus.Text));
                    cmd.Parameters.AddWithValue("@luong", payroll());
                    cmd.Parameters.AddWithValue("@baoHiemXaHoi", txtSocial.Text);
                    cmd.Parameters.AddWithValue("@baoHiemYTe", txtMedical.Text);
                    cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(Constants.Messeage_Add_Success, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        string mex = ex.Message;
                        MessageBox.Show(Constants.Messeage_Add_Error, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            changeEnable(false);
            clearForm();
        }
        private void clearForm()
        {
            txtBasicSalary.Clear();
            txtBonus.Clear();
            txtCoefSalary.Clear();
            txtMedical.Clear();
            txtSocial.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                insert();
            }
            else
            {
                update();
            }
            clearForm();
            changeEnable(false);
        }

        private void update()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "proc_update_salary";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", idSalary);
                    cmd.Parameters.AddWithValue("@idNhanVien", int.Parse(cbxEmp.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@luongCoBan", float.Parse(txtBasicSalary.Text));
                    cmd.Parameters.AddWithValue("@heSoLuong", float.Parse(txtCoefSalary.Text));
                    cmd.Parameters.AddWithValue("@phuCap", float.Parse(cbxAllowance.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@tienThuong", float.Parse(txtBonus.Text));
                    cmd.Parameters.AddWithValue("@luong", payroll());
                    cmd.Parameters.AddWithValue("@baoHiemXaHoi", txtSocial.Text);
                    cmd.Parameters.AddWithValue("@baoHiemYTe", txtMedical.Text);
                    cmd.Parameters.AddWithValue("@updateDate", DateTime.Now);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(Constants.Messeage_Update_Success, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Constants.Messeage_Udpate_Error, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flag = false;
            changeEnable(true);
        }

        private void lstSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectItem = lstSalary.Rows[index];
            idSalary = int.Parse(selectItem.Cells[0].Value.ToString());
            cbxEmp.SelectedIndex = cbxEmp.FindString(selectItem.Cells[1].Value.ToString());
            txtBasicSalary.Text = selectItem.Cells[2].Value.ToString();
            cbxAllowance.SelectedIndex = cbxAllowance.FindString(selectItem.Cells[4].Value.ToString());
            txtBonus.Text = selectItem.Cells[5].Value.ToString();
            txtSocial.Text = selectItem.Cells[7].Value.ToString();
            txtMedical.Text = selectItem.Cells[8].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtBasicSalary.Text != "")
            {
                DialogResult notify = MessageBox.Show(Constants.Messeage_Del, Constants.Messeage_Confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (notify.Equals(DialogResult.Yes))
                {
                    string query = "delete tblBangLuong where id = " + idSalary + "";
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show(Constants.Messeage_Del_Success, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();
                                clearForm();
                            }
                            catch (Exception ex)
                            {
                                string mes = ex.Message;
                                MessageBox.Show(Constants.Messeage_Del_Fail, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(Constants.Messeage_Del_Error, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
