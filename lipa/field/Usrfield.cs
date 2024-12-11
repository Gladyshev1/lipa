
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa.field
{
    internal class Usrfield : field1
    {
      
        
        private int index;
        public Usrfield(int index)
        {
            if (index < FirmFactory.fldCount() && index > -1)
            {
                this.index = index;
                header = $"Поле{index+1}";
            }
            else
                throw new ArgumentOutOfRangeException("index");
        }

        // функция для заполнений конкретных полей по данным фирмы
        public override string GetValue(Firm firm)
        {
            return firm.GetField(index + 1);
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new UsrRule((string)filter, mode);
        //}

        public override field1 Clone()
        {
            Usrfield temp = new Usrfield(index);
            return temp;
        }
    }
}
