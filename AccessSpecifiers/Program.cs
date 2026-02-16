using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessSpecifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now create Employee Object
            Employee EmpInfo = new Employee();
            EmpInfo.EmpName = "Rushi";
            EmpInfo.displayDetails();

            empDetails showAds = new empDetails();
            showAds.showEmployeeAddress();
            Console.WriteLine(EmpInfo.EmpName);
            Console.WriteLine("***************** Account Task using Access Specifier *********************");
            BankAccount Details = new BankAccount();
            Details.checkBal();
            Details.AccountNo = 07710110004323;
            Details.holderName = "Rushikesh Kengar";
            
            Console.WriteLine("Account HolderName is " + Details.holderName);
            Console.WriteLine("Show Account No " + Details.AccountNo);




            Console.ReadLine();
            
        }
    }
}
