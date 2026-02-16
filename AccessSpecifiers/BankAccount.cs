using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessSpecifiers
{
    class BankAccount
    {
        public long AccountNo;
        public String holderName;
        private int balance = 20000;

        // to Access Private Variable

        public void checkBal()
        {
            Console.WriteLine("check Balance "+balance);
        }
    }
}
