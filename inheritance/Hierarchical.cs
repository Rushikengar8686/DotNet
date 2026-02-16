using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    public class Hierarchical
    {
        public String MotherName = "Sunita";
        public String SurName = "Kengar";
        public void HierachicalDetails()
        {
            Console.WriteLine("My Mother Name is "+ MotherName+" "+SurName);
        }
    }
    public class Sister: Hierarchical
    {
        public String SisterFirstname = "pooja";
        public void sisterDetails()
        {
            Console.WriteLine("My full is "+SisterFirstname+" "+SurName);
        }
    }

    public class Brother : Hierarchical
    {
        public String brotherFirstName = "Rushi";
        public void BrotherDetails()
        {
            Console.WriteLine("My Full Name is " + brotherFirstName + " " + SurName);
        }
    }

}
