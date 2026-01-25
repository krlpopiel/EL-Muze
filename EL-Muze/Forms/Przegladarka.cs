using System;
using System.Windows.Forms;

namespace EL_Muze.Forms
{
    public partial class Przegladarka : Form
    {
        int id_zabytku;

        public Przegladarka()
        {
            InitializeComponent();
        }

        private void Przegladarka_Load(object sender, EventArgs e)
        {
            odswiezDane();
        }

        private void odswiezDane()
        {
            this.zabytkiTableAdapter.Fill(this.centrala_muzeumDataSet.zabytki);
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            Form pokaz = new Forms.Zabytek(-1);

            pokaz.ShowDialog();

            odswiezDane();
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
                        tableAdapterManager.UpdateAll(this.centrala_muzeumDataSet);

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

        private void button_wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zabytkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zabytkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.centrala_muzeumDataSet);
        }
    }
}