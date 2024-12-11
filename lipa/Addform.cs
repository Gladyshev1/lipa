using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using lipa.firm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace lipa
{
    public partial class Addform : Form
    {

        public event Action<Firm> OnFirmCreated;
        public Addform()
        {
            InitializeComponent();
            AddDynamicFields();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед добавлением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FirmFactory factory = FirmFactory.Instance(new SbFirmType(true, "Главный"));
              
                DateTime dateF = DateTime.Parse(DtbegTB.Text);
                Firm firm = factory.CreateFirm(nameTB.Text,emailTB.Text,cityTB.Text,postTB.Text,countryTB.Text,streetTB.Text,regionTB.Text,webTB.Text, dateF);
                
                DateTime dateC = DateTime.Parse(streetTB.Text);

                Contact contact = new Contact(dateC, DateTime.Now, "Тестовый Контакт", "Тестовый контакт", new ContType("Тестовый тип", "+79101493375"));
                for (int i = 0; i < int.Parse(CountcontTB.Text); i++)
                {
                    firm.AddCont(contact);
                }
                for (int i = 0; i < FirmFactory.fldCount(); i++)
                {

                    firm.setField(factory.fldNameIN(i), tBfield[i].Text);
                 }
                OnFirmCreated?.Invoke(firm);
                this.Close();
            }
        }
        private bool AreAllFieldsFilled()
        {
            // Получаем все TextBox на форме
            var textFields = this.Controls.OfType<TextBox>();

            // Проверяем, что каждое поле заполнено
            foreach (var textBox in textFields)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }

            return true;
        }

      
    }
}
