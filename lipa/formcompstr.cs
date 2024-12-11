using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lipa
{
    public partial class formcompstr : Component
    {
        public formcompstr(string label, int i)
        {
            InitializeComponent();
            this.nameFieldCheckBox.Name += i.ToString();
            this.nameFieldCheckBox.Checked = true;
            this.label1.Name += i.ToString();
            this.maskedTextBox1.Name += i.ToString();
            this.maskedTextBox1.ValidatingType = typeof(string);
            this.radioButton1.Name += i.ToString();
            this.radioButton2.Name += i.ToString();
            this.radioButton3.Name += i.ToString();
            this.radioButton4.Name += i.ToString();
            this.panel1.Name += i.ToString();
            this.label1.Text = label;
            this.SetHeight(40 * (i - 1));
        }
        public void SetHeight(int y)
        {
            this.panel1.Location = new System.Drawing.Point(this.panel1.Location.X, this.panel1.Location.Y + y);
        }

        public void addPanelInForm(Form form)
        {
            form.Controls.Add(this.panel1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
        }

        private void nameFieldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;

            Control c1 = c.Parent;

            c1.Controls[1].Enabled = !c1.Controls[1].Enabled;
            c1.Controls[3].Enabled = !c1.Controls[3].Enabled;
            c1.Controls[4].Enabled = !c1.Controls[4].Enabled;
            c1.Controls[5].Enabled = !c1.Controls[5].Enabled;
            c1.Controls[6].Enabled = !c1.Controls[6].Enabled;
        }
        public formcompstr(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
