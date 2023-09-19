using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_firm.View
{
    internal class View
    {
        // Controller Data
        public void EmployeeData()
        {
            Console.WriteLine("Employee: ");
        }

        public void ManagerData()
        {
            Console.WriteLine("\nManager: ");
        }

        public void ProjectManagerData()
        {
            Console.WriteLine("\nProjectManager: ");
        }

        public void SweeperData()
        {
            Console.WriteLine("\nSweeper: ");
        }

        public void ReadLine()
        {
            Console.ReadLine();
        }
        
        // Model Data
        public void Mail(string Email)
        {
            Console.WriteLine($"Mail: {Email}");
        }

        public void PhoneNumber(int TelefonNummer)
        {
            Console.WriteLine($"Nummer: {TelefonNummer}");
        }

        public void Name(string Fornavn, string Efternavn, string CprNummer)
        {
            Console.WriteLine($"Navn: {Fornavn} {Efternavn}\n" +
                $"CprNummer: {CprNummer}");
        }
    }
}
