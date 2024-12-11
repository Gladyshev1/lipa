using lipa.firm;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace lipa
{
    partial class Addform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<System.Windows.Forms.TextBox> tBfield = new List<System.Windows.Forms.TextBox>();
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.regionTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.postTB = new System.Windows.Forms.TextBox();
            this.DtbegTB = new System.Windows.Forms.MaskedTextBox();
            this.webTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.streetTB = new System.Windows.Forms.MaskedTextBox();
            this.CountcontTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название фирмы";
          
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите страну";
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите регион";
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите город";
        
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Введите почтовый индекс";
        
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Введите дату начала работы фирмы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Введите сайт фирмы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Введите почту фирмы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Дата начала контакта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Количество контактов ";
          
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(168, 37);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 15;
          
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(168, 67);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(100, 20);
            this.countryTB.TabIndex = 16;
           
            // 
            // regionTB
            // 
            this.regionTB.Location = new System.Drawing.Point(168, 97);
            this.regionTB.Name = "regionTB";
            this.regionTB.Size = new System.Drawing.Size(100, 20);
            this.regionTB.TabIndex = 17;
          
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(168, 123);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(100, 20);
            this.cityTB.TabIndex = 18;
          
            // 
            // postTB
            // 
            this.postTB.Location = new System.Drawing.Point(168, 156);
            this.postTB.Name = "postTB";
            this.postTB.Size = new System.Drawing.Size(100, 20);
            this.postTB.TabIndex = 19;
            
            // 
            // DtbegTB
            // 
            this.DtbegTB.Location = new System.Drawing.Point(504, 40);
            this.DtbegTB.Mask = "00/00/0000";
            this.DtbegTB.Name = "DtbegTB";
            this.DtbegTB.Size = new System.Drawing.Size(100, 20);
            this.DtbegTB.TabIndex = 20;
            this.DtbegTB.ValidatingType = typeof(System.DateTime);
            // 
            // webTB
            // 
            this.webTB.Location = new System.Drawing.Point(504, 67);
            this.webTB.Name = "webTB";
            this.webTB.Size = new System.Drawing.Size(100, 20);
            this.webTB.TabIndex = 21;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(504, 93);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 22;
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(504, 119);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(100, 20);
            this.streetTB.Mask = "00/00/0000";
            this.streetTB.TabIndex = 23;
            this.streetTB.ValidatingType = typeof(System.DateTime);
            // 
            // CountcontTB
            // 
            this.CountcontTB.Location = new System.Drawing.Point(504, 152);
            this.CountcontTB.Name = "CountcontTB";
            this.CountcontTB.Size = new System.Drawing.Size(100, 20);
            this.CountcontTB.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(621, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Addform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CountcontTB);
            this.Controls.Add(this.streetTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.webTB);
            this.Controls.Add(this.DtbegTB);
            this.Controls.Add(this.postTB);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.regionTB);
            this.Controls.Add(this.countryTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Addform";
            this.Text = "Addform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.TextBox regionTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox postTB;
        private System.Windows.Forms.MaskedTextBox DtbegTB;
        private System.Windows.Forms.TextBox webTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.MaskedTextBox streetTB;
        private System.Windows.Forms.TextBox CountcontTB;
        private void AddDynamicFields()
        {
            for (int i = 0; i < FirmFactory.fldCount(); i++)
            {
                // Создание метки
                var label = new System.Windows.Forms.Label();
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(23, 200 + i * 30);
                label.Name = $"label{i + 1}";
                label.Size = new System.Drawing.Size(35, 13);
                label.TabIndex = 25 + i * 2;
                label.Text = $"Поле {i + 1}";
                this.Controls.Add(label);

                // Создание текстового поля
                var textBox = new System.Windows.Forms.TextBox();
                textBox.Location = new System.Drawing.Point(114, 200 + i * 30);
                textBox.Name = $"textBox{i + 11}";
                textBox.Size = new System.Drawing.Size(100, 20);
                textBox.TabIndex = 26 + i * 2;
                this.Controls.Add(textBox);
                tBfield.Add(textBox);
            }
        }

        private System.Windows.Forms.Button button1;
    }

}