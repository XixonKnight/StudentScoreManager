using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
    class Employee
    {
        public int id { get; set; }
        public int idDepartment { get; set; }
        public int idPos { get; set; }
        public string fullName { get; set; }
        public string cmnd { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool gender { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string academicLevel { get; set; }
        public DateTime contactSignDate { get; set; }
        public DateTime contactExpirationDate { get; set; }
        public string wage { get; set; }
        public string coefSalary { get; set; }
        public DateTime createdDate { get; set; }
        public string updateDate { get; set; }
        
    }
}
