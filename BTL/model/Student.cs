using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
    class Student
    {
        public int id { get; set; }
        public string studentCode { get; set; }
        public string classCode { get; set; }
        public string fullName { get; set; }
        public bool isGender { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string email { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}
