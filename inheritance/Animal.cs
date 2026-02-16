using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
     public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("That's Animal Eats Calls");
        }

    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine(" That's Dog Bark calls");
        }
    }
    
}
