using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;

namespace ModelsLayer
{
    public class Employee
    {

        public Employee(int EmployeeID, string fname, string lname, string email, string password, bool isManager)
        {
            this.EmployeeID = EmployeeID;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.password= password;
            this.isManager= isManager;

        }

        public int EmployeeID {get;set;}
        public string fname {get;set;}
        public string lname {get;set;}
        public string email {get;set;}
        public string password {get;set;}
        public bool isManager { get; set; } = false;

        public string WelcomeEmployee()
        {
            return $"Welcome {this.fname} {this.lname}";

        }

    }
}
