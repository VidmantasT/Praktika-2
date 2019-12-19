using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_2
{
    public class Uzsakymas
    {
        private string _username;
        private string _productID;
        private string _pavadinimas;
        private double _kaina;
        private double _moketinaSuma;
        private DateTime _data;

        public Uzsakymas()
        {

        }

        public Uzsakymas(string username, string productID, string pavadinimas, double price)
        {
            this._username = username;
            this._productID = productID;
            this._pavadinimas = pavadinimas;
            this._kaina = price;
        }

        #region"GET"
        public string getUsername()
        {
            return _username;
        }

        public string getID()
        {
            return _productID;
        }

        public string getPavadinimas()
        {
            return _pavadinimas;
        }

        public double getKaina()
        {
            return _kaina;
        }

        #endregion

        public double moketinaSuma(double kaina)
        {
            return this._moketinaSuma = kaina;
        }

        public DateTime GetDate()
        {
            return this._data = Convert.ToDateTime(DateTime.Now);
        }
    }
}