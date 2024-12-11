using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.field;
using lipa.firm;

namespace lipa
{
    internal class firmVw
    {
        private List<field1> fields;

        
        public firmVw UpdateFlags(ref List<bool> flags)
        {
            return new firmVw(flags);
        }
        
            public firmVw(List<bool> flags)
            {
                fields = new List<field1>();

                if (flags[0]) fields.Add(new namefield());
                if (flags[1]) fields.Add(new Regionfield());
                if (flags[2]) fields.Add(new Townfield());
                if (flags[3]) fields.Add(new Postinxfield());
                if (flags[4]) fields.Add(new Dateinfield());
                if (flags[5]) fields.Add(new EmailField());
                if (flags[6]) fields.Add(new Webfield());
                if (flags[7]) fields.Add(new Datebegfield());
                if (flags[8]) fields.Add(new Countcontfield());

                for (int i = 0; i < FirmFactory.fldCount(); i++)
                {
                    if (flags[9 + i]) // Предполагается, что это условие для UsrField
                    {
                        fields.Add(new Usrfield(i));
                    }
                }

            if (flags[15]) fields.Add(new Evenfield()); // Если необходимо добавить EvenField

            }

        
            public string[] GetData(Firm firm)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < fields.Count; i++)
            {
                
                    result.Add(fields[i].GetValue(firm));
                
            }
            return result.ToArray();
        }
        public List<string>  getheaders()
        {
            List<string> result = new List<string>();

            for (int i = 0; i < fields.Count; i++)
            {

                result.Add(fields[i].Header);

            }
            return result;
        }
        public List<bool> getisstrs()
        {
            List<bool> result = new List<bool>();

            for (int i = 0; i < fields.Count; i++)
            {

                result.Add(fields[i].isStr);

            }
            return result;
        }
        public int getCfield()
        {
            return fields.Count;
        }


    }
}
