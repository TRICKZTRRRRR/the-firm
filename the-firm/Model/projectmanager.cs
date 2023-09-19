using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm.Model
{
    internal class Projectmanager: Manager
    {
        View.View view = new View.View();

        protected string Email { get; set; }


        public Projectmanager(string fornavn, string efternavn, string cprNummer, int telefonNummer, string email) : base(fornavn, efternavn, cprNummer, telefonNummer)
        {
            Email = email;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            view.Mail(Email);
        }
    }
}
