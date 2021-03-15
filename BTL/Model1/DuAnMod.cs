using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL.Object1;
using System.Data;
using System.Data.SqlClient;

namespace BTL.Model1
{
    class DuAnMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select *from tblDuAn";
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
        //add data
        public bool AddData(DuAnObj daObj)
        {
            //cmd.CommandText = "Insert into tblDuAn values ('" + daObj.Mada + "','" + daObj.Manv + "',N'" + daObj.Tenda + "',N'" + daObj.Tencty + "','" + daObj.Ngaybdda + "','" + daObj.Ngayktda + "','" + daObj.Ngaytao + "','" + daObj.Ngaycapnhat + "')";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_insert_project";
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", daObj.Mada);
                cmd.Parameters.AddWithValue("@idNv", daObj.Manv);
                cmd.Parameters.AddWithValue("@tenDA", daObj.Tenda);
                cmd.Parameters.AddWithValue("@tenCtyDoiTac", daObj.Tencty);
                cmd.Parameters.AddWithValue("@thoiGianbd", daObj.Ngaybdda);
                cmd.Parameters.AddWithValue("@thoiGiankt", daObj.Ngayktda);
                cmd.Parameters.AddWithValue("@createdDate", daObj.CreatedDate);
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
        public bool UpdData(DuAnObj daObj)
        {

            //cmd.CommandText = "Update tblDuAn set id = '" + daObj.Mada + "',idNV = '" + daObj.Manv + "',tenDA = N'" + daObj.Tenda + "',tenCtyDoiTac = N'" + daObj.Tencty + "',thoiGianBatDau = '" + daObj.Ngaybdda + "',thoiGianKetThuc = '" + daObj.Ngayktda + "',createdDate = '" + daObj.Ngaytao + "',updateDate = '" + daObj.Ngaycapnhat + "' where id = '" + daObj.Mada + "' ";
            //cmd.CommandText = "Update tblDuAn set id = '" + daObj.Mada + "',idNV = '" + daObj.Manv + "',tenDA = N'" + daObj.Tenda + "',tenCtyDoiTac = N'" + daObj.Tencty + "',thoiGianBatDau = '" + daObj.Ngaybdda + "',thoiGianKetThuc = '" + daObj.Ngayktda + "',createdDate = '" + daObj.CreatedDate + "',updateDate = '" + daObj.UpdateDate + "' where id = '" + daObj.Mada + "' ";
            //cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_update_project";
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", daObj.Mada);
                cmd.Parameters.AddWithValue("@idNv", daObj.Manv);
                cmd.Parameters.AddWithValue("@tenDA", daObj.Tenda);
                cmd.Parameters.AddWithValue("@tenCtyDoiTac", daObj.Tencty);
                cmd.Parameters.AddWithValue("@thoiGianbd", daObj.Ngaybdda);
                cmd.Parameters.AddWithValue("@thoiGiankt", daObj.Ngayktda);
                cmd.Parameters.AddWithValue("@updateDate", daObj.UpdateDate);
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
        public bool DelData(String idda)
        {

            cmd.CommandText = "delete tblDuAn where id = '" + idda + "' ";
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
