using System;
using System.Collections.Generic;
namespace DefiningClasses03PCCatalog
{
    class Computer
    {
        private string name;
        private double price;
        private List<Component> components = new List<Component>{ };

        public Computer(string n, List<Component> c)
        {
            this.Name = n;
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

        public List<Component> Components { get { return this.components; } }
        public void AddComponent(Component c)
        {
            this.components.Add(c);
        }

        public void findTotalPrice()
        {
            double total = 0;
            foreach (Component c in this.components)
            {
                total += c.Price;
            }
            this.Price = total;
           
        }

        public void displayInfo()
        {
            string info = string.Format("name: {0}\n", this.Name);
            foreach (Component c in this.Components)
            {
                info += c.ToString();
                info += "\n";
            }
            findTotalPrice();
            info += string.Format("total price: {0:0.00} BGN", this.Price);
            Console.WriteLine(info);
        }
    }
}
