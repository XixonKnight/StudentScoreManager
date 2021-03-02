using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
    class Subject
    {
        public int id { get; set; }
        public string subjectCode { get; set; }
        public string subjectName { get; set; }
        public int numberOfCredits { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}
