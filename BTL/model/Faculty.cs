using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
    class Faculty
    {
        public int id { get; set; }
        public string facultyCode { get; set; }
        public string facultyName { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int foundedYear { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}
