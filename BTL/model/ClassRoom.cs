using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
    class ClassRoom
    {
        public int id { get; set; }
        public string classCode { get; set; }
        public string facultyCode { get; set; }
        public string schoolYearCode { get; set; }
        public string className { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}
