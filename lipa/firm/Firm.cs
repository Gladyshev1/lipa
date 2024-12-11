using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipa.firm
{
    public class Firm
    {
        string _name; //Наименование фирмы
        string _country;//Страна
        string _region;//Регион (область)
        string _town;//Город
        string _street;//Улица
        string _postInx;//Почтовый индекс
        
        DateTime _dateIn;//Дата ввода фирмы (начало взаимоотноше-ний)
        string _email;//Почтовый адрес фирмы
        string _web;//URL-адрес сайта
        List<Subfirm> _sbFirms;//Подразделения фирмы
        Dictionary<string, string> _usrFields;//Пользовательские поля
         int maxcountFlds = FirmFactory.fldCount();
        public string Name
        {
            get => _name;
            set => _name = value;
        }



        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string Region
        {
            get => _region;
            set => _region = value;
        }


        public string Town
        {
            get => _town;
            set => _town = value;
        }
        public Subfirm GetMain()
        {
            return _sbFirms[0];
        }
        public string Street
        {
            get => _street;
            set => _street = value;
        }

        public string PostInx
        {
            get => _postInx;
            set => _postInx = value;
        }



        public DateTime DateIn
        {
            get => _dateIn;
            set => _dateIn = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string Web
        {
            get => _web;
            set => _web = value;
        }
        public List<Contact> contacts
        {
            get; set;
        }





        public int SbFirmsCount
        {
            get { return _sbFirms.Count; }
        }





        public Subfirm this[int index]
        {
            get { return _sbFirms[index]; }
            set { _sbFirms[index] = value; }
        }



        public void AddCont(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact), "Контакт не может быть нулевым.");

            if (_sbFirms.Count > 0)
                _sbFirms[0].AddContact(contact); // Добавляет в первую субфирму
        }

        public void AddContToSbFirm(Contact contact, string NamesubFirm)
        {
            foreach (Subfirm sbFirm in _sbFirms)
            {
                if (sbFirm.Name == NamesubFirm)
                {
                    sbFirm.AddContact(contact.Clone());
                }
            }

        }

        public void AddField(string name, string value)
        {
            if (_usrFields.Count < maxcountFlds)
            {
                _usrFields.Add(name, value);
            }
            else
            {
                throw new InvalidOperationException($"Cannot add more than {maxcountFlds} fields.");
            }
        }




        public void AddSbFirm(Subfirm sbFirm)
        {
            if (sbFirm == null)
                throw new ArgumentNullException(nameof(sbFirm), "Субфирма не может быть null.");

            _sbFirms.Add(sbFirm);
        }


        public string GetField(int index)
        {
            string key = "Field" + index.ToString();
            if (_usrFields.ContainsKey(key))
                return _usrFields[key];
            return default;
        }
        public int CountCont()
        {
            int result = 0;
            for (int i = 0; i < this._sbFirms.Count; i++)
            {
                result += _sbFirms[i].CountCont;
            }
            return result;
        }


        public Firm(string name, string email, string town, string PostInx, string country, string street, string region, string web, DateTime dateIn)
        {
            _name = name;
            _email = email;
            _town = town;
            _postInx = PostInx;
            _country = country;
            _street = street;
            _region = region;
            _web = web;
            _dateIn = dateIn;
            _sbFirms = new List<Subfirm>();
            _usrFields = new Dictionary<string, string>();
        }


        public string GetField(string key)
        {
            return _usrFields[key];
        }



        public void RenameField(string oldName, string newName)
        {
            if (!_usrFields.ContainsKey(oldName))
                throw new InvalidOperationException($"Поле {oldName} не существует.");

            string value = _usrFields[oldName];
            _usrFields.Remove(oldName);
            _usrFields[newName] = value;
        }

        public void setField(string field, string value)
        {
            _usrFields.Remove(field);
            _usrFields.Add(field, value);
        }




        public List<Contact> GetContacts(ContType T)
        {

            List<Contact> filteredContacts = new List<Contact>();

            foreach (Subfirm subfirm in _sbFirms)
            {

                foreach (Contact contact in subfirm.Conts)
                {

                    if (ReferenceEquals(contact.CntType, T))
                    {
                        filteredContacts.Add(contact.Clone());
                    }
                }
            }


            return filteredContacts;
        }


        public Contact GetContactS(Contact T)
        {

            foreach (Subfirm subfirm in _sbFirms)
            {

                foreach (Contact contact1 in subfirm.Conts)
                {

                    if (contact1 == T)
                    {
                        return contact1.Clone();
                    }
                }
            }


            return null;
        }




        public Subfirm FindSbByName(string Name)
        {
            foreach (Subfirm sbFirm in _sbFirms)
            {
                if (sbFirm.Tpy.Name == Name)
                {
                    return sbFirm;
                }
            }

            return null;
        }
        public Subfirm FindSbByType(SbFirmType Type)
        {
            foreach (Subfirm sbFirm in _sbFirms)
            {
                if (ReferenceEquals(Type, sbFirm.Tpy))
                {
                    return sbFirm;
                }
            }
            return null;

        }

        public Contact getContactM(Contact contactS)
        {
            foreach (Contact con in _sbFirms[0].Conts)
            {
                if (con == contactS)
                {
                    return contactS.Clone();
                }
            }
            return null;
        }


    }
}
