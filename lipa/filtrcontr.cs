using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lipa
{
    internal class filtrcontr
    {
        firmMngr firmM;
        public filtrcontr(firmMngr firmManager, List<string> strings, List<bool> flag)
        {
            
            this.firmM = firmManager;
           filform form=new filform(strings, flag);
            form.ShowDialog();
        }
    }
}
