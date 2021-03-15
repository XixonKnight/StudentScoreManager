using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.View1;
namespace BTL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        //public static Form FindOpenForm(String name)
        //{
        //    foreach (Form f in Application.OpenForms)
        //        if (f.GetType().Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            return f;
        //    return null;
        //    Application.Run(new frmLogin());
        //}
    }
}
