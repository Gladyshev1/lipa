using System;

namespace lipa.firm
{
    public class ContType
    {
        private string _name;
        private string _note;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Note
        {
            get => _note;
            set => _note = value;
        }

        public ContType(string name, string note)
        {
            _name = name;
            _note = note;
        }

        
        public static bool operator ==(ContType a, ContType b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (a is null || b is null)
                return false;

            return a.Name == b.Name && a.Note == b.Note;
        }

       
        public static bool operator !=(ContType a, ContType b)
        {
            return !(a == b);
        }

        
        public override bool Equals(object obj)
        {
            if (obj is ContType other)
            {
                return this == other;
            }
            return false;
        }

       
    }
}