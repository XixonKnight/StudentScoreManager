using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.model
{
    class Project
    {
        public int id { get; set; }
        public int idEmp { get; set; }
        public string projectName{ get; set; }
        public string partnerCompanies{ get; set; }
        public DateTime effectiveDate{ get; set; }
        public DateTime expirateDate{ get; set; }
        public DateTime createDate{ get; set; }
        public DateTime updateDate{ get; set; }
    }
}
