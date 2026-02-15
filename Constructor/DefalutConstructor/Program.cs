using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefaultConstructor
{
    class Program
    {

        // Default Constructor
        class student
        {
            public String name;
            public int rollNo;

            public student()
            {
                name = "Rushi";
                rollNo = 12;
            }
            static void Main(string[] args)
            {
                student stud = new student();
                Console.WriteLine(stud.name);
                Console.ReadLine();
            }
        }
    }
}
