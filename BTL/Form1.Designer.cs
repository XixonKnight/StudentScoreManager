
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.managerComplain = new System.Windows.Forms.ToolStripMenuItem();
            this.managerSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.managerProject = new System.Windows.Forms.ToolStripMenuItem();
            this.managerWorkingProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.managerDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.managerPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.managerReport = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.managerReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.changePassword.Size = new System.Drawing.Size(180, 22);
            this.changePassword.Text = "Đổi mật khẩu";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Đăng xuất";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerEmp,
            this.managerComplain,
            this.managerSalary,
            this.managerProject,
            this.managerWorkingProcess,
            this.managerDepartment,
            this.managerPosition});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // managerEmp
            // 
            this.managerEmp.Name = "managerEmp";
            this.managerEmp.Size = new System.Drawing.Size(215, 22);
            this.managerEmp.Text = "Quản lý nhân viên";
            // 
            // managerComplain
            // 
            this.managerComplain.Name = "managerComplain";
            this.managerComplain.Size = new System.Drawing.Size(215, 22);
            this.managerComplain.Text = "Quản lý khiểu nại";
            // 
            // managerSalary
            // 
            this.managerSalary.Name = "managerSalary";
            this.managerSalary.Size = new System.Drawing.Size(215, 22);
            this.managerSalary.Text = "Quản lý lương";
            // 
            // managerProject
            // 
            this.managerProject.Name = "managerProject";
            this.managerProject.Size = new System.Drawing.Size(215, 22);
            this.managerProject.Text = "Quản lý dự án";
            // 
            // managerWorkingProcess
            // 
            this.managerWorkingProcess.Name = "managerWorkingProcess";
            this.managerWorkingProcess.Size = new System.Drawing.Size(215, 22);
            this.managerWorkingProcess.Text = "Quản lý quá trình công tác";
            // 
            // managerDepartment
            // 
            this.managerDepartment.Name = "managerDepartment";
            this.managerDepartment.Size = new System.Drawing.Size(215, 22);
            this.managerDepartment.Text = "Quản lý phòng ban";
            // 
            // managerPosition
            // 
            this.managerPosition.Name = "managerPosition";
            this.managerPosition.Size = new System.Drawing.Size(215, 22);
            this.managerPosition.Text = "Quản lý chức vụ";
            // 
            // managerReport
            // 
            this.managerReport.Name = "managerReport";
            this.managerReport.Size = new System.Drawing.Size(61, 20);
            this.managerReport.Text = "Báo cáo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.Text = "FormManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem managerEmp;
        private System.Windows.Forms.ToolStripMenuItem managerComplain;
        private System.Windows.Forms.ToolStripMenuItem managerSalary;
        private System.Windows.Forms.ToolStripMenuItem managerProject;
        private System.Windows.Forms.ToolStripMenuItem managerWorkingProcess;
        private System.Windows.Forms.ToolStripMenuItem managerDepartment;
        private System.Windows.Forms.ToolStripMenuItem managerPosition;
        private System.Windows.Forms.ToolStripMenuItem managerReport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

