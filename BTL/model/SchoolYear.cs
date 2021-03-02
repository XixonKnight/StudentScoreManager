using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
    class SchoolYear
    {
        public int id { get; set; }
        public string schoolYearCode { get; set; }
        public string schoolYearName { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}
