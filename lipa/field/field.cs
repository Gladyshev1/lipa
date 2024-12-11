
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa.field
{
    public abstract class field1
    {
        protected string header = "";
        protected bool isstr = true;


        public bool isStr
        {
            get { return isstr; }
        }
        public string Header
        {
            get { return header; }
        }
        public abstract string GetValue(Firm firm);
        //public abstract FilterRule CreateRule(object filter, int mode);
        public abstract field1 Clone();
    }
}
