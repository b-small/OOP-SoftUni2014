using System;


namespace DefiningClasses03PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private double price;

        public Component(string n, string det, double p)
        {
            this.Name = n;
            this.Details = det;
            this.Price = p;
        }

        public Component(string n, double p) : this(n, null, p) {

    }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.details = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            string res = string.Format("Name: {0}, ", this.Name);
            
            if (this.Details != null)
            {
                res += string.Format("Details: {0}, ", this.Details);
            }
           
                res += string.Format("Price: {0:0.00} BGN", this.Price);
           
            return res;
        }
   }
}
