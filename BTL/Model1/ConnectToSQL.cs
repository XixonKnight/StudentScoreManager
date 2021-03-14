using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BTL.Model1
{
    class ConnectToSQL
    {
        #region Availible
        private SqlConnection Conn;
        private SqlCommand cmd;

        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlConnection Connection { get { return Conn; } }



        private string error;
        public string Error { get => error; set => error = value; }

        string StrCon;
        #endregion
        #region Contructor
        public ConnectToSQL()
        {
            StrCon = @"Data Source=DESKTOP-GTE0HHE\MSSQLSERVER01;Initial Catalog=QLy_NhanVien;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
        }
        #endregion
        #region Methods
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
    }
}
#endregion