using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace the_firm.Model
{
    internal class Employee
    {
        View.View view = new View.View();


        protected string Fornavn { get; set; }
        protected string Efternavn { get; set; }
        protected string CprNummer { get; set; }

        public Employee(string fornavn, string efternavn, string cprNummer)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            CprNummer = cprNummer;
        }

        public void PrintInfo()
        {
            view.Name(Fornavn, Efternavn, CprNummer);
        }
    }
}
