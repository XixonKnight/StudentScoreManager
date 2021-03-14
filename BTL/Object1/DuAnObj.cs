using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Object1
{
    class DuAnObj
    {
        string mada, tenda, tencty, manv, ngaybdda, ngayktda, ngaytao, ngaycapnhat;

        public string Mada { get => mada; set => mada = value; }
        public string Tenda { get => tenda; set => tenda = value; }
        public string Tencty { get => tencty; set => tencty = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Ngaybdda { get => ngaybdda; set => ngaybdda = value; }
        public string Ngayktda { get => ngayktda; set => ngayktda = value; }
        public string Ngaytao { get => ngaytao; set => ngaytao = value; }
        public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }

        public DuAnObj()
        {

        }
        public DuAnObj(string mada, string tenda, string tencty, string ngaybdda, string ngayktda, string ngaytao, string ngaycapnhat)
        {
            this.mada = mada;
            this.tenda = tenda;
            this.tencty = tencty;
            this.ngaybdda = ngaybdda;
            this.ngayktda = ngayktda;
            this.ngaytao = ngaytao;
            this.ngaycapnhat = ngaycapnhat;
        }
    }
}
