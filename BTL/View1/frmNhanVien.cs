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
using BTL.configDB;
using BTL.Control1;
using BTL.Object1;
using BTL.View1;

namespace BTL.View1
{
    public partial class frmNhanVien : Form
    {
        NhanVienCtrl nvctr = new NhanVienCtrl();
        NhanVienObj nvObj = new NhanVienObj();
        int flag = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        //frm load
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvctr.getData();
            dgvDSNV.DataSource = dtNhanVien;
            bingding();
            showDataCbx();
        }
        //add data
        void bingding()
        {
            if (dgvDSNV.Rows.Count != 0)
            {
                txtma.DataBindings.Clear();
                txtma.DataBindings.Add("Text", dgvDSNV.DataSource, "idNV");
                txtten.DataBindings.Clear();
                txtten.DataBindings.Add("text", dgvDSNV.DataSource, "tenNV");
                dtngaysinh.DataBindings.Clear();
                dtngaysinh.DataBindings.Add("Text", dgvDSNV.DataSource, "ngaySinh");
                cbgioitinh.DataBindings.Clear();
                cbgioitinh.DataBindings.Add("Text", dgvDSNV.DataSource, "gioiTinh");
                txtsdt.DataBindings.Clear();
                txtsdt.DataBindings.Add("Text", dgvDSNV.DataSource, "sdt");
                txtemail.DataBindings.Clear();
                txtemail.DataBindings.Add("Text", dgvDSNV.DataSource, "email");
                txtcmnd.DataBindings.Clear();
                txtcmnd.DataBindings.Add("Text", dgvDSNV.DataSource, "cmnd");
                txtquequan.DataBindings.Clear();
                txtquequan.DataBindings.Add("Text", dgvDSNV.DataSource, "queQuan");
                //txtmaphongban.DataBindings.Clear();
                //txtmaphongban.DataBindings.Add("Text", dgvDSNV.DataSource, "idPb");
                //txtmachucvu.DataBindings.Clear();
                //txtmachucvu.DataBindings.Add("Text", dgvDSNV.DataSource, "idChucVu");
                //cbxDepartment.set
                txthsl.DataBindings.Clear();
                txthsl.DataBindings.Add("Text", dgvDSNV.DataSource, "heSoLuong");
                txttrinhdo.DataBindings.Clear();
                txttrinhdo.DataBindings.Add("Text", dgvDSNV.DataSource, "trinhDoHocVan");
                dtngayky.DataBindings.Clear();
                dtngayky.DataBindings.Add("Text", dgvDSNV.DataSource, "ngayKiHopDong");
                dthanhopdong.DataBindings.Clear();
                dthanhopdong.DataBindings.Add("Text", dgvDSNV.DataSource, "hanHopDong");
                dtngaytao.DataBindings.Clear();
                dtngaytao.DataBindings.Add("Text", dgvDSNV.DataSource, "createdDate");
                dtngaycapnhat.DataBindings.Clear();
                dtngaycapnhat.DataBindings.Add("Text", dgvDSNV.DataSource, "updateDate");
            }

        }
        //Enabled
        void dis_en(bool e)
        {
            txtma.Enabled = e;
            txtten.Enabled = e;
            txthsl.Enabled = e;
            txtemail.Enabled = e;
            txtcmnd.Enabled = e;
            //txtmachucvu.Enabled = e;
            //txtmaphongban.Enabled = e;
            cbxDepartment.Enabled = e;
            cbxPosition.Enabled = e;
            txtsdt.Enabled = e;
            txttrinhdo.Enabled = e;
            txtquequan.Enabled = e;
            dthanhopdong.Enabled = e;
            dtngaycapnhat.Enabled = e;
            dtngayky.Enabled = e;
            dtngaysinh.Enabled = e;
            dtngaytao.Enabled = e;
            cbgioitinh.Enabled = e;

            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        //gán dữ liệu
        void ganDuLieu(NhanVienObj nvObj)
        {
            nvObj.Idnv = txtma.Text.Trim();
            nvObj.Idpb = (cbxDepartment.SelectedValue).ToString();
            nvObj.Idchucvu = (cbxPosition.SelectedValue).ToString();
            nvObj.Ten = txtten.Text.Trim();
            nvObj.Gioitinh = cbgioitinh.Text.Trim();
            nvObj.Cmnd = txtcmnd.Text.Trim();
            nvObj.Que = txtquequan.Text.Trim();
            nvObj.Hsl = txthsl.Text.Trim();
            nvObj.Sdt = txtsdt.Text.Trim();
            nvObj.Trinhdohocvan = txttrinhdo.Text.Trim();
            nvObj.Email = txtemail.Text.Trim();
            nvObj.Hanhopdong = dthanhopdong.Text.Trim();
            nvObj.Createddate = dtngaytao.Text.Trim();
            nvObj.Ngaykyhopdong = dtngayky.Text.Trim();
            nvObj.Ngaysinh = dtngaysinh.Text.Trim();
            nvObj.Updatedate = dtngaycapnhat.Text.Trim();

        }
        //
        void loadcontrol()
        {
            cbgioitinh.Items.Add("Nam");
            cbgioitinh.Items.Add("Nữ");

            dtngaysinh.Text = DateTime.Now.ToShortDateString();
            dtngayky.Text = DateTime.Now.ToShortDateString();
            dtngaycapnhat.Text = DateTime.Now.ToShortDateString();
            dthanhopdong.Text = DateTime.Now.ToShortDateString();
            dtngaytao.Text = DateTime.Now.ToShortDateString();

        }
        //thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            loadcontrol();
        }
        //sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            loadcontrol();
        }
        //xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvctr.delData(txtma.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frmNhanVien_Load(sender, e);
        }
        //lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(nvObj);
            if (flag == 0)
            {
                if (nvctr.addData(nvObj))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (nvctr.updData(nvObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);

        }
        //hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            dis_en(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDuAn frmDuAn = new frmDuAn();
            frmDuAn.ShowDialog();
            this.Close();
        }
        private DataSet getDataCbx()
        {
            DataSet ds = new DataSet();
            //DataTable dtDepartment= new DataTable();
            //DataTable dtPosition = new DataTable();
            string queryDepartment = "select * from tblPhongBan";
            string queryPos = "select * from tblChucVu";
            using(SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                SqlDataAdapter dataDepartment = new SqlDataAdapter(queryDepartment,conn);
                SqlDataAdapter dataPos = new SqlDataAdapter(queryPos,conn);
                dataDepartment.Fill(ds, "department");
                dataPos.Fill(ds, "position");
                //dtDepartment = ds.Tables["department"];
                //dtPosition = ds.Tables["position"];
                conn.Close();
            }
            return ds;
        }
        private void showDataCbx()
        {
            DataSet ds = getDataCbx();
            DataTable dtDepratment = ds.Tables["department"];
            DataView viewDepartment = new DataView(dtDepratment);
            viewDepartment.Sort = "id";
            cbxDepartment.DataSource = viewDepartment;
            cbxDepartment.DisplayMember = "tenPhongBan";
            cbxDepartment.ValueMember = "id";
            DataTable dtPosition = ds.Tables["position"];
            DataView viewPos = new DataView(dtPosition);
            viewPos.Sort = "id";
            cbxPosition.DataSource = viewPos;
            cbxPosition.DisplayMember = "tenChucVu";
            cbxPosition.ValueMember = "id";
        }
    }

}
