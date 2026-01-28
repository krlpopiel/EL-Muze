using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL_Muze.Controllers;

namespace EL_Muze.Forms
{
    public partial class WyszukiwanieZabytkow : Form
    {
        private readonly ZabytkiController _controller;

        public WyszukiwanieZabytkow()
        {
            InitializeComponent();
            _controller = new ZabytkiController();
            
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
            // Zbierz parametry wyszukiwania
            int? id = null;
            if (checkBox1.Checked && !string.IsNullOrWhiteSpace(idTextBox.Text))
            {
                if (int.TryParse(idTextBox.Text, out int parsedId))
                    id = parsedId;
            }

            string ulica = checkBox2.Checked && !string.IsNullOrWhiteSpace(ulicaTextBox.Text) ? ulicaTextBox.Text : null;
            string numer = checkBox3.Checked && !string.IsNullOrWhiteSpace(numerTextBox.Text) ? numerTextBox.Text : null;
            string obiekt = checkBox4.Checked && !string.IsNullOrWhiteSpace(obiektTextBox.Text) ? obiektTextBox.Text : null;
            string nrRejestru = checkBox5.Checked && !string.IsNullOrWhiteSpace(nr_rejestruTextBox.Text) ? nr_rejestruTextBox.Text : null;
            DateTime? dataOd = checkBox6.Checked ? data_wpisu_od_DateTimePicker.Value : (DateTime?)null;
            DateTime? dataDo = checkBox7.Checked ? data_wpisu_do_DateTimePicker.Value : (DateTime?)null;
            string decyzja = checkBox8.Checked && !string.IsNullOrWhiteSpace(decyzjaTextBox.Text) ? decyzjaTextBox.Text : null;

            // Użyj kontrolera do zbudowania filtra
            string finalnyFiltr = _controller.ZbudujFiltr(id, ulica, numer, obiekt, nrRejestru, dataOd, dataDo, decyzja);

            if (!string.IsNullOrEmpty(finalnyFiltr))
            {
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

