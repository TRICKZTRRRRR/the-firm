using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace the_firm.Model
{
    internal class employee
    {
        private string _fornavn;
        private string _efternavn;
        private string _cprNummer;

        public string Fornavn { get { return _fornavn; } set { _fornavn = value; } }
        public string Efternavn { get { return _efternavn; } set { _efternavn = value; } }
        public string CprNummer { get { return _cprNummer; } set { _cprNummer = value; } }

        public employee(string fornavn, string  efternavn, string cprNummer)
        {
            _fornavn = fornavn;
            _cprNummer = cprNummer;
            _fornavn = fornavn;
        }

        public void Employee(string fornavn, string efternavn, string cprNummer)
        {
            fornavn = "Torben";
            efternavn = "Hansen";
            cprNummer = "2005-10-15";
        }
    }
}
