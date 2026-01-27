using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EL_Muze.Forms
{
    public partial class WyszukiwanieZabytkow : Form
    {
        public WyszukiwanieZabytkow()
        {
            InitializeComponent();
            
            idTextBox.TextChanged += (s, e) => { if (!string.IsNullOrWhiteSpace(idTextBox.Text)) checkBox1.Checked = true; };
            ulicaTextBox.TextChanged += (s, e) => { if (!string.IsNullOrWhiteSpace(ulicaTextBox.Text)) checkBox2.Checked = true; };
            numerTextBox.TextChanged += (s, e) => { if (!string.IsNullOrWhiteSpace(numerTextBox.Text)) checkBox3.Checked = true; };
            obiektTextBox.TextChanged += (s, e) => { if (!string.IsNullOrWhiteSpace(obiektTextBox.Text)) checkBox4.Checked = true; };
            nr_rejestruTextBox.TextChanged += (s, e) => { if (!string.IsNullOrWhiteSpace(nr_rejestruTextBox.Text)) checkBox5.Checked = true; };
            decyzjaTextBox.TextChanged += (s, e) => { if (!string.IsNullOrWhiteSpace(decyzjaTextBox.Text)) checkBox8.Checked = true; };
        }

        private void WyszukiwanieZabytkow_Load(object sender, EventArgs e)
        {
            //this.zabytkiTableAdapter.Fill(this.zabytkiDataSet.zabytki);
        }

        private void button_wyszukaj_Click(object sender, EventArgs e)
        {
            List<string> warunki = new List<string>();

            if (checkBox1.Checked && !string.IsNullOrWhiteSpace(idTextBox.Text))
            {
                warunki.Add(string.Format("id = {0}", idTextBox.Text));
            }

            if (checkBox2.Checked && !string.IsNullOrWhiteSpace(ulicaTextBox.Text))
            {
                warunki.Add(string.Format("ulica LIKE '%{0}%'", ulicaTextBox.Text));
            }

            if (checkBox3.Checked && !string.IsNullOrWhiteSpace(numerTextBox.Text))
            {
                warunki.Add(string.Format("numer = '{0}'", numerTextBox.Text));
            }

            if (checkBox4.Checked && !string.IsNullOrWhiteSpace(obiektTextBox.Text))
            {
                warunki.Add(string.Format("obiekt LIKE '%{0}%'", obiektTextBox.Text));
            }

            if (checkBox5.Checked && !string.IsNullOrWhiteSpace(nr_rejestruTextBox.Text))
            {
                warunki.Add(string.Format("nr_rejestru LIKE '%{0}%'", nr_rejestruTextBox.Text));
            }

            if (checkBox6.Checked)
            {
                string dataOd = data_wpisu_od_DateTimePicker.Value.ToString("yyyy-MM-dd");

                warunki.Add(string.Format("data_wpisu >= #{0}#", dataOd));
            }

            if (checkBox7.Checked)
    {
                string dataDo = data_wpisu_do_DateTimePicker.Value.ToString("yyyy-MM-dd");

                warunki.Add(string.Format("data_wpisu <= #{0}#", dataDo));
            }

            if (checkBox8.Checked && !string.IsNullOrWhiteSpace(decyzjaTextBox.Text))
            {
                warunki.Add(string.Format("decyzja LIKE '%{0}%'", decyzjaTextBox.Text));
            }

            if (warunki.Count > 0)
            {
                string finalnyFiltr = string.Join(" AND ", warunki);

                try
                {
                    zabytkiBindingSource.Filter = finalnyFiltr;
                    Form wyszukaneZabytki = new WyszukaneZabytki(finalnyFiltr);
                    wyszukaneZabytki.ShowDialog();
                    zabytkiBindingSource.RemoveFilter();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd w filtrze: " + ex.Message);
                }
            }
            else
            {
                zabytkiBindingSource.RemoveFilter();
            }
        }

        private void button_wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
