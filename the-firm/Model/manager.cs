using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm.Model
{
    internal class Manager: Employee
    {
        View.View view = new View.View();

        protected int TelefonNummer {  get; set; }


        public Manager(string fornavn, string efternavn, string cprNummer, int telefonNummer) : base(fornavn, efternavn, cprNummer)
        {
            TelefonNummer = telefonNummer;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            view.PhoneNumber(TelefonNummer);
        }
    }
}
