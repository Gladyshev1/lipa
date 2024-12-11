namespace lipa
{
    partial class formcompstr
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.nameFieldCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            // 
            // nameFieldCheckBox
            // 
            this.nameFieldCheckBox.AutoSize = true;
            this.nameFieldCheckBox.Location = new System.Drawing.Point(382, 17);
            this.nameFieldCheckBox.Name = "nameFieldCheckBox";
            this.nameFieldCheckBox.Size = new System.Drawing.Size(52, 20);
            this.nameFieldCheckBox.TabIndex = 33;
            this.nameFieldCheckBox.Text = "нет";
            this.nameFieldCheckBox.UseVisualStyleBackColor = true;
            this.nameFieldCheckBox.CheckedChanged += new System.EventHandler(this.nameFieldCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Название фирмы";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(164, 17);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(189, 22);
            this.maskedTextBox1.TabIndex = 50;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(466, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 20);
            this.radioButton1.TabIndex = 51;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "=";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(529, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 20);
            this.radioButton2.TabIndex = 52;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "!=";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(600, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 20);
            this.radioButton3.TabIndex = 53;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Содержит";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(712, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(112, 20);
            this.radioButton4.TabIndex = 54;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Не содержит";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.nameFieldCheckBox);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Location = new System.Drawing.Point(32, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 46);
            this.panel1.TabIndex = 55;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox nameFieldCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;
    }

}
