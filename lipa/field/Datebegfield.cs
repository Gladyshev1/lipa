
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa.field
{
    internal class Datebegfield : field1
    {
        public Datebegfield() {
        header = "Дата начала работы";
            isstr = false;
    }
       
        public override string GetValue(Firm firm)
        {
            if (firm[0].CountCont > 0)
            {
                return firm[0].GetContact(firm[0].CountCont - 1).BeginDate.ToString("dd.MM.yyyy");
            }
            return null;
        }

        public string GetValue(Firm firm, int index)
        {
            if (firm[0].CountCont > 0)
            {
                if (index >= 0 && index < firm[0].CountCont)
                {
                    return firm[0].GetContact(index).BeginDate.ToString("dd.MM.yyyy");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index");
                }
            }
            return null;
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new DateBegRule((DateTime)filter, mode);
        //}

        public override field1 Clone()
        {
            Datebegfield temp = new Datebegfield();
            return temp;
        }
    }
}
