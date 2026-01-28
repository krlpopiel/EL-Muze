using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EL_Muze.zabytkiDataSetTableAdapters;

namespace EL_Muze.Controllers
{

    public class ZabytkiController
    {
        private readonly zabytkiDataSet _dataSet;
        private readonly zabytkiTableAdapter _tableAdapter;
        private readonly TableAdapterManager _tableAdapterManager;

        public ZabytkiController()
        {
            _dataSet = new zabytkiDataSet();
            _tableAdapter = new zabytkiTableAdapter();
            _tableAdapterManager = new TableAdapterManager
            {
                zabytkiTableAdapter = _tableAdapter
            };
        }

        public zabytkiDataSet.zabytkiDataTable PobierzWszystkie()
        {
            _tableAdapter.Fill(_dataSet.zabytki);
            return _dataSet.zabytki;
        }

        public string ZbudujFiltr(
            int? id = null,
            string ulica = null,
            string numer = null,
            string obiekt = null,
            string nrRejestru = null,
            DateTime? dataWpisuOd = null,
            DateTime? dataWpisuDo = null,
            string decyzja = null)
        {
            List<string> warunki = new List<string>();

            if (id.HasValue)
            {
                warunki.Add(string.Format("id = {0}", id.Value));
            }

            if (!string.IsNullOrWhiteSpace(ulica))
            {
                warunki.Add(string.Format("ulica LIKE '%{0}%'", ulica));
            }

            if (!string.IsNullOrWhiteSpace(numer))
            {
                warunki.Add(string.Format("numer = '{0}'", numer));
            }

            if (!string.IsNullOrWhiteSpace(obiekt))
            {
                warunki.Add(string.Format("obiekt LIKE '%{0}%'", obiekt));
            }

            if (!string.IsNullOrWhiteSpace(nrRejestru))
            {
                warunki.Add(string.Format("nr_rejestru LIKE '%{0}%'", nrRejestru));
            }

            if (dataWpisuOd.HasValue)
            {
                warunki.Add(string.Format("data_wpisu >= #{0}#", dataWpisuOd.Value.ToString("yyyy-MM-dd")));
            }

            if (dataWpisuDo.HasValue)
            {
                warunki.Add(string.Format("data_wpisu <= #{0}#", dataWpisuDo.Value.ToString("yyyy-MM-dd")));
            }

            if (!string.IsNullOrWhiteSpace(decyzja))
            {
                warunki.Add(string.Format("decyzja LIKE '%{0}%'", decyzja));
            }

            return warunki.Count > 0 ? string.Join(" AND ", warunki) : string.Empty;
        }

        public zabytkiDataSet.zabytkiRow PobierzJeden(int id)
        {
            _tableAdapter.Fill(_dataSet.zabytki);
            return _dataSet.zabytki.FindByid(id);
        }

        public bool Dodaj(string ulica, string numer, string obiekt, string nrRejestru, DateTime dataWpisu, string decyzja)
        {
            if (string.IsNullOrWhiteSpace(obiekt))
            {
                throw new ArgumentException("Nazwa obiektu jest wymagana!", nameof(obiekt));
            }

            try
            {
                _tableAdapter.Insert(ulica, numer, obiekt, nrRejestru, dataWpisu, decyzja, false);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Aktualizuj(int id, string ulica, string numer, string obiekt, string nrRejestru, DateTime dataWpisu, string decyzja)
        {
            if (string.IsNullOrWhiteSpace(obiekt))
            {
                throw new ArgumentException("Nazwa obiektu jest wymagana!", nameof(obiekt));
            }

            try
            {
                _tableAdapter.Fill(_dataSet.zabytki);
                var staryRekord = _dataSet.zabytki.FindByid(id);

                if (staryRekord != null)
                {
                    // Ustaw flagę modyfikowano na starym rekordzie
                    staryRekord.modyfikowano = true;
                    _tableAdapter.Update(_dataSet.zabytki);

                    // Dodaj nowy rekord z nowymi danymi
                    _tableAdapter.Insert(ulica, numer, obiekt, nrRejestru, dataWpisu, decyzja, false);
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Usun(int id)
        {
            try
            {
                _tableAdapter.Fill(_dataSet.zabytki);
                var rekord = _dataSet.zabytki.FindByid(id);

                if (rekord != null)
                {
                    rekord.Delete();
                    _tableAdapter.Update(_dataSet.zabytki);
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
