using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BTL.Model1;
using BTL.Object1;
using System.Data.SqlClient;
using BTL.configDB;

namespace BTL.Control1
{
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable getData()
        {
            return nvMod.GetData();
        }
        public bool addData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool updData(NhanVienObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }
        public bool delData(string ma)
        {
            return nvMod.DelData(ma);
        }

        public DataTable getDataEmp()
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                string query = "select nv.idNV,nv.tenNV from tblNhanVien nv";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
                {

                    dataAdapter.Fill(dataSet, "Emp");
                }
                conn.Close();
            }
            return dataSet.Tables["Emp"];
        }
    }
}
