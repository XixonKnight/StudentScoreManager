﻿
namespace BTL
{
    partial class FormPhongban
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenpb = new System.Windows.Forms.TextBox();
            this.txtIdpb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhongban = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoapb = new System.Windows.Forms.Button();
            this.btnTimkiempb = new System.Windows.Forms.Button();
            this.btnThempb = new System.Windows.Forms.Button();
            this.btnSuapb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongban)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenpb);
            this.panel1.Controls.Add(this.txtIdpb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtTenpb
            // 
            this.txtTenpb.Location = new System.Drawing.Point(512, 22);
            this.txtTenpb.Name = "txtTenpb";
            this.txtTenpb.Size = new System.Drawing.Size(204, 20);
            this.txtTenpb.TabIndex = 5;
            // 
            // txtIdpb
            // 
            this.txtIdpb.Location = new System.Drawing.Point(121, 22);
            this.txtIdpb.Name = "txtIdpb";
            this.txtIdpb.Size = new System.Drawing.Size(204, 20);
            this.txtIdpb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // dgvPhongban
            // 
            this.dgvPhongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongban.Location = new System.Drawing.Point(12, 119);
            this.dgvPhongban.Name = "dgvPhongban";
            this.dgvPhongban.Size = new System.Drawing.Size(744, 150);
            this.dgvPhongban.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuaylai);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoapb);
            this.panel2.Controls.Add(this.btnTimkiempb);
            this.panel2.Controls.Add(this.btnThempb);
            this.panel2.Controls.Add(this.btnSuapb);
            this.panel2.Location = new System.Drawing.Point(12, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(641, 30);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(75, 44);
            this.btnQuaylai.TabIndex = 5;
            this.btnQuaylai.Text = "Back";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(506, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 44);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoapb
            // 
            this.btnXoapb.Location = new System.Drawing.Point(392, 30);
            this.btnXoapb.Name = "btnXoapb";
            this.btnXoapb.Size = new System.Drawing.Size(75, 44);
            this.btnXoapb.TabIndex = 3;
            this.btnXoapb.Text = "Xóa";
            this.btnXoapb.UseVisualStyleBackColor = true;
            this.btnXoapb.Click += new System.EventHandler(this.btnXoapb_Click);
            // 
            // btnTimkiempb
            // 
            this.btnTimkiempb.Location = new System.Drawing.Point(279, 30);
            this.btnTimkiempb.Name = "btnTimkiempb";
            this.btnTimkiempb.Size = new System.Drawing.Size(75, 44);
            this.btnTimkiempb.TabIndex = 2;
            this.btnTimkiempb.Text = "Tìm kiếm";
            this.btnTimkiempb.UseVisualStyleBackColor = true;
            this.btnTimkiempb.Click += new System.EventHandler(this.btnTimkiempb_Click);
            // 
            // btnThempb
            // 
            this.btnThempb.Location = new System.Drawing.Point(157, 30);
            this.btnThempb.Name = "btnThempb";
            this.btnThempb.Size = new System.Drawing.Size(75, 44);
            this.btnThempb.TabIndex = 1;
            this.btnThempb.Text = "Thêm";
            this.btnThempb.UseVisualStyleBackColor = true;
            this.btnThempb.Click += new System.EventHandler(this.btnThempb_Click);
            // 
            // btnSuapb
            // 
            this.btnSuapb.Location = new System.Drawing.Point(33, 31);
            this.btnSuapb.Name = "btnSuapb";
            this.btnSuapb.Size = new System.Drawing.Size(75, 44);
            this.btnSuapb.TabIndex = 0;
            this.btnSuapb.Text = "Sửa";
            this.btnSuapb.UseVisualStyleBackColor = true;
            this.btnSuapb.Click += new System.EventHandler(this.btnSuapb_Click);
            // 
            // FormPhongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPhongban);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhongban";
            this.Text = "FormPhongban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPhongban_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongban)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenpb;
        private System.Windows.Forms.TextBox txtIdpb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhongban;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoapb;
        private System.Windows.Forms.Button btnTimkiempb;
        private System.Windows.Forms.Button btnThempb;
        private System.Windows.Forms.Button btnSuapb;
    }
}