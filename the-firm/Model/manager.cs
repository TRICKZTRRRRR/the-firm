using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm.Model
{
    internal class manager: employee
    {
        private int _phoneNumber;

        public int PhoneNumber { get { return _phoneNumber; } set {  _phoneNumber = value; } }

        public manager(string fornavn, string efternavn, string cprNummer, int phoneNumber) : base(fornavn, efternavn, cprNummer)
        {
            PhoneNumber = phoneNumber;
        }

        public void Manager(int phoneNumber)
        {
            phoneNumber = 32763289;
        }
    }
}
