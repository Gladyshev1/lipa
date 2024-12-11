
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa.field
{
    internal class Countryfield:field1
    {
        public Countryfield()
        {
            header = "страна";
        }

       
        public override string GetValue(Firm firm)
        {
            return firm.Country;
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new CountryRule((string)filter, mode);
        //}

        public override field1 Clone()
        {
            Countryfield temp = new Countryfield();
            return temp;
        }
    }
}
