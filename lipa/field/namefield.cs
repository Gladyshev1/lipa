
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa.field
{
    internal class namefield : field1
    {
        public namefield() {
        header = "Название";
    }
       
        public override string GetValue(Firm firm)
        {
            return firm.Name;
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new NameRule((string)filter, mode);
        //}

        public override field1 Clone()
        {
            namefield temp = new namefield();
            return temp;
        }

    }
}
