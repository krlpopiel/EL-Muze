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
    public partial class Zabytek : Form
    {
        private readonly ZabytkiController _controller;
        int id_zabytku;
        String ulica;
        String numer;
        String obiekt;
        String nr_rejestru;
        DateTime data;
        String decyzja;

        public Zabytek()
        {
            InitializeComponent();
            _controller = new ZabytkiController();
            this.id_zabytku = -1;
        }

        public Zabytek(int id)
        {
            InitializeComponent();
            _controller = new ZabytkiController();
            this.id_zabytku = id;
        }

        private void zabytkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zabytkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zabytkiDataSet);

        }

        private void Zabytek_Load(object sender, EventArgs e)
        {
            this.zabytkiTableAdapter.Fill(this.zabytkiDataSet.zabytki);

            if (id_zabytku == -1)
            {
                this.zabytkiBindingSource.AddNew();
                data_wpisuDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                var znaleziony = this.zabytkiDataSet.zabytki.FindByid(this.id_zabytku);
                if (znaleziony != null)
                {
                    int index = this.zabytkiBindingSource.Find("id", this.id_zabytku);
                    if (index >= 0)
                    {
                        this.zabytkiBindingSource.Position = index;
                    }
                        
                }
            }
        }

        private void ZapiszRecznie()
        {
            try
            {
                this.ulica = ulicaTextBox.Text;
                this.numer = numerTextBox.Text;
                this.obiekt = obiektTextBox.Text;
                this.nr_rejestru = nr_rejestruTextBox.Text;
                this.data = data_wpisuDateTimePicker.Value;
                this.decyzja = decyzjaTextBox.Text;

                if (string.IsNullOrWhiteSpace(obiekt))
                {
                    MessageBox.Show("Nazwa obiektu jest wymagana!");
                    return;
                }

                if (this.id_zabytku != -1)
                {
                    // Użyj kontrolera do aktualizacji
                    _controller.Aktualizuj(id_zabytku, ulica, numer, obiekt, nr_rejestru, data, decyzja);
                    MessageBox.Show("Zaktualizowano pomyślnie.");
                }
                else
                {
                    // Użyj kontrolera do dodania
                    _controller.Dodaj(ulica, numer, obiekt, nr_rejestru, data, decyzja);
                    MessageBox.Show("Dodano pomyślnie.");
                }

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

        private void zabytkiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.zabytkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zabytkiDataSet);

        }
    }
}

