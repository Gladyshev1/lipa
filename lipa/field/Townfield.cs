
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa.field
{
    internal class Townfield : field1
    {
        public Townfield() {
         header = "Город";
    }
       
        public override string GetValue(Firm firm)
        {
            return firm.Town;
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new TownRule((string)filter, mode);
        //}

        public override field1 Clone()
        {
            Townfield temp = new Townfield();
            return temp;
        }
    }
}
