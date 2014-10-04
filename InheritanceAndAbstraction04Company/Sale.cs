using System;

namespace InheritanceAndAbstraction04Company
{
    class Sale
    {
        private string prName;
        private string date;
        private double price;

        public Sale(string pn, string d, double p)
        {
            this.ProductName = pn;
            this.Date = d;
            this.Price = p;
        }

        public string ProductName {
            get { return this.prName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.prName = value;
            }
            }

        public string Date
        {
            get { return this.date; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.date = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2:F2}", this.date, this.prName, this.price);
        }
    }
}
