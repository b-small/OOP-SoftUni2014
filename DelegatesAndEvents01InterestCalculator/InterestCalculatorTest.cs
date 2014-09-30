using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents01InterestCalculator
{
    class InterestCalculatorTest
    {

        public static double GetSimpleInterest(double sum, double interest, int years)
        {
            double si = sum * (double)(1 + (interest / 100) * years);
            return si;
        }

        public static double GetCompoundInterest(double sum, double interest, int years)
        {
            double ci = sum * Math.Pow(1 + ((interest / 100) / 12), years * 12);
            return ci;
        }

        static void Main(string[] args)
        {
            InterestCalculator ic = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine(ic);
            ic = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine(ic);
        }
    }
}
