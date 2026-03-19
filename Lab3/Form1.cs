using System.Data;

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
    }
}
