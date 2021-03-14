using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BTL.Model1;
using BTL.Object1;


namespace BTL.Control1
{
    class DuAnCtrl
    {
        DuAnMod daMod = new DuAnMod();
        public DataTable GetData()
        {
            return daMod.GetData();
        }
        public bool addData(DuAnObj daObj)
        {
            return daMod.AddData(daObj);
        }
        public bool updData(DuAnObj daObj)
        {
            return daMod.UpdData(daObj);
        }
        public bool delData(string ma)
        {
            return daMod.DelData(ma);
        }
    }
}
