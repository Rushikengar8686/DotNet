using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.WriteLine("************ Single Inheritance***********");
            d.Bark();
            d.Eat();
            Console.WriteLine("************ MultiLevel Inheritance********");
            Sun M = new Sun();
            M.SunDetails();
            M.FatherDetails();
            M.GrandFather();
            Console.WriteLine("************ Hierachical Inheritance********");
            Brother bro = new Brother();
            bro.BrotherDetails();
            bro.HierachicalDetails();
            Sister sis = new Sister();
            sis.sisterDetails();
            sis.HierachicalDetails();
            Console.ReadLine();

        }
    }
}
