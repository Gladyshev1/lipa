using lipa.firm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipa.field
{
    internal class Evenfield:field1
    {
        public Evenfield()
        {
            header = "чет";
        }

        public override string GetValue(Firm firm)
        {

            if (firm.CountCont() % 2 == 0)
            {
             
                return "чет";


            }
            else { return "нечет"; }
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
