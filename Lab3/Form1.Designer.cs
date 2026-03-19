namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnDodaj = new Button();
            btnUsun = new Button();
            btnZapis = new Button();
            btnOdczyt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(90, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(420, 262);
            dataGridView1.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(576, 70);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(131, 40);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(576, 170);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(131, 40);
            btnUsun.TabIndex = 2;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnZapis
            // 
            btnZapis.Location = new Point(120, 366);
            btnZapis.Name = "btnZapis";
            btnZapis.Size = new Size(201, 40);
            btnZapis.TabIndex = 3;
            btnZapis.Text = "Zapis do .csv";
            btnZapis.UseVisualStyleBackColor = true;
            // 
            // btnOdczyt
            // 
            btnOdczyt.Location = new Point(428, 366);
            btnOdczyt.Name = "btnOdczyt";
            btnOdczyt.Size = new Size(193, 40);
            btnOdczyt.TabIndex = 4;
            btnOdczyt.Text = "Odczyt z .csv";
            btnOdczyt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOdczyt);
            Controls.Add(btnZapis);
            Controls.Add(btnUsun);
            Controls.Add(btnDodaj);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUsun;
        private Button btnZapis;
        private Button btnOdczyt;
        public Button btnDodaj;
    }
}
