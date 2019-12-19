using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_2
{
    public class Produktas
    {
        private string _pavadinimas = null;
        private int _atmintis = 0;
        private string _spalva = null;
        private double _kaina = 0;

        public Produktas()
        {

        }

        public Produktas(string pavadinimas, int atmintis, string spalva, int kaina)
        {
            this._pavadinimas = pavadinimas;
            this._atmintis = atmintis;
            this._spalva = spalva;
            this._kaina = kaina;
        }

        #region "GET"

        public string getPavadinimas()
        {
            return _pavadinimas;
        }

        public int getAtmintis()
        {
            return _atmintis;
        }

        public string getSpalva()
        {
            return _spalva;
        }

        public double getKaina()
        {
            return _kaina;
        }

        #endregion


    }
}
