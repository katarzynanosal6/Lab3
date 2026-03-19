namespace Lab3
{
    partial class Form2
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            lblImie = new Label();
            lblNazwisko = new Label();
            lblWiek = new Label();
            lblStanowisko = new Label();
            btnZatwierdz = new Button();
            btnAnuluj = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(140, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 38);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(140, 106);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(212, 38);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(140, 204);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(212, 38);
            comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(140, 289);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(212, 38);
            comboBox4.TabIndex = 3;
            // 
            // lblImie
            // 
            lblImie.AutoSize = true;
            lblImie.Location = new Point(526, 35);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(53, 30);
            lblImie.TabIndex = 4;
            lblImie.Text = "Imię";
            // 
            // lblNazwisko
            // 
            lblNazwisko.AutoSize = true;
            lblNazwisko.Location = new Point(526, 114);
            lblNazwisko.Name = "lblNazwisko";
            lblNazwisko.Size = new Size(101, 30);
            lblNazwisko.TabIndex = 5;
            lblNazwisko.Text = "Nazwisko";
            // 
            // lblWiek
            // 
            lblWiek.AutoSize = true;
            lblWiek.Location = new Point(526, 212);
            lblWiek.Name = "lblWiek";
            lblWiek.Size = new Size(59, 30);
            lblWiek.TabIndex = 6;
            lblWiek.Text = "Wiek";
            // 
            // lblStanowisko
            // 
            lblStanowisko.AutoSize = true;
            lblStanowisko.Location = new Point(526, 297);
            lblStanowisko.Name = "lblStanowisko";
            lblStanowisko.Size = new Size(116, 30);
            lblStanowisko.TabIndex = 7;
            lblStanowisko.Text = "Stanowisko";
            // 
            // btnZatwierdz
            // 
            btnZatwierdz.Location = new Point(186, 382);
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.Size = new Size(131, 40);
            btnZatwierdz.TabIndex = 8;
            btnZatwierdz.Text = "Zatwierdź";
            btnZatwierdz.UseVisualStyleBackColor = true;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(490, 382);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(131, 40);
            btnAnuluj.TabIndex = 9;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZatwierdz);
            Controls.Add(lblStanowisko);
            Controls.Add(lblWiek);
            Controls.Add(lblNazwisko);
            Controls.Add(lblImie);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label lblImie;
        private Label lblNazwisko;
        private Label lblWiek;
        private Label lblStanowisko;
        private Button btnZatwierdz;
        private Button btnAnuluj;
    }
}