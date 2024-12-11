using lipa.firm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipa.field
{
    internal class Regionfield : field1
    {
        public Regionfield() {
         header = "Регион";
    }

        public override string GetValue(Firm firm)
        {
            return firm.Region;
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new RegionRule((string)filter, mode);
        //}

        public override field1 Clone()
        {
            Regionfield temp = new Regionfield();
            return temp;
        }
    }
}
