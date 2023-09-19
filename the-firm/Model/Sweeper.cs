using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm.Model
{
    internal class Sweeper : employee
    {
        public Sweeper(string fornavn, string efternavn, string cprNummer, int phoneNumber) : base(fornavn, efternavn, cprNummer)
        { 
        }
    }
}
