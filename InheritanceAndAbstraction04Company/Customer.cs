using System;

namespace InheritanceAndAbstraction04Company
{
    class Customer : Person, ICustomer
    {
        private double npAmount;

        public Customer(string id, string fn, string ln, double npa)
            : base(id, fn, ln)
        {
            this.NetPurchaseAmount = npa;
        }
        public double NetPurchaseAmount
        {
            get { return this.npAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.npAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Net Purchase amount: {0:F2}", this.npAmount);
        }

    }
}
