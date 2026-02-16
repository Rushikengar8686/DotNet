using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessSpecifiers
{
    class Employee
    {
        // Public Access Specifiers
        public String EmpName;
        public int EmpId;
        

        //Private Access Specifiers
        // If we can access private variable other class if give an error
        // you can not access private variable outside of the class

        //if we try to access private variable what will do...
        // if create inside same class one public method than
        // we can access private variable inside a that methods
        private String EmpRole = "Mern Stack Developer";
        protected String address = "Akluj";
        
        //that's way we can access
        public void displayDetails()
        {
            Console.WriteLine(EmpRole);
        }

    }
    class empDetails: Employee
    {
        public void showEmployeeAddress()
        {
            Console.WriteLine(address);
        }
    }

   
}
