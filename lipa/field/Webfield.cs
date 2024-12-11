
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa.field
{
    internal class Webfield : field1
    {
        public Webfield() {
        header = "Сайт";
    }
        
        public override string GetValue(Firm firm)
        {
            return firm.Web;
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new WebRule((string)filter, mode);
        //}

        public override field1 Clone()
        {
            Webfield temp = new Webfield();
            return temp;
        }
    }
}
