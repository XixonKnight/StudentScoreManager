
namespace BTL
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTencv = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvChucvu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btnThemcv = new System.Windows.Forms.Button();
            this.btnThoatcv = new System.Windows.Forms.Button();
            this.btnXoacv = new System.Windows.Forms.Button();
            this.btnTimkiemcv = new System.Windows.Forms.Button();
            this.btnSuacv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucvu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức Vụ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(143, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtTencv
            // 
            this.txtTencv.Location = new System.Drawing.Point(125, 37);
            this.txtTencv.Name = "txtTencv";
            this.txtTencv.Size = new System.Drawing.Size(143, 20);
            this.txtTencv.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtTencv);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 83);
            this.panel1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(457, 33);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(457, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Update Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Creat Date";
            // 
            // dgvChucvu
            // 
            this.dgvChucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucvu.Location = new System.Drawing.Point(12, 95);
            this.dgvChucvu.Name = "dgvChucvu";
            this.dgvChucvu.Size = new System.Drawing.Size(657, 183);
            this.dgvChucvu.TabIndex = 7;
            this.dgvChucvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucvu_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnquaylai);
            this.panel2.Controls.Add(this.btnThemcv);
            this.panel2.Controls.Add(this.btnThoatcv);
            this.panel2.Controls.Add(this.btnXoacv);
            this.panel2.Controls.Add(this.btnTimkiemcv);
            this.panel2.Controls.Add(this.btnSuacv);
            this.panel2.Location = new System.Drawing.Point(12, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 51);
            this.panel2.TabIndex = 8;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Location = new System.Drawing.Point(541, 0);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(75, 41);
            this.btnquaylai.TabIndex = 6;
            this.btnquaylai.Text = "Back";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btnThemcv
            // 
            this.btnThemcv.Location = new System.Drawing.Point(329, 0);
            this.btnThemcv.Name = "btnThemcv";
            this.btnThemcv.Size = new System.Drawing.Size(75, 41);
            this.btnThemcv.TabIndex = 5;
            this.btnThemcv.Text = "Thêm";
            this.btnThemcv.UseVisualStyleBackColor = true;
            this.btnThemcv.Click += new System.EventHandler(this.btnThemcv_Click);
            // 
            // btnThoatcv
            // 
            this.btnThoatcv.Location = new System.Drawing.Point(432, 0);
            this.btnThoatcv.Name = "btnThoatcv";
            this.btnThoatcv.Size = new System.Drawing.Size(75, 41);
            this.btnThoatcv.TabIndex = 4;
            this.btnThoatcv.Text = "Thoát";
            this.btnThoatcv.UseVisualStyleBackColor = true;
            this.btnThoatcv.Click += new System.EventHandler(this.btnThoatcv_Click);
            // 
            // btnXoacv
            // 
            this.btnXoacv.Location = new System.Drawing.Point(220, 0);
            this.btnXoacv.Name = "btnXoacv";
            this.btnXoacv.Size = new System.Drawing.Size(75, 41);
            this.btnXoacv.TabIndex = 2;
            this.btnXoacv.Text = "Xóa";
            this.btnXoacv.UseVisualStyleBackColor = true;
            this.btnXoacv.Click += new System.EventHandler(this.btnXoacv_Click);
            // 
            // btnTimkiemcv
            // 
            this.btnTimkiemcv.Location = new System.Drawing.Point(106, 0);
            this.btnTimkiemcv.Name = "btnTimkiemcv";
            this.btnTimkiemcv.Size = new System.Drawing.Size(75, 41);
            this.btnTimkiemcv.TabIndex = 1;
            this.btnTimkiemcv.Text = "Tìm kiếm";
            this.btnTimkiemcv.UseVisualStyleBackColor = true;
            this.btnTimkiemcv.Click += new System.EventHandler(this.btnTimkiemcv_Click);
            // 
            // btnSuacv
            // 
            this.btnSuacv.Location = new System.Drawing.Point(0, 0);
            this.btnSuacv.Name = "btnSuacv";
            this.btnSuacv.Size = new System.Drawing.Size(75, 41);
            this.btnSuacv.TabIndex = 0;
            this.btnSuacv.Text = "Sửa";
            this.btnSuacv.UseVisualStyleBackColor = true;
            this.btnSuacv.Click += new System.EventHandler(this.btnSuacv_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvChucvu);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucvu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTencv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChucvu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoatcv;
        private System.Windows.Forms.Button btnXoacv;
        private System.Windows.Forms.Button btnTimkiemcv;
        private System.Windows.Forms.Button btnSuacv;
        private System.Windows.Forms.Button btnThemcv;
        private System.Windows.Forms.Button btnquaylai;
    }
}

