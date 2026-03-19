using System.Data;
using System.IO;

namespace Lab3
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();

        int nextId = 1;
        public Form1()
        {
            InitializeComponent();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Imiê", typeof(string));
            dataTable.Columns.Add("Nazwisko", typeof(string));
            dataTable.Columns.Add("Wiek", typeof(int));
            dataTable.Columns.Add("Stanowisko", typeof(string));

            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (Form2 oknoDodawania = new Form2())
            {
                if (oknoDodawania.ShowDialog() == DialogResult.OK)
                {
                    dataTable.Rows.Add(
                        nextId++,
                        oknoDodawania.txtImie.Text,
                        oknoDodawania.txtNazwisko.Text,
                        oknoDodawania.txtWiek.Text,
                        oknoDodawania.cmbStanowisko.Text
                );
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
            else
            {
                MessageBox.Show("Najpierw zaznacz pracownika do usuniêcia!");
            }
        }

        private void btnZapis_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki CSV (*.csv)|*.csv";
            sfd.Title = "Zapisz listê pracowników";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string csv = "ID,Imie,Nazwisko,Wiek,Stanowisko" + Environment.NewLine;

                foreach (DataRow row in dataTable.Rows)
                {
                    csv += string.Join(",", row.ItemArray) + Environment.NewLine;
                }

                File.WriteAllText(sfd.FileName, csv);
                MessageBox.Show("Zapisano pomyœlnie na: " + sfd.FileName);
            }
        }

        private void btnOdczyt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki CSV (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] linie = File.ReadAllLines(ofd.FileName);

                dataTable.Rows.Clear();

                for (int i = 1; i < linie.Length; i++)
                {
                    string[] dane = linie[i].Split(',');

                    dataTable.Rows.Add(dane);

                    if (int.TryParse(dane[0], out int idZPliku))
                    {
                        if (idZPliku >= nextId)
                        {
                            nextId = idZPliku + 1;
                        }
                    }



                }
                MessageBox.Show("Dane wczytane poprawnie!");

            }
        }
    }
}
