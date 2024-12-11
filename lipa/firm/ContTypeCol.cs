using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipa.firm
{
    public class ContTypeCol
    {
        private List<ContType> _lst;

        public ContTypeCol()
        {
            _lst = new List<ContType>();
        }


        public int Count => _lst.Count;
        public ContType this[int index] => _lst[index];
        public void Add(ContType item)
        {
            if (!_lst.Contains(item))
            {
                _lst.Add(item);
            }
            else
            {
                throw new ArgumentException("Тип уже существует.");
            }
        }

        public void Clear()
        {
            _lst.Clear();
        }
    }
}
