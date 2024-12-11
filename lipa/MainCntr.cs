using lipa.firm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lipa
{
    internal class MainCntr
    {
        ContTypeCol tcol;
        firmMngr MainMngr;


        public MainCntr(){
             tcol=new ContTypeCol();
           MainMngr=new firmMngr();
        }

        public firmMngr MainMngrProperty
        {
            get { return MainMngr; }
            set { MainMngr = value; }
        }
        public string[] GetData(int index)
        {
            return MainMngr.GetData(index);
        }

        public List<string> gethead()
        {
            return MainMngr.GetHeaders();
        }

        public List<bool> getstr()
        {
            return MainMngr.GetStr();


        }

        public void Filter()
        {
            filtrcontr filC = new filtrcontr(MainMngr,MainMngr.GetHeaders(),MainMngr.GetStr());

        
        }


            public void UpdateFlags(List<bool> Fl)
        {
            MainMngr.UpdateFlags(ref Fl);
        }

        public int GetCount
        {
            get { return MainMngr.GetCount; }
        }
    }
}
