using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Manager : Employee
    {

        public Manager(int EmployeeID, string fname, string lname, string email, string emailPassword, bool isManager): base (EmployeeID, fname, lname, email, emailPassword, isManager)
        {
        

        }

        public new bool isManager { get; set; } = true;

        public string WelcomeManager()
        {
            return $"Welcome back {this.fname} {this.lname}";

        }
        
    }
}