using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;

namespace lipa.field
{
    internal class Countcontfield : field1
    {

        public Countcontfield(){
       header = "Количество контактов";
            isstr = false;
        }
        

        public override string GetValue(Firm firm)
        {
            return firm.CountCont().ToString();
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new CountContRule((int)filter, mode);
        //}

        public override field1 Clone()
        {
            Countcontfield temp = new Countcontfield();
            return temp;
        }
    }
}
