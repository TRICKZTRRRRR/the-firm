using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm.Model
{
    internal class projectmanager: manager
    {
        private string _email;

        public string MailAdresse { get { return _email; } set {  _email = value; } }

        public projectmanager(string fornavn, string efternavn, string cprNummer, int phoneNumber, string email) : base(fornavn, efternavn, cprNummer, phoneNumber)
        {
            MailAdresse = email;
        }

        public void Email(string mail)
        {
            mail = "wdada@gmail.com";
        }
    }
}
