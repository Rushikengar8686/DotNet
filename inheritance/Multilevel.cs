using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    public class Multilevel
    {
        public void GrandFather()
        {
            Console.WriteLine("This is a Grand Father Method");
        }
    }
    class Father : Multilevel
    {
        public void FatherDetails()
        {
            Console.WriteLine("This is a Father Method");
        }
    }

    class Sun : Father
    {
        public void SunDetails()
        {
            Console.WriteLine("This is a sun Method");
        }
    }
}
