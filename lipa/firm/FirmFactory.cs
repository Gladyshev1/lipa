using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipa.firm
{
    public class FirmFactory
    {
        SbFirmType MainSBT;
        private static FirmFactory _instance; // Единственный экземпляр фабрики

        private static readonly Dictionary<string, string> _userFields =
    new Dictionary<string, string>
     {
        { "Field1", "" },
        { "Field2", "" },
        { "Field3", "" },
        { "Field4", "" },
        { "Field5", "" },
        { "Field6", "" }

     };
        
   




        public IReadOnlyDictionary<string, string> UserFields;

        public  FirmFactory(SbFirmType MainSB)
        {

            

            MainSBT = MainSB;
           

        }

        public static FirmFactory Instance(SbFirmType sbFirmType)
        {


            if (_instance == null)
            {
                _instance = new FirmFactory(sbFirmType);
            }
            return _instance;
        }


        public void SetUserFieldName(string key, string newName)
        {
            if (!_userFields.ContainsKey(key))
                throw new ArgumentException($"Пользовательское поле с ключом {key} не найдено.");

            if (string.IsNullOrWhiteSpace(newName))
                throw new ArgumentException("Название поля не может быть пустым.");

            _userFields[key] = newName;
        }



        public Firm CreateFirm(string name, string email, string town,string PostInx, string country, string street, string region, string web, DateTime dateIn)
        {

            Firm Firm1= new Firm(name, email, town, PostInx, country, street, region, web, dateIn);
            Subfirm MAinSB = new Subfirm(MainSBT);
            Firm1.AddSbFirm(MAinSB);

           
            foreach (var kvp in _userFields)
            {

                Firm1.AddField(kvp.Key, kvp.Value);
                
            }


            return Firm1;
        }
        

     


























































        private FirmFactory()
        {





        
        }
        public static int fldCount()
        {
            return _userFields.Count;
        }
        public string fldNameIN(int i)
        {
            var keys = _userFields.Keys.ToArray();
            return keys[i];
        }
    }

    }

































