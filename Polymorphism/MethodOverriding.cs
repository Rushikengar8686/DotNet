using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    public class MethodOverriding
    {
        //Run time polymorphism
        public virtual void sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }

    public class Dog : MethodOverriding
    {
        public override void sound()
        {
            Console.WriteLine("Bow.. bow");
        }
    }
    public class Cat : MethodOverriding
    {
        public override void sound()
        {
            Console.WriteLine("Mow... Mow");
        }
    }
}
