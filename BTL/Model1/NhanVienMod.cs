using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BTL.Object1;
using BTL.configDB;
using System.Windows.Forms;

namespace BTL.Model1
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select *from tblNhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(NhanVienObj nvObj)
        {
            //cmd.CommandText = "Insert into tblNhanVien values ('" + nvObj.Idnv + "','" + nvObj.Idpb + "','" + nvObj.Idchucvu + "',N'" + nvObj.Ten + "',N'" + nvObj.Cmnd + "','" + nvObj.Ngaysinh + "',N'" + nvObj.Gioitinh + "','" + nvObj.Email + "','" + nvObj.Sdt + "',N'" + nvObj.Que + "',N'" + nvObj.Trinhdohocvan + "','" + nvObj.Ngaykyhopdong + "','" + nvObj.Hanhopdong + "','" + nvObj.Hsl + "','" + nvObj.Createddate + "','" + nvObj.Updatedate + "')";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pro_inser_emp";
            //cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idnv", nvObj.Idnv);
                cmd.Parameters.AddWithValue("@idPb", nvObj.Idpb);
                cmd.Parameters.AddWithValue("@idChucVu", nvObj.Idchucvu);
                cmd.Parameters.AddWithValue("@tenNV", nvObj.Ten);
                cmd.Parameters.AddWithValue("@cmnd", nvObj.Cmnd);
                cmd.Parameters.AddWithValue("@ngaySinh", nvObj.Ngaysinh);
                cmd.Parameters.AddWithValue("@gioiTinh", nvObj.Gioitinh);
                cmd.Parameters.AddWithValue("@email", nvObj.Email);
                cmd.Parameters.AddWithValue("@sdt", nvObj.Sdt);
                cmd.Parameters.AddWithValue("@quequan", nvObj.Que);
                cmd.Parameters.AddWithValue("@trinhDoHocVan", nvObj.Trinhdohocvan);
                cmd.Parameters.AddWithValue("@ngayKiHopDong", nvObj.Ngaykyhopdong);
                cmd.Parameters.AddWithValue("@hanHopDong", nvObj.Hanhopdong);
                cmd.Parameters.AddWithValue("@heSoLuong", nvObj.Hsl);
                cmd.Parameters.AddWithValue("@createdDate", nvObj.CreatedDate);
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool UpdData(NhanVienObj nvObj)
        {
            //cmd.CommandText = "Update tblNhanVien set idNV = '" + nvObj.Idnv + "',idPb = '" + nvObj.Idpb + "',idChucVu = '" + nvObj.Idchucvu + "',tenNV = N'" + nvObj.Ten + "',cmnd = '" + nvObj.Cmnd + "',ngaySinh = '" + nvObj.Ngaysinh + "',gioiTinh = N'" + nvObj.Gioitinh + "',email = N'" + nvObj.Email + "',sdt = '" + nvObj.Sdt + "',queQuan = N'" + nvObj.Que + "',trinhDoHocVan = N'" + nvObj.Trinhdohocvan + "',ngayKiHopDong = '" + nvObj.Ngaykyhopdong + "',hanHopDong = '" + nvObj.Hanhopdong + "',heSoLuong = '" + nvObj.Hsl + "',createdDate = '" + nvObj.Createddate + "',updateDate = '" + nvObj.Updatedate + "' where idNV = '" + nvObj.Idnv + "' ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pro_update_emp";
            //cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idnv", nvObj.Idnv);
                cmd.Parameters.AddWithValue("@idPb", nvObj.Idpb);
                cmd.Parameters.AddWithValue("@idChucVu", nvObj.Idchucvu);
                cmd.Parameters.AddWithValue("@tenNV", nvObj.Ten);
                cmd.Parameters.AddWithValue("@cmnd", nvObj.Cmnd);
                cmd.Parameters.AddWithValue("@ngaySinh", nvObj.Ngaysinh);
                cmd.Parameters.AddWithValue("@gioiTinh", nvObj.Gioitinh);
                cmd.Parameters.AddWithValue("@email", nvObj.Email);
                cmd.Parameters.AddWithValue("@sdt", nvObj.Sdt);
                cmd.Parameters.AddWithValue("@quequan", nvObj.Que);
                cmd.Parameters.AddWithValue("@trinhDoHocVan", nvObj.Trinhdohocvan);
                cmd.Parameters.AddWithValue("@ngayKiHopDong", nvObj.Ngaykyhopdong);
                cmd.Parameters.AddWithValue("@hanHopDong", nvObj.Hanhopdong);
                cmd.Parameters.AddWithValue("@heSoLuong", nvObj.Hsl);
                cmd.Parameters.AddWithValue("@updateDate", nvObj.UpdateDate);
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public bool DelData(String idnv)
        {

            cmd.CommandText = "delete tblNhanVien where idNV = '" + idnv + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
