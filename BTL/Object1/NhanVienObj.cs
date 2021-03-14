using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Object1
{
    class NhanVienObj
    {
        string ten, cmnd, gioitinh, email, sdt, que, trinhdohocvan;
        String ngaysinh, ngaykyhopdong, hanhopdong, createddate, updatedate;
        String idnv, idpb, idchucvu;
        String hsl;

        public string Ten { get => ten; set => ten = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Que { get => que; set => que = value; }
        public string Trinhdohocvan { get => trinhdohocvan; set => trinhdohocvan = value; }
        public String Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public String Ngaykyhopdong { get => ngaykyhopdong; set => ngaykyhopdong = value; }
        public String Hanhopdong { get => hanhopdong; set => hanhopdong = value; }
        public String Createddate { get => createddate; set => createddate = value; }
        public String Updatedate { get => updatedate; set => updatedate = value; }
        public String Idnv { get => idnv; set => idnv = value; }
        public String Idpb { get => idpb; set => idpb = value; }
        public String Idchucvu { get => idchucvu; set => idchucvu = value; }
        public String Hsl { get => hsl; set => hsl = value; }

        public NhanVienObj()
        {

        }

        public NhanVienObj(string idnv, string idpb, string idchucvu, string ten, string cmnd, string ngaysinh, string gioitinh, string email, string sdt, string que, string trinhdohocvan, string ngaykyhopdong, string hanhopdong, string hsl, string createddate, string updatedate)
        {
            this.idnv = idnv;
            this.idpb = idpb;
            this.idchucvu = idchucvu;
            this.ten = ten;
            this.cmnd = cmnd;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.email = email;
            this.sdt = sdt;
            this.que = que;
            this.trinhdohocvan = trinhdohocvan;
            this.ngaykyhopdong = ngaykyhopdong;
            this.hanhopdong = hanhopdong;
            this.hsl = hsl;
            this.createddate = createddate;
            this.updatedate = updatedate;
        }
    }
}
