using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using the_firm.Model;

namespace the_firm.Controller
{
    internal class Controller
    {
        View.View view = new View.View();

        public void MainController()
        {
            Employee medarbejder = new Employee("Torben", "Hansen", "01/09/98-7168");
            Manager manager = new Manager("Jørgen", "Madsen", "15/12/76-3267", 23479188);
            Projectmanager projectmanager = new Projectmanager("Kris", "Hansen", "21/05/98-3596", 26357806, "kris@zbc.dk");
            Sweeper sweeper = new Sweeper("Mogens", "Mogensen", "31/12/66-9253");

            view.EmployeeData();
            medarbejder.PrintInfo();

            view.ManagerData();
            manager.PrintInfo();

            view.ProjectManagerData();
            projectmanager.PrintInfo();

            view.SweeperData();
            sweeper.PrintInfo();

            view.ReadLine();
        }
    }
}
