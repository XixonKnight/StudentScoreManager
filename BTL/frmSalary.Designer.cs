
namespace BTL
{
    partial class frmSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoefSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxAllowance = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMedical = new System.Windows.Forms.TextBox();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSalary = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhân Viên";
            // 
            // cbxEmp
            // 
            this.cbxEmp.Enabled = false;
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(130, 41);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(121, 21);
            this.cbxEmp.TabIndex = 4;
            this.cbxEmp.SelectedValueChanged += new System.EventHandler(this.cbxEmp_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "HSL";
            // 
            // txtCoefSalary
            // 
            this.txtCoefSalary.Enabled = false;
            this.txtCoefSalary.Location = new System.Drawing.Point(379, 41);
            this.txtCoefSalary.Name = "txtCoefSalary";
            this.txtCoefSalary.Size = new System.Drawing.Size(121, 20);
            this.txtCoefSalary.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phụ cấp";
            // 
            // cbxAllowance
            // 
            this.cbxAllowance.Enabled = false;
            this.cbxAllowance.FormattingEnabled = true;
            this.cbxAllowance.Location = new System.Drawing.Point(130, 78);
            this.cbxAllowance.Name = "cbxAllowance";
            this.cbxAllowance.Size = new System.Drawing.Size(121, 21);
            this.cbxAllowance.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tiền thưởng";
            // 
            // txtBonus
            // 
            this.txtBonus.Enabled = false;
            this.txtBonus.Location = new System.Drawing.Point(379, 79);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(121, 20);
            this.txtBonus.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "BH Xã Hội";
            // 
            // txtSocial
            // 
            this.txtSocial.Enabled = false;
            this.txtSocial.Location = new System.Drawing.Point(623, 75);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(121, 20);
            this.txtSocial.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(779, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "BH Y tế";
            // 
            // txtMedical
            // 
            this.txtMedical.Enabled = false;
            this.txtMedical.Location = new System.Drawing.Point(839, 75);
            this.txtMedical.Name = "txtMedical";
            this.txtMedical.Size = new System.Drawing.Size(121, 20);
            this.txtMedical.TabIndex = 14;
            // 
            // btnPayroll
            // 
            this.btnPayroll.Location = new System.Drawing.Point(176, 128);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(75, 23);
            this.btnPayroll.TabIndex = 15;
            this.btnPayroll.Text = "Thanh toán";
            this.btnPayroll.UseVisualStyleBackColor = true;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Danh sách lương nhân viên";
            // 
            // lstSalary
            // 
            this.lstSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstSalary.Location = new System.Drawing.Point(12, 230);
            this.lstSalary.Name = "lstSalary";
            this.lstSalary.Size = new System.Drawing.Size(963, 194);
            this.lstSalary.TabIndex = 17;
            this.lstSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstSalary_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(310, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lương cơ bản";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Enabled = false;
            this.txtBasicSalary.Location = new System.Drawing.Point(623, 37);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(121, 20);
            this.txtBasicSalary.TabIndex = 20;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(452, 128);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(590, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(748, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.txtMedical);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxAllowance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCoefSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalary";
            this.Text = "frmSalary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoefSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxAllowance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMedical;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView lstSalary;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}