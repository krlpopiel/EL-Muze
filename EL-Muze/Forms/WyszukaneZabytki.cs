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
    }
}
