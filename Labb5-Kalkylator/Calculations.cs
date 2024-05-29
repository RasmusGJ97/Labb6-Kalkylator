using Labb6_Kalkylator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5_Kalkylator
{
    public class Calculations
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Sign { get; set; }
        public double Result { get; set; }

        public Calculations AddCalculation(double num1, double num2, string sign, double result)
        {
            Calculations history = new Calculations()
            {
                Num1 = num1,
                Num2 = num2,
                Sign = sign,
                Result = result
            };
            return history;
        }
        public double Addition(double x, double y)
        {
            double result = x + y;
            return result;
        }

        public double Subtraktion(double x, double y)
        {
            double result = x - y;
            return result;
        }

        public double Division(double x, double y)
        {
            double result = x / y;
            return result;
        }

        public double Multiplikation(double x, double y)
        {
            double result = x * y;
            return result;
        }
    }
}
