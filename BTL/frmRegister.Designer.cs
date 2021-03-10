
namespace BTL
{
    partial class frmRegister
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
            this.pas = new System.Windows.Forms.Label();
            this.txtCreateUsername = new System.Windows.Forms.TextBox();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.btnCreateRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản:";
            // 
            // pas
            // 
            this.pas.AutoSize = true;
            this.pas.Location = new System.Drawing.Point(33, 95);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(55, 13);
            this.pas.TabIndex = 2;
            this.pas.Text = "Mật khẩu:";
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Location = new System.Drawing.Point(124, 56);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(184, 20);
            this.txtCreateUsername.TabIndex = 3;
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(124, 88);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(184, 20);
            this.txtCreatePassword.TabIndex = 4;
            // 
            // btnCreateRegister
            // 
            this.btnCreateRegister.Location = new System.Drawing.Point(150, 130);
            this.btnCreateRegister.Name = "btnCreateRegister";
            this.btnCreateRegister.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRegister.TabIndex = 5;
            this.btnCreateRegister.Text = "Đăng ký";
            this.btnCreateRegister.UseVisualStyleBackColor = true;
            this.btnCreateRegister.Click += new System.EventHandler(this.btnCreateRegister_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 187);
            this.Controls.Add(this.btnCreateRegister);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.txtCreateUsername);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pas;
        private System.Windows.Forms.TextBox txtCreateUsername;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.Button btnCreateRegister;
    }
}