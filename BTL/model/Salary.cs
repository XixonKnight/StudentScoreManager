using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
   public class Salary
    {
        public int id { get; set; }
        public int idEmp { get; set; }
        public float basicSalary { get; set; }
        public float coefSalary { get; set; }
        public float allowance { get; set; }
        public int workeHours { get; set; }
        public int overtimeHours { get; set; }
        public float bonus { get; set; }
        public string socialInsurance{ get; set; }
        public string heatlhInsurance{ get; set; }
        public DateTime createdDate{ get; set; }
        public DateTime updateDate{ get; set; }
    }
}
