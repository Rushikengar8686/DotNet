using System;


namespace ConsoleApplication2
{
    class classAndObject
    {
        // First Create Normal Class
        class Student {
            public String StudName;
            public int Age;
            public int rollNo;
            public char className;
          
        }

        // Second Create class with constructor
        class Employee
        {
            public String EmpName;
            public int Age;
            public bool isParmant;
            public String address;

            // now create Employee constructor 
            public Employee(String empName, int age, bool isParmant, String Address)
            {
                EmpName = empName;
                Age = age;
                isParmant = isParmant;
                address = Address;
            }
        }

        static void Main(string[] args)
        {
            // First Way to Create Object
            // Create a student class object
            Student stud = new Student();
            stud.StudName = "Rushi";
            stud.Age = 26;
            stud.rollNo = 1;
            stud.className = 'A';
            Console.WriteLine("My name is " + stud.StudName + " and i am " + stud.Age + " year old");

            // Second Way to Create Object like This

            Student studInfo = new Student()
            {
                StudName = "Ram",
                Age = 23,
                rollNo = 323,
                className = 'A'
            };
            Console.WriteLine(studInfo.StudName);
            // now create Employee class object
            Employee empInfo = new Employee("Rushikesh", 26, true, "Pune");
            Console.WriteLine("print Employee Information");
            Console.WriteLine(empInfo.EmpName);
            Console.WriteLine(empInfo.Age);
            Console.WriteLine(empInfo.isParmant);
            Console.WriteLine(empInfo.address);
            Console.ReadLine();
        }
    }
}
