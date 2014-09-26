using System;

namespace OtherTypes02FractionCalc
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long num, long denom)
            : this()
        {
            this.Numerator = num;
            this.Denominator = denom;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArithmeticException("Denominator cannot be zero.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator -(Fraction fr0, Fraction fr1)
        {
            checked
            {
                long numer = fr0.numerator * fr1.denominator - fr1.numerator*fr0.denominator;
                long denom = fr0.denominator * fr1.denominator;
                return new Fraction(numer, denom);
            }
        }

        public static Fraction operator +(Fraction fr0, Fraction fr1)
        {
            checked
            {
                long numer = fr0.numerator * fr1.denominator + fr1.numerator * fr0.denominator;
                long denom = fr0.denominator * fr1.denominator;
                return new Fraction(numer, denom);
            }
        }

        public override string ToString()
        {
            return ((decimal)numerator /denominator).ToString();
        }
    }
}
