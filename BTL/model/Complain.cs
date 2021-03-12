using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
    public class Complain
    {
        public int id { get; set; }
        public int idEmp { get; set; }
        public string nameComplain { get; set; }
        public string nameEmp { get; set; }
        public string reason { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}
