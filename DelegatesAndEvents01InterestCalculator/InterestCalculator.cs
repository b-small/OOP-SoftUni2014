using System;
using System.Runtime.Remoting.Messaging;

namespace DelegatesAndEvents01InterestCalculator
{
    public delegate double CalculateInterest(double sum, double interest, int years);

    class InterestCalculator
    {
        private double sum;
        private double interest;
        private int years;
        private CalculateInterest ci;

        public InterestCalculator(double s, double i, int y, CalculateInterest type)
        {
            this.sum = s;
            this.interest = i;
            this.years = y;
            this.ci = type;
        }

        public override string ToString()
        {
            return string.Format("{0:F4}", this.ci(this.sum, this.interest, this.years));
        }
    }
}
