using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    public class MethodOverLoading
    {
        // the are two types of polymorphism
        // Compile time polymorphism  => Method OverLoading
            // Same Method name but pass defferant Parameter is called as method overloading or compile time polymorphism
        // Run Time  polymorphism  => Method Overrding

        public void add(int a , int b)
        {
            Console.WriteLine(a + b);
        }

        public void add(int a, int b, int c)
        {
            Console.WriteLine(a + b+c);
        }
        public void add(int a, int b, int c, int d)
        {
            Console.WriteLine(a + b + c+d);
        }


    }
}
