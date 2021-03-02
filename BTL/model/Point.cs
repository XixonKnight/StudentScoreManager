using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
    class Point
    {
        public int id { get; set; }
        public string studentCode { get; set; }
        public string subjectCode { get; set; }
        public float point1st { get; set; }
        public float point2st { get; set; }
        public int studyTimes { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}
