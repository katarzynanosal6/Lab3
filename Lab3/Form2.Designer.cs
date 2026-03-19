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
            lblImie = new Label();
            lblNazwisko = new Label();
            lblWiek = new Label();
            lblStanowisko = new Label();
            btnZatwierdz = new Button();
            btnAnuluj = new Button();
            cmbStanowisko = new ComboBox();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtWiek = new TextBox();
            SuspendLayout();
            // 
            // lblImie
            // 
            lblImie.AutoSize = true;
            lblImie.Location = new Point(526, 41);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(53, 30);
            lblImie.TabIndex = 4;
            lblImie.Text = "Imię";
            // 
            // lblNazwisko
            // 
            lblNazwisko.AutoSize = true;
            lblNazwisko.Location = new Point(526, 123);
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
            btnZatwierdz.Click += btnZatwierdz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(490, 382);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(131, 40);
            btnAnuluj.TabIndex = 9;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // cmbStanowisko
            // 
            cmbStanowisko.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStanowisko.FormattingEnabled = true;
            cmbStanowisko.Items.AddRange(new object[] { "Programista", "Tester", "Manager" });
            cmbStanowisko.Location = new Point(145, 297);
            cmbStanowisko.Name = "cmbStanowisko";
            cmbStanowisko.Size = new Size(212, 38);
            cmbStanowisko.TabIndex = 3;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(145, 41);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(175, 35);
            txtImie.TabIndex = 10;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(145, 123);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(175, 35);
            txtNazwisko.TabIndex = 11;
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(145, 212);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(175, 35);
            txtWiek.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtWiek);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZatwierdz);
            Controls.Add(lblStanowisko);
            Controls.Add(lblWiek);
            Controls.Add(lblNazwisko);
            Controls.Add(lblImie);
            Controls.Add(cmbStanowisko);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnZatwierdz;
        private Button btnAnuluj;
        public Label lblImie;
        public Label lblNazwisko;
        public Label lblWiek;
        public Label lblStanowisko;
        public ComboBox cmbStanowisko;
        public TextBox txtImie;
        public TextBox txtNazwisko;
        public TextBox txtWiek;
    }
}