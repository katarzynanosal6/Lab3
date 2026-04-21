using System.Data;
using System.IO;
using System.Xml.Serialization;

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
                MessageBox.Show("Dane wczytane poprawnie");

            }
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki XML (*.xml)|*.xml";
            sfd.Title = "Zapisz dane jako XML";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Osoba> lista = new List<Osoba>();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {

                            lista.Add(new Osoba(
                                row.Cells["Id"].Value != null ? Convert.ToInt32(row.Cells["Id"].Value) : 0,
                                row.Cells["Imiê"].Value?.ToString() ?? "",
                                row.Cells["Nazwisko"].Value?.ToString() ?? "",
                                row.Cells["Wiek"].Value != null ? Convert.ToInt32(row.Cells["Wiek"].Value) : 0,
                                row.Cells["Stanowisko"].Value?.ToString() ?? ""
                            ));
                        }
                    }

                    XmlSerializer serializer = new XmlSerializer(typeof(List<Osoba>));
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        serializer.Serialize(sw, lista);
                    }

                    MessageBox.Show("Zapisano do XML");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad: " + ex.Message);
                }
            }
        }

        private void btnImportXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki XML (*.xml)|*.xml";
            ofd.Title = "Wybierz plik XML do wczytania";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Osoba>));
                    List<Osoba> wczytanaLista;

                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        wczytanaLista = (List<Osoba>)serializer.Deserialize(sr);
                    }

                    
                    dataTable.Rows.Clear();

                    foreach (var osoba in wczytanaLista)
                    {
                        dataTable.Rows.Add(osoba.Id, osoba.Imie, osoba.Nazwisko, osoba.Wiek, osoba.Stanowisko);

                        
                        if (osoba.Id >= nextId) nextId = osoba.Id + 1;
                    }

                    MessageBox.Show("Dane wczytane poprawnie z XML");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("B³¹d podczas odczytu XML: " + ex.Message);
                }
            }
        }
    }
}
