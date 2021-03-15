
namespace BTL
{
    partial class FormChucvu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenchucvu = new System.Windows.Forms.TextBox();
            this.txtIdcv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoacv = new System.Windows.Forms.Button();
            this.btnTimkiemcv = new System.Windows.Forms.Button();
            this.btnThemcv = new System.Windows.Forms.Button();
            this.btnSuacv = new System.Windows.Forms.Button();
            this.dgvChucvu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenchucvu);
            this.panel1.Controls.Add(this.txtIdcv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 100);
            this.panel1.TabIndex = 1;
            // 
            // txtTenchucvu
            // 
            this.txtTenchucvu.Location = new System.Drawing.Point(542, 22);
            this.txtTenchucvu.Name = "txtTenchucvu";
            this.txtTenchucvu.Size = new System.Drawing.Size(174, 20);
            this.txtTenchucvu.TabIndex = 5;
            // 
            // txtIdcv
            // 
            this.txtIdcv.Location = new System.Drawing.Point(147, 22);
            this.txtIdcv.Name = "txtIdcv";
            this.txtIdcv.Size = new System.Drawing.Size(174, 20);
            this.txtIdcv.TabIndex = 4;
            this.txtIdcv.TextChanged += new System.EventHandler(this.txtIdcv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuaylai);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoacv);
            this.panel2.Controls.Add(this.btnTimkiemcv);
            this.panel2.Controls.Add(this.btnThemcv);
            this.panel2.Controls.Add(this.btnSuacv);
            this.panel2.Location = new System.Drawing.Point(13, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(640, 20);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(75, 48);
            this.btnQuaylai.TabIndex = 5;
            this.btnQuaylai.Text = "Back";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(519, 20);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 48);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoacv
            // 
            this.btnXoacv.Location = new System.Drawing.Point(397, 20);
            this.btnXoacv.Name = "btnXoacv";
            this.btnXoacv.Size = new System.Drawing.Size(75, 48);
            this.btnXoacv.TabIndex = 3;
            this.btnXoacv.Text = "Xóa";
            this.btnXoacv.UseVisualStyleBackColor = true;
            this.btnXoacv.Click += new System.EventHandler(this.btnXoacv_Click);
            // 
            // btnTimkiemcv
            // 
            this.btnTimkiemcv.Location = new System.Drawing.Point(268, 20);
            this.btnTimkiemcv.Name = "btnTimkiemcv";
            this.btnTimkiemcv.Size = new System.Drawing.Size(75, 48);
            this.btnTimkiemcv.TabIndex = 2;
            this.btnTimkiemcv.Text = "Tìm kiếm";
            this.btnTimkiemcv.UseVisualStyleBackColor = true;
            this.btnTimkiemcv.Click += new System.EventHandler(this.btnTimkiemcv_Click);
            // 
            // btnThemcv
            // 
            this.btnThemcv.Location = new System.Drawing.Point(146, 20);
            this.btnThemcv.Name = "btnThemcv";
            this.btnThemcv.Size = new System.Drawing.Size(75, 48);
            this.btnThemcv.TabIndex = 1;
            this.btnThemcv.Text = "Thêm";
            this.btnThemcv.UseVisualStyleBackColor = true;
            this.btnThemcv.Click += new System.EventHandler(this.btnThemcv_Click);
            // 
            // btnSuacv
            // 
            this.btnSuacv.Location = new System.Drawing.Point(35, 20);
            this.btnSuacv.Name = "btnSuacv";
            this.btnSuacv.Size = new System.Drawing.Size(75, 48);
            this.btnSuacv.TabIndex = 0;
            this.btnSuacv.Text = "Sửa";
            this.btnSuacv.UseVisualStyleBackColor = true;
            this.btnSuacv.Click += new System.EventHandler(this.btnSuacv_Click);
            // 
            // dgvChucvu
            // 
            this.dgvChucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucvu.Location = new System.Drawing.Point(13, 118);
            this.dgvChucvu.Name = "dgvChucvu";
            this.dgvChucvu.Size = new System.Drawing.Size(755, 204);
            this.dgvChucvu.TabIndex = 3;
            // 
            // FormChucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.dgvChucvu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChucvu";
            this.Text = "FormChucvu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChucvu_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucvu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenchucvu;
        private System.Windows.Forms.TextBox txtIdcv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvChucvu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoacv;
        private System.Windows.Forms.Button btnTimkiemcv;
        private System.Windows.Forms.Button btnThemcv;
        private System.Windows.Forms.Button btnSuacv;
        private System.Windows.Forms.Button btnQuaylai;
    }
}