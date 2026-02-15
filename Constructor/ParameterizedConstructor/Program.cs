using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParameterizedConstructor
{
    class Program
    {
        //Parameterized Constructor
        class Employee
        {
            public String empName;
            public String empRole;

            public Employee(String Empname, String EmpRole)
            {
                empName = Empname;
                empRole = EmpRole;
            }
        }
        static void Main(string[] args)
        {
            Employee empInfo = new Employee("Rushikesh","Full Stack Developer");
            Console.WriteLine(empInfo.empName + " is " + empInfo.empRole);
            Console.ReadLine();
        }
    }
}
