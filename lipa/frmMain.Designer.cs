
namespace lipa
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.listView1 = new System.Windows.Forms.ListView();
            this.addB = new System.Windows.Forms.Button();
            this.VisB = new System.Windows.Forms.Button();
            this.filB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 49);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1204, 537);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(12, 12);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 2;
            this.addB.Text = "добавить ";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // VisB
            // 
            this.VisB.Location = new System.Drawing.Point(112, 12);
            this.VisB.Name = "VisB";
            this.VisB.Size = new System.Drawing.Size(75, 23);
            this.VisB.TabIndex = 3;
            this.VisB.Text = "Отображение ";
            this.VisB.UseVisualStyleBackColor = true;
            this.VisB.Click += new System.EventHandler(this.VisB_Click);

            // 
            // filB
            // 
            this.filB.Location = new System.Drawing.Point(212, 12);
            this.filB.Name = "filB";
            this.filB.Size = new System.Drawing.Size(75, 23);
            this.filB.TabIndex = 3;
            this.filB.Text = "фильтрация";
            this.filB.UseVisualStyleBackColor = true;
            this.filB.Click += new System.EventHandler(this.filB_Click);

            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1224, 596);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.VisB);
            this.Controls.Add(this.filB);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
       
      
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button VisB;
        private System.Windows.Forms.Button filB;
    }
}