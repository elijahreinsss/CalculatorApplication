using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);


    public class CalculatorClass
    {
        public Formula<double> formula;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Getdiff(double num1, double num2)
        {
            return num1 - num2;
        }
        public double GetMultiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double GetQuotient(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }

        public event Action CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
            }
        }
    }
}
    