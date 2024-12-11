using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipa.firm
{
    public class SbFirmType
    {
        
        private bool _isMain;
        private string _name;


        public bool IsMain
        {
            get => _isMain;
            set => _isMain = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public SbFirmType(bool isMain, string name)
        {
            _isMain = isMain;
            _name = name;
        }



        public override bool Equals(object obj)
        {
            if (obj is SbFirmType other)
            {
                return (this._isMain==other._isMain && this._name == other._name);
            }
            return false;
        }
        public static bool operator ==(SbFirmType left, SbFirmType  right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }
        public static bool operator !=(SbFirmType left, SbFirmType right)
        {
            return !(left == right);
        }
    }


}
