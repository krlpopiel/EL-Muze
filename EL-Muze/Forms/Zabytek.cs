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
    public partial class Zabytek : Form
    {
        int id_zabytku;
        String ulica;
        String numer;
        String obiekt;
        String nr_rejestru;
        DateTime data_wpisu;
        String decyzja;
        public Zabytek()
        {
            InitializeComponent();
            this.id_zabytku = -1;
        }

        public Zabytek(int id)
        {
            InitializeComponent();
            this.id_zabytku = id;
        }

        private void zabytkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zabytkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centrala_muzeumDataSet);

        }

        private void Zabytek_Load(object sender, EventArgs e)
        {
            this.zabytkiTableAdapter.Fill(this.centrala_muzeumDataSet.zabytki);

            if (id_zabytku == -1)
            {
                this.zabytkiBindingSource.AddNew();
                data_wpisuDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                var znaleziony = this.centrala_muzeumDataSet.zabytki.FindByid(this.id_zabytku);
                if (znaleziony != null)
                {
                    int index = this.zabytkiBindingSource.Find("id", this.id_zabytku);
                    if (index >= 0)
                        this.zabytkiBindingSource.Position = index;
                }
            }
        }

        private void ZapiszRecznie()
        {
            try
            {
                string ulica = ulicaTextBox.Text;
                string numer = numerTextBox.Text;
                string obiekt = obiektTextBox.Text;
                string nr_rejestru = nr_rejestruTextBox.Text;
                DateTime data = data_wpisuDateTimePicker.Value;
                string decyzja = decyzjaTextBox.Text;

                if (string.IsNullOrWhiteSpace(obiekt))
                {
                    MessageBox.Show("Nazwa obiektu jest wymagana!");
                    return;
                }

                this.zabytkiTableAdapter.Insert(
                    ulica,
                    numer,
                    obiekt,
                    nr_rejestru,
                    data,
                    decyzja
                );

                MessageBox.Show("Dodano pomyślnie.");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu: " + ex.Message);
            }
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZapiszRecznie();
        }
    }
}
