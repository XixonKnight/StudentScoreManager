using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        FormChucvu f = new FormChucvu();

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChucvu f = Program.FindOpenForm("FormChucvu") as FormChucvu;
            if (f == null)
                f = new FormChucvu();
            f.MdiParent = this;
            f.Show();
            f.Activate();
        }
    }
}
