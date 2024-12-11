using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa;

using lipa.firm;

namespace lipa.field
{
    internal class EmailField : field1
    {
        public EmailField() {
       header = "Почта";
    }
        public string Header
        {
            get { return header; }
        }
        // функция для заполнений конкретных полей по данным фирмы
        public override string GetValue(Firm firm)
        {
            return firm.Email;
        }

        //public override FilterRule CreateRule(object filter, int mode)
        //{
        //    return new EmailRule((string)filter, mode);
        //}

        public override field1 Clone()
        {
            EmailField temp = new EmailField();
            return temp;
        }
    }
}