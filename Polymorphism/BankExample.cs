using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    public class BankExample
    {
        public virtual double CalculateIntrest(double principal, int years, double rate)
        {
            return (principal * rate * years) / 100;
        }
    }
    public class SavingAccount : BankExample
    {
        public override double CalculateIntrest(double principal, int years, double rate)
        {
             return base.CalculateIntrest(principal, years, rate);
        }
    }
    public class currentAccount : BankExample
    {
        public override double CalculateIntrest(double principal, int years, double rate)
        {
            return 0;
        }

    }
}
