
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa.field
{
    internal class Dateinfield : field1
    {

        public Dateinfield() {
         header = "Дата начала контакта";
            isstr = false;
        }
        
        public override string GetValue(Firm firm)
        {
            return firm.DateIn.ToString("dd.MM.yyyy");
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new DateInRule((DateTime)filter, mode);
        //}

        public override field1 Clone()
        {
            Dateinfield temp = new Dateinfield();
            return temp;
        }
    }
}
