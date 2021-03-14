
namespace BTL
{
    partial class ManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangerEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.managerSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.managerPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.managerProject = new System.Windows.Forms.ToolStripMenuItem();
            this.managerComplain = new System.Windows.Forms.ToolStripMenuItem();
            this.managerDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.managerWordkingProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePassword,
            this.Exit});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // changePassword
            // 
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(145, 22);
            this.changePassword.Text = "Đổi mật khẩu";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(145, 22);
            this.Exit.Text = "Đăng xuất";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mangerEmp,
            this.managerSalary,
            this.managerPosition,
            this.managerProject,
            this.managerComplain,
            this.managerDepartment,
            this.managerWordkingProcess});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mangerEmp
            // 
            this.mangerEmp.Name = "mangerEmp";
            this.mangerEmp.Size = new System.Drawing.Size(215, 22);
            this.mangerEmp.Text = "Quản lý nhân viên";
            this.mangerEmp.Click += new System.EventHandler(this.mangerEmp_Click);
            // 
            // managerSalary
            // 
            this.managerSalary.Name = "managerSalary";
            this.managerSalary.Size = new System.Drawing.Size(215, 22);
            this.managerSalary.Text = "Quản lý lương";
            this.managerSalary.Click += new System.EventHandler(this.managerSalary_Click);
            // 
            // managerPosition
            // 
            this.managerPosition.Name = "managerPosition";
            this.managerPosition.Size = new System.Drawing.Size(215, 22);
            this.managerPosition.Text = "Quản lý chức vụ";
            this.managerPosition.Click += new System.EventHandler(this.managerPosition_Click);
            // 
            // managerProject
            // 
            this.managerProject.Name = "managerProject";
            this.managerProject.Size = new System.Drawing.Size(215, 22);
            this.managerProject.Text = "Quản lý dự án";
            this.managerProject.Click += new System.EventHandler(this.managerProject_Click);
            // 
            // managerComplain
            // 
            this.managerComplain.Name = "managerComplain";
            this.managerComplain.Size = new System.Drawing.Size(215, 22);
            this.managerComplain.Text = "Quản lý khiếu nại";
            this.managerComplain.Click += new System.EventHandler(this.managerComplain_Click);
            // 
            // managerDepartment
            // 
            this.managerDepartment.Name = "managerDepartment";
            this.managerDepartment.Size = new System.Drawing.Size(215, 22);
            this.managerDepartment.Text = "Quản lý phòng ban";
            this.managerDepartment.Click += new System.EventHandler(this.managerDepartment_Click);
            // 
            // managerWordkingProcess
            // 
            this.managerWordkingProcess.Name = "managerWordkingProcess";
            this.managerWordkingProcess.Size = new System.Drawing.Size(215, 22);
            this.managerWordkingProcess.Text = "Quản lý quá trình công tác";
            this.managerWordkingProcess.Click += new System.EventHandler(this.managerWordkingProcess_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 24);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1023, 426);
            this.pnlContent.TabIndex = 3;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangerEmp;
        private System.Windows.Forms.ToolStripMenuItem managerSalary;
        private System.Windows.Forms.ToolStripMenuItem managerPosition;
        private System.Windows.Forms.ToolStripMenuItem managerProject;
        private System.Windows.Forms.ToolStripMenuItem managerComplain;
        private System.Windows.Forms.ToolStripMenuItem managerDepartment;
        private System.Windows.Forms.ToolStripMenuItem managerWordkingProcess;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
    }
}