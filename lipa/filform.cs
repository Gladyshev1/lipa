using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lipa
{
    public partial class filform : Form
    {
        public filform(List<string> strings, List<bool> flag)
        {
            for (int i = 0; i < strings.Count; i++) {

                if (flag[i])
                {
                    formcompstr f = new formcompstr(strings[i], i+1 );
                    f.addPanelInForm(this);
                }
                else
                {
                    formcompvalue c=new formcompvalue(strings[i],i+1);
                    c.addPanelInForm(this);
                }
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.ControlCollection coll = this.Controls;

            //foreach (Control item in coll)
            //{
            //    if (item.GetType() == typeof(Panel))
            //    {
            //        FilterData fData = new FilterData();
            //        Control.ControlCollection collP = item.Controls;

            //        if (!((CheckBox)collP[2]).Checked)
            //        {
            //            fData.enabled = true;

            //            foreach (Control elem in collP)
            //            {
            //                if (elem.GetType() == typeof(MaskedTextBox))
            //                {
            //                    fData.key = ((MaskedTextBox)elem).ValidateText();
            //                }
            //                if (elem.GetType() == typeof(RadioButton) && ((RadioButton)elem).Checked)
            //                {
            //                    fData.mode = collP.IndexOf(elem) - 3;
            //                }

            //            }
            //        }
            //        else
            //        {
            //            fData.enabled = false;
            //        }

            //        data.Add(fData);
            //    }
            //}

            this.Close();
        }
    }
}
