using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Control1;
using BTL.Object1;

namespace BTL.View1
{
    public partial class frmDuAn : Form
    {
        DuAnCtrl daCtrl = new DuAnCtrl();
        DuAnObj daObj = new DuAnObj();
        int flag = 0;
        public frmDuAn()
        {
            InitializeComponent();
        }

        private void frmDuAn_Load(object sender, EventArgs e)
        {
            DataTable dtDuAN = new DataTable();
            dtDuAN = daCtrl.GetData();
            dgvDSDA.DataSource = dtDuAN;
            bingding();
        }
//add data
        void bingding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDSDA.DataSource, "id");
            txttenduan.DataBindings.Clear();
            txttenduan.DataBindings.Add("Text", dgvDSDA.DataSource, "tenDA");
            txttencongty.DataBindings.Clear();
            txttencongty.DataBindings.Add("Text", dgvDSDA.DataSource, "tenCtyDoiTac");
            txtmanhanvien.DataBindings.Clear();
            txtmanhanvien.DataBindings.Add("Text", dgvDSDA.DataSource, "idNV");
            dtngaybatdau.DataBindings.Clear();
            dtngaybatdau.DataBindings.Add("Text", dgvDSDA.DataSource, "thoiGianBatDau");
            dtngayketthuc.DataBindings.Clear();
            dtngayketthuc.DataBindings.Add("Text", dgvDSDA.DataSource, "thoiGianKetThuc");
            dtngaytao.DataBindings.Clear();
            dtngaytao.DataBindings.Add("Text", dgvDSDA.DataSource, "createdDate");
            dtngaycapnhat.DataBindings.Clear();
            dtngaycapnhat.DataBindings.Add("Text", dgvDSDA.DataSource, "updateDate");

        }
//Enable
        void dis_en(bool e)
        {
            txtma.Enabled = e;
            txtmanhanvien.Enabled = e;
            txttencongty.Enabled = e;
            txttenduan.Enabled = e;
            dtngaybatdau.Enabled = e;
            dtngayketthuc.Enabled = e;
            dtngaytao.Enabled = e;
            dtngaycapnhat.Enabled = e;


            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
//gán dữ liệu
        void ganDuLieu(DuAnObj daObj)
        {
            daObj.Mada = txtma.Text.Trim();
            daObj.Manv = txtmanhanvien.Text.Trim();
            daObj.Tencty = txttencongty.Text.Trim();
            daObj.Tenda = txttenduan.Text.Trim();
            daObj.Ngaybdda = dtngaybatdau.Text.Trim();
            daObj.Ngayktda = dtngayketthuc.Text.Trim();
            daObj.Ngaytao = dtngaytao.Text.Trim();
            daObj.Ngaycapnhat = dtngaycapnhat.Text.Trim();


        }
        //
        void loadcontrol()
        {
            dtngaybatdau.Text = DateTime.Now.ToShortDateString();
            dtngaycapnhat.Text = DateTime.Now.ToShortDateString();
            dtngayketthuc.Text = DateTime.Now.ToShortDateString();
            dtngaytao.Text = DateTime.Now.ToShortDateString();

        }
//btn thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
            loadcontrol();
        }
//btn sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            loadcontrol();
        }
//btn xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (daCtrl.delData(txtma.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frmDuAn_Load(sender, e);
        }
//btn lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(daObj);
            if (flag == 0)
            {
                if (daCtrl.addData(daObj))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (daCtrl.updData(daObj))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                frmDuAn_Load(sender, e);
        }
//btn hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDuAn_Load(sender, e);
            dis_en(false);
        }
    }
}
