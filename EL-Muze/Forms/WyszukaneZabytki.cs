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
    public partial class WyszukaneZabytki : Form
    {
        private string _przekazanyFiltr;
        private int id_zabytku;

        public WyszukaneZabytki()
        {
            InitializeComponent();
            _przekazanyFiltr = "";
        }
        public WyszukaneZabytki(string filtr)
        {
            InitializeComponent();
            this._przekazanyFiltr = filtr; 
        }

        private void zabytkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zabytkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zabytkiDataSet);

        }

        private void WyszukaneZabytki_Load(object sender, EventArgs e)
        {
            this.zabytkiTableAdapter.Fill(this.zabytkiDataSet.zabytki);

            if (!string.IsNullOrEmpty(_przekazanyFiltr))
            {
                try
                {
                    zabytkiBindingSource.Filter = _przekazanyFiltr;
                    this.Text = $"Znaleziono: {zabytkiBindingSource.Count} rekordów";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd filtru: " + ex.Message);
                }
            }

        }

        private void odswiezDane()
        {
            this.zabytkiTableAdapter.Fill(this.zabytkiDataSet.zabytki);

            if (!string.IsNullOrEmpty(_przekazanyFiltr))
            {
                zabytkiBindingSource.Filter = _przekazanyFiltr;
                this.Text = $"Znaleziono: {zabytkiBindingSource.Count} rekordów";
            }
        }

        private void button_modyfikuj_Click(object sender, EventArgs e)
        {
            if (zabytkiBindingSource.Current != null)
            {
                this.id_zabytku = ((int)((System.Data.DataRowView)this.zabytkiBindingSource.Current).Row["id"]);

                Form pokaz = new Forms.Zabytek(id_zabytku);
                pokaz.ShowDialog();

                odswiezDane();
            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            if (zabytkiBindingSource.Current != null)
            {
                if (MessageBox.Show("Czy na pewno usunąć ten zabytek?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        zabytkiBindingSource.RemoveCurrent();

                        zabytkiBindingSource.EndEdit();
                        tableAdapterManager.UpdateAll(this.zabytkiDataSet);

                        odswiezDane();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd usuwania: " + ex.Message);
                        odswiezDane();
                    }
                }
            }
        }

        private void button_pokaz_Click(object sender, EventArgs e)
        {
            button_modyfikuj_Click(sender, e);
        }

        private void button_zamknij_Click(object sender, EventArgs e)
        {
            odswiezDane();
            this.Close();      
        }
    }
}
