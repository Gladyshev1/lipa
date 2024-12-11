using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipa.firm
{
    public class SbFirmTypeCol : IEnumerable<SbFirmType>
    {
        private List<SbFirmType> _list = new List<SbFirmType>();
        private int _currentIndex = -1;

        public int Count => _list.Count;

        public SbFirmType Current => _list[_currentIndex];

        public SbFirmType this[int index] => _list[index];

        public void Add(SbFirmType type)
        {
            if (!_list.Contains(type))
            {
                _list.Add(type);
                _currentIndex++;
            }
            else
            {
                throw new ArgumentException("Тип уже существует.");
            }
        }

        public IEnumerator<SbFirmType> GetEnumerator()
        {
            return new SbFirmTypeEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class SbFirmTypeEnumerator : IEnumerator<SbFirmType>
        {
            private readonly SbFirmTypeCol _collection;
            private int _index = -1;

            public SbFirmTypeEnumerator(SbFirmTypeCol collection)
            {
                _collection = collection;
            }

            public SbFirmType Current => _collection[_index];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                _index++;
                return _index < _collection.Count;
            }

            public void Reset()
            {
                _index = -1;
            }

            public void Dispose()
            {

            }
        }
    }
}
