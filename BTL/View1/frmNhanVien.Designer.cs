
namespace BTL.View1
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.dtngaycapnhat = new System.Windows.Forms.DateTimePicker();
            this.dthanhopdong = new System.Windows.Forms.DateTimePicker();
            this.dtngaytao = new System.Windows.Forms.DateTimePicker();
            this.dtngayky = new System.Windows.Forms.DateTimePicker();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtmachucvu = new System.Windows.Forms.TextBox();
            this.txtmaphongban = new System.Windows.Forms.TextBox();
            this.txthsl = new System.Windows.Forms.TextBox();
            this.txttrinhdo = new System.Windows.Forms.TextBox();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNV.Location = new System.Drawing.Point(3, 16);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.Size = new System.Drawing.Size(1027, 113);
            this.dgvDSNV.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(761, 293);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(578, 293);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(414, 293);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(264, 293);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbgioitinh.Enabled = false;
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Location = new System.Drawing.Point(849, 38);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(55, 21);
            this.cbgioitinh.TabIndex = 32;
            // 
            // dtngaycapnhat
            // 
            this.dtngaycapnhat.Enabled = false;
            this.dtngaycapnhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaycapnhat.Location = new System.Drawing.Point(511, 241);
            this.dtngaycapnhat.Name = "dtngaycapnhat";
            this.dtngaycapnhat.Size = new System.Drawing.Size(119, 20);
            this.dtngaycapnhat.TabIndex = 31;
            // 
            // dthanhopdong
            // 
            this.dthanhopdong.Enabled = false;
            this.dthanhopdong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dthanhopdong.Location = new System.Drawing.Point(511, 195);
            this.dthanhopdong.Name = "dthanhopdong";
            this.dthanhopdong.Size = new System.Drawing.Size(119, 20);
            this.dthanhopdong.TabIndex = 30;
            // 
            // dtngaytao
            // 
            this.dtngaytao.Enabled = false;
            this.dtngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaytao.Location = new System.Drawing.Point(151, 241);
            this.dtngaytao.Name = "dtngaytao";
            this.dtngaytao.Size = new System.Drawing.Size(110, 20);
            this.dtngaytao.TabIndex = 29;
            // 
            // dtngayky
            // 
            this.dtngayky.Enabled = false;
            this.dtngayky.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayky.Location = new System.Drawing.Point(151, 195);
            this.dtngayky.Name = "dtngayky";
            this.dtngayky.Size = new System.Drawing.Size(110, 20);
            this.dtngayky.TabIndex = 28;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtngaysinh.Enabled = false;
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(584, 38);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(106, 20);
            this.dtngaysinh.TabIndex = 27;
            // 
            // txtmachucvu
            // 
            this.txtmachucvu.Enabled = false;
            this.txtmachucvu.Location = new System.Drawing.Point(361, 147);
            this.txtmachucvu.Name = "txtmachucvu";
            this.txtmachucvu.Size = new System.Drawing.Size(78, 20);
            this.txtmachucvu.TabIndex = 26;
            // 
            // txtmaphongban
            // 
            this.txtmaphongban.Enabled = false;
            this.txtmaphongban.Location = new System.Drawing.Point(134, 147);
            this.txtmaphongban.Name = "txtmaphongban";
            this.txtmaphongban.Size = new System.Drawing.Size(100, 20);
            this.txtmaphongban.TabIndex = 25;
            // 
            // txthsl
            // 
            this.txthsl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txthsl.Enabled = false;
            this.txthsl.Location = new System.Drawing.Point(584, 144);
            this.txthsl.Name = "txthsl";
            this.txthsl.Size = new System.Drawing.Size(66, 20);
            this.txthsl.TabIndex = 24;
            // 
            // txttrinhdo
            // 
            this.txttrinhdo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttrinhdo.Enabled = false;
            this.txttrinhdo.Location = new System.Drawing.Point(849, 147);
            this.txttrinhdo.Name = "txttrinhdo";
            this.txttrinhdo.Size = new System.Drawing.Size(100, 20);
            this.txttrinhdo.TabIndex = 23;
            // 
            // txtquequan
            // 
            this.txtquequan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtquequan.Enabled = false;
            this.txtquequan.Location = new System.Drawing.Point(849, 90);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(100, 20);
            this.txtquequan.TabIndex = 22;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcmnd.Enabled = false;
            this.txtcmnd.Location = new System.Drawing.Point(584, 87);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(113, 20);
            this.txtcmnd.TabIndex = 21;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(359, 90);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(127, 20);
            this.txtemail.TabIndex = 20;
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(134, 90);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 20);
            this.txtsdt.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvDSNV);
            this.groupBox2.Location = new System.Drawing.Point(3, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1033, 132);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhân Viên";
            // 
            // txtten
            // 
            this.txtten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(359, 38);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(127, 20);
            this.txtten.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(277, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Tên nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.cbgioitinh);
            this.groupBox1.Controls.Add(this.dtngaycapnhat);
            this.groupBox1.Controls.Add(this.dthanhopdong);
            this.groupBox1.Controls.Add(this.dtngaytao);
            this.groupBox1.Controls.Add(this.dtngayky);
            this.groupBox1.Controls.Add(this.dtngaysinh);
            this.groupBox1.Controls.Add(this.txtmachucvu);
            this.groupBox1.Controls.Add(this.txtmaphongban);
            this.groupBox1.Controls.Add(this.txthsl);
            this.groupBox1.Controls.Add(this.txttrinhdo);
            this.groupBox1.Controls.Add(this.txtquequan);
            this.groupBox1.Controls.Add(this.txtcmnd);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 356);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "Dự Án";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(413, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Ngày cập nhật";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Ngày tạo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Hạn hợp đồng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ngày ký hợp đồng";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(754, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Trình độ học vấn";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Hệ số lương";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mã chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã phòng ban";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(777, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quê Quán";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(134, 38);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(117, 293);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.DateTimePicker dtngaycapnhat;
        private System.Windows.Forms.DateTimePicker dthanhopdong;
        private System.Windows.Forms.DateTimePicker dtngaytao;
        private System.Windows.Forms.DateTimePicker dtngayky;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.TextBox txtmachucvu;
        private System.Windows.Forms.TextBox txtmaphongban;
        private System.Windows.Forms.TextBox txthsl;
        private System.Windows.Forms.TextBox txttrinhdo;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
    }
}