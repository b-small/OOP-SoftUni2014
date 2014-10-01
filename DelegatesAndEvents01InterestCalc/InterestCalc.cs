using System;

public delegate double CalculateInterest(double sum, double interest, int years);

    class InterestCalc
    {
        

        public double GetSimpleInterest(double sum, double interest, int years)
        {
            double si = sum * (1 + (interest * years/100));
            return si;
        }

        public double GetCompoundInterest(double sum, double interest, int years)
        {
            double ci = sum * Math.Pow(1 + (interest / 100 / 12), years * 12);
            return ci;
        }
    }

