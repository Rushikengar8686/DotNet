using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now Create Method Overloading Object
           /* MethodOverLoading obj = new MethodOverLoading();
            obj.add(10, 20);
            obj.add(10, 20, 30);
            obj.add(10, 20, 30, 40); 


            // Now Create Method Overriding Object
            MethodOverriding objNew = new Dog();
            objNew.sound();
            MethodOverriding objNew2 = new Cat();
            objNew2.sound();*/

            // TaskFirst Create Object
            TaskFirst Dev = new Developer();
            Dev.BasicSalary(20000);
            TaskFirst Manager = new Manager();
            Manager.BasicSalary(79000);


            // Bank Task
            Console.WriteLine("Bank Task");
            BankExample saving = new SavingAccount();
            Console.WriteLine("Calculate Saving Account Interest  "+saving.CalculateIntrest(50000, 4, 2));
            BankExample current = new currentAccount();
            Console.WriteLine("Calculate Current Account Interest " + current.CalculateIntrest(70000, 5, 5));



               

            Console.ReadLine();
        }
    }
}
