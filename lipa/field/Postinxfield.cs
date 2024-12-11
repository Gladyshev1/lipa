
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa.field
{
    internal class Postinxfield : field1
    {
       public Postinxfield() {
      header = "Почтовый индекс";
    }
      
        public override string GetValue(Firm firm)
        {
            return firm.PostInx;
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new PostIndexRule((string)filter, mode);
        //}

        public override field1 Clone()
        {
            Postinxfield temp = new Postinxfield();
            return temp;
        }
    }
}
