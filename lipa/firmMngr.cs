using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lipa.firm;
namespace lipa
{
    internal class firmMngr
    {
        private List<Firm> firms;
        private firmVw q;
      
        public List<bool> Flags;
        public firmMngr()
        {
             Flags=new List<bool>();
            for (int i = 0; i < 17; i++)
            {
                Flags.Add(true);
            }
            q = new firmVw(Flags);
            firms = new List<Firm>();
        }
        public void addfirm(Firm firm)
        {
            firms.Add(firm);
            
        }
        public void UpdateFlags(ref List<bool> flags)
        {
            q = q.UpdateFlags(ref flags);
            Flags = flags;
        }


        public string[] GetData(int index)
        {
            
                return q.GetData(firms[index]);

         
            
        }

        public List<string> GetHeaders()
        {

            return q.getheaders();



        }

        public List<bool> GetStr()
        { 
            return q.getisstrs();
        
        
        }


        public int GetCount
        {
            get { return firms.Count; }
        }
    }
}
