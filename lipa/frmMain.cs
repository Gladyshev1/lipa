
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using lipa.firm;
namespace lipa
{
    public partial class frmMain : Form
    {

        public string name = "Test Firm";
        public string country = "Test Country";
        public DateTime dateIn = DateTime.Now;
        public string email = "test@example.com";
        public string postInx = "123456";
        public string region = "Test Region";
        public string street = "Test Street";
        public string town = "Test Town";
        public string web = "www.testfirm.com";
        MainCntr MainC;
        int countF = FirmFactory.fldCount();
        private List<string> headers;
        private List<bool> str;




        public frmMain()
        {
            MainC = new MainCntr();
            headers = MainC.gethead();
            str=MainC.getstr();
           

            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < headers.Count; i++)
            {
                this.listView1.Columns.Add(headers[i]);
            }
            for (int i = 0; i < headers.Count; i++)
            {
                this.listView1.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
           Addform addform = new Addform();
            addform.OnFirmCreated += HandleFirmCreated;
            addform.ShowDialog();
         
            
        }
        private void HandleFirmCreated(Firm firm)
        {
           
            MessageBox.Show($"Фирма {firm.Name} успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainC.MainMngrProperty.addfirm(firm);
            int index = MainC.GetCount-1;
            this.listView1.Items.Add(new ListViewItem(MainC.GetData(index)));


        }

        private void VisB_Click(object sender, EventArgs e)
        {
            Visibleform Visform = new Visibleform(headers, MainC.UpdateFlags);
            Visform.ShowDialog();
            int count = this.listView1.Items.Count;
            this.listView1.Columns.Clear();
            for (int i = 0; i < headers.Count; i++)
            {
                if (Visform.flags[i])
                {
                    this.listView1.Columns.Add(headers[i]);
                }
            }

            for (int i = 0; i < count; i++)
            {
                this.listView1.Items[i] = new ListViewItem(MainC.GetData(i));
            }

            for (int i = 0; i < this.listView1.Columns.Count; i++)
            {
                this.listView1.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void filB_Click(object sender, EventArgs e)
        {
            MainC.Filter();
        }


        }
}
