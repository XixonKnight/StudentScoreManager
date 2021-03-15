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
        //public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public bool Gioitinh { get; set; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Que { get => que; set => que = value; }
        public string Trinhdohocvan { get => trinhdohocvan; set => trinhdohocvan = value; }
        //public String Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public DateTime Ngaysinh { get; set; }
        //public String Ngaykyhopdong { get => ngaykyhopdong; set => ngaykyhopdong = value; }
        //public String Hanhopdong { get => hanhopdong; set => hanhopdong = value; }
        //public String Createddate { get => createddate; set => createddate = value; }
        //public String Updatedate { get => updatedate; set => updatedate = value; }
        public DateTime Ngaykyhopdong { get; set; }
        public DateTime Hanhopdong { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        //public String Idnv { get => idnv; set => idnv = value; }
        public int Idnv { get; set; }
        //public String Idpb { get => idpb; set => idpb = value; }
        public int Idpb { get; set; }
        //public String Idchucvu { get => idchucvu; set => idchucvu = value; }
        public int Idchucvu { get; set; }
        //public String Hsl { get => hsl; set => hsl = value; }
        public float Hsl { get; set; }
    }
}
