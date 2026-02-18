using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
     public class TaskFirst
    {
        public virtual void BasicSalary(double basic)
        {
            double hra = basic * 0.20;
            double da = basic * 0.10;
            double ta = basic * 0.05;

            double gross = basic + hra + da + ta;

            Console.WriteLine("Basic Salary: " + basic);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("TA: " + ta);
            Console.WriteLine("Gross Salary: " + gross);

        }

    }
    public class Developer: TaskFirst
    {
        public override void BasicSalary(double basic)
        {
            Console.WriteLine("Developer Calculate Salary");
            base.BasicSalary(basic);
        }

    }
    public class Manager: TaskFirst
    {
        public override void BasicSalary(double basic)
        {
            Console.WriteLine("Manager Calaculate Salary");
            base.BasicSalary(basic);
        }

    }
}
