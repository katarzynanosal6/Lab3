using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImie.Text) || string.IsNullOrWhiteSpace(txtNazwisko.Text))
            {
                MessageBox.Show("Wypełnij imię i nazwisko!");
                return;
            }
            if (cmbStanowisko.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz stanowisko z listy!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
