using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any number");
            int b = Convert.ToInt32(Console.ReadLine());
            //int a = 10;
            //int b = 20;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            Console.WriteLine("addtion of two number"+c);
            Console.WriteLine("Subtraction of two number"+d);
            Console.WriteLine("Multiplication  of two number"+e);
            Console.WriteLine("dividion of two number"+f);
            Console.ReadKey();
        }
    }

}
