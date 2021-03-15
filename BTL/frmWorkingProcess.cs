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
        public frmWorkingProcess()
        {
            InitializeComponent();
        }

        private void frmWorkingProcess_Load(object sender, EventArgs e)
        {
            loadData();
            loadCbxEmp();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            changeEnable(true);
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
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Constants.Messeage_Add_Error, Constants.NOTIFY, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            insert();
        }
    }
}
