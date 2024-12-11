using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipa.firm
{
    public class Subfirm
    {
        string _name;//Наименование подразделения
        string _bossName;//Имя руководителя подразделения
        string _ofcBossName;//Официальное обращение к руководителю
        string _tel;//номер телефона подразделения
        string _email;//Почтовый адрес подразделения
        SbFirmType _tpy;//Тип подразделения
        List<Contact> _conts;//Контакты подразделения
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string BossName
        {
            get => _bossName;
            set => _bossName = value;
        }

        public string OfcBossName
        {
            get => _ofcBossName;
            set => _ofcBossName = value;
        }

        public string Tel
        {
            get => _tel;
            set => _tel = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public SbFirmType Tpy
        {
            get => _tpy;
            set => _tpy = value;
        }


        public Contact GetContact(int index)
        {
            if (index < 0 || index >= CountCont)
                return null;
            return _conts[index];
        }


        public int CountCont
        {
            get
            {
                return _conts.Count;
            }
        }
        public List<Contact> Conts
        {
            get => _conts;
            private set => _conts = value ?? new List<Contact>();
        }


        public void AddContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact), "Контакт не может быть пустым.");
            Conts.Add(contact.Clone());
        }

        public Contact getContact(Contact contactS)
        {
            foreach (Contact con in _conts)
            {
                if (con == contactS)
                {
                    return contactS.Clone();
                }
            }
            return null;
        }


        public bool IsYourType(object type)
        {
            return _tpy != null && _tpy.Equals(type);
        }


        public Subfirm(string name, string email, string tel, string bossName, string ofcBossName, SbFirmType tpy)
        {
            _name = name;
            _email = email;
            _tel = tel;
            _bossName = bossName;
            _ofcBossName = ofcBossName;
            _tpy = tpy;
            _conts = new List<Contact>();
        }


































        public Subfirm(SbFirmType tpy)
        {
            _tpy = tpy;
            _conts = new List<Contact>();
        }
    }



























}





















