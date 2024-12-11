using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace lipa.firm
{
    public class Contact
    {
        private DateTime _beginDt;
        private DateTime _endDt;
        private string _descr;
        private string _dataInfo;
        private ContType _tpy;
        public DateTime BeginDate
        {
            get => _beginDt;
            set => _beginDt = value;
        }


        public DateTime EndDt
        {
            get => _endDt;
            set => _endDt = value;
        }

        public string Descr
        {
            get => _descr;
            set => _descr = value;
        }

        public string DataInfo
        {
            get => _dataInfo;
            set => _dataInfo = value;
        }

        public ContType CntType
        {
            get => _tpy;
            set => _tpy = value;
        }


        
        public Contact Clone()
        {
            return new Contact(this.BeginDate, this.EndDt, this.Descr, this.DataInfo, this.CntType);
        }

        public override bool Equals(object obj)
        {
            if (obj is Contact other)
            {
                return BeginDate == other.BeginDate &&
                       EndDt == other.EndDt &&
                       Descr == other.Descr &&
                       DataInfo == other.DataInfo &&
                       CntType == other.CntType;
            }
            return false;

        }

       
        public static bool operator ==(Contact left, Contact right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        public static bool operator !=(Contact left, Contact right)
        {
            return !(left == right);
        }
        public Contact(DateTime beginDt, DateTime endDt, string descr, string dataInfo, ContType type)
        {
            _beginDt = beginDt;
            _endDt = endDt;
            _descr = descr;
            _dataInfo = dataInfo;
            _tpy = type;
        }
    }
}
