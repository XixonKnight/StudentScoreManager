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
    public partial class frmWorkingProcess : Form
    {
        private bool flag;
        public frmWorkingProcess()
        {
            InitializeComponent();
        }

        private void frmWorkingProcess_Load(object sender, EventArgs e)
        {
            loadData();
            loadCbxEmp();
            clearData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearData();
            changeEnable(true);
            flag = true;
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "proc_select_working_process";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "Emp");
                    lstWorkingProcess.DataSource = dataSet.Tables["Emp"];
                }
                conn.Close();
            }
        }
        private void insert()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "proc_insert_working_process";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());
                    cmd.Parameters.AddWithValue("@idNV", cbxEmp.SelectedValue);
                    cmd.Parameters.AddWithValue("@dcCongTac", txtAddressWorking.Text.Trim());
                    cmd.Parameters.AddWithValue("@thoiGianBatDau", txtEffectiveDate.Value);
                    cmd.Parameters.AddWithValue("@thoiGianKetThuc", txtExpiredDate.Value);
                    cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(Constants.Messeage_Add_Success, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Constants.Messeage_Add_Error, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
        }
        private void update()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "proc_update_working_process";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());
                    cmd.Parameters.AddWithValue("@idNV", cbxEmp.SelectedValue);
                    cmd.Parameters.AddWithValue("@dcCongTac", txtAddressWorking.Text.Trim());
                    cmd.Parameters.AddWithValue("@thoiGianBatDau", txtEffectiveDate.Value);
                    cmd.Parameters.AddWithValue("@thoiGianKetThuc", txtExpiredDate.Value);
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
        private void loadCbxEmp()
        {
            DataTable dataEmp = new NhanVienCtrl().getDataEmp();
            DataView viewCbxEmp = new DataView(dataEmp);
            viewCbxEmp.Sort = "idNV";
            cbxEmp.DataSource = viewCbxEmp;
            cbxEmp.DisplayMember = "tenNV";
            cbxEmp.ValueMember = "idNV";
        }
        private void changeEnable(bool value)
        {
            txtId.Enabled = value;
            txtAddressWorking.Enabled = value;
            txtEffectiveDate.Enabled = value;
            txtExpiredDate.Enabled = value;
            cbxEmp.Enabled = value;
            btnSave.Enabled = value;
            btnCancel.Enabled = value;
            btnAdd.Enabled = !value;
            btnEdit.Enabled = !value;
            btnRemove.Enabled = !value;
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
            clearData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flag = false;
            changeEnable(true);
            txtId.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="")
            {
                DialogResult notify = MessageBox.Show(Constants.Messeage_Del,Constants.Messeage_Confirm,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (notify.Equals(DialogResult.Yes))
                {
                    string query = "delete tblQTCT where id = " + int.Parse(txtId.Text) + "";
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
                    {
                        conn.Open();
                        using(SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show(Constants.Messeage_Del_Success, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();
                                clearData();
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
            clearData();
        }

        private void lstWorkingProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectItem = lstWorkingProcess.Rows[index];
            txtId.Text = selectItem.Cells[0].Value.ToString();
            cbxEmp.SelectedIndex = cbxEmp.FindString(selectItem.Cells[1].Value.ToString());
            txtAddressWorking.Text = selectItem.Cells[2].Value.ToString();
            txtEffectiveDate.Value = DateTime.Parse(selectItem.Cells[3].Value.ToString());
            txtExpiredDate.Value = DateTime.Parse(selectItem.Cells[4].Value.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            changeEnable(false);
        }
        private void clearData()
        {
            txtId.Clear();
            txtAddressWorking.Clear();

        }
    }
}
