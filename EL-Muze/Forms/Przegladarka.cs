using System;
using System.Windows.Forms;
using System.Linq;

namespace EL_Muze.Forms
{
    public partial class Przegladarka : Form
    {
        int id_zabytku;
        private bool _pokazArchiwalne;

        public Przegladarka(bool czyArchiwalne)
        {
            InitializeComponent();
            _pokazArchiwalne = czyArchiwalne;
            if (_pokazArchiwalne)
            {
                this.Text = "Przeglądarka - Archiwum (Zmodyfikowane)";
                button_modyfikuj.Enabled = false;
                button_usun.Enabled = false;
                button_dodaj.Enabled = false;
            }
        }

        private void Przegladarka_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zabytkiDataSet.zabytki' . Możesz go przenieść lub usunąć.
            this.zabytkiTableAdapter.Fill(this.zabytkiDataSet.zabytki);
            odswiezDane();
        }

        private void odswiezDane()
        {
            this.zabytkiTableAdapter.Fill(this.zabytkiDataSet.zabytki);

            if (_pokazArchiwalne)
            {
                zabytkiBindingSource.Filter = "modyfikowano = true";
            }
            else
            {
                zabytkiBindingSource.Filter = "modyfikowano = false OR modyfikowano IS NULL";
            }
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

        private void button_wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zabytkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zabytkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zabytkiDataSet);
        }

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            Form wyszukanie = new Forms.WyszukiwanieZabytkow();
            wyszukanie.ShowDialog();
            odswiezDane();
        }

        private void button_archiwum_Click(object sender, EventArgs e)
        {
            string finalnyFiltr = "modyfikowano = true";

            try
            {
                Form wyszukaneZabytki = new WyszukaneZabytki(finalnyFiltr);
                wyszukaneZabytki.ShowDialog();
                zabytkiBindingSource.Filter = "modyfikowano = false OR modyfikowano IS NULL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd w filtrze: " + ex.Message);
            }
        }
            

        private void zabytkiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.zabytkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zabytkiDataSet);

        }

        private void button_statystyki_Click(object sender, EventArgs e)
        {
            var tabela = this.zabytkiDataSet.zabytki;

            if (tabela.Rows.Count == 0)
            {
                MessageBox.Show("Brak danych do obliczeń.");
                return;
            }

            var wpisy = tabela
                .Where(r => !r.IsNull("data_wpisu"))
                .ToList();

            if (wpisy.Count == 0)
            {
                MessageBox.Show("Brak wpisów z datą wpisu do rejestru.");
                return;
            }

            int ilosc = tabela.Count;

            var najstarszyWpis = wpisy.Min(r => r.data_wpisu);
            var najnowszyWpis = wpisy.Max(r => r.data_wpisu);
            int archiwalne = tabela.Count(row => !row.IsmodyfikowanoNull() && row.modyfikowano == true);
            int aktualne = ilosc - archiwalne;
            double procentArchiwum = ((double)archiwalne / ilosc) * 100;
            double sredniWiekDni = wpisy.Average(r => (DateTime.Now - r.data_wpisu).TotalDays);
            int sredniWiekLat = (int)(sredniWiekDni / 365);

            string raport =
                $"Łączna liczba wpisów: {ilosc}\n" +
                $"Najstarszy wpis do rejestru: {najstarszyWpis.ToShortDateString()}\n" +
                $"Najnowszy wpis do rejestru: {najnowszyWpis.ToShortDateString()}\n" +
                $"Średnio zabytek jest w rejestrze od: {sredniWiekLat} lat\n" +
                $"Aktualne wpisy: {aktualne}\n" +
                $"Archiwalne (zmienione): {archiwalne}\n"+
                $"Stopień modyfikacji bazy: {procentArchiwum:F2}%";

            MessageBox.Show(raport, "Statystyki", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button_top5_Click(object sender, EventArgs e)
        {
            var tabela = this.zabytkiDataSet.zabytki;

            var topUlice = tabela
                .Where(row => !row.IsulicaNull() && !string.IsNullOrWhiteSpace(row.ulica))
                .GroupBy(row => row.ulica)
                .Select(grupa => new { Ulica = grupa.Key, Liczba = grupa.Count() })
                .OrderByDescending(x => x.Liczba)
                .Take(5);

            if (!topUlice.Any())
            {
                MessageBox.Show("Brak danych o ulicach.");
                return;
            }

            string wynik = "Ulica (Liczba zabytków):\n\n";

            int miejsce = 1;
            foreach (var item in topUlice)
            {
                wynik += $"{miejsce}. {item.Ulica}: {item.Liczba}\n";
                miejsce++;
            }

            MessageBox.Show(wynik, "Top 5 Ulic z zabytkami", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}