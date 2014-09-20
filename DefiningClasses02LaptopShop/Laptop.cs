using System;
using System.Text;

namespace DefiningClasses02LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int? ram;
        private string gCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double? batteryLife;
        private double price;


        public Laptop(string mod, string manu, string proc, int? ram, string gc, string h, string scr, Battery b, double? bl, double p)
        {
            this.Model = mod;
            this.Manufacturer = manu;
            this.Processor = proc;
            this.RAM = ram;
            this.GraphicsCard = gc;
            this.HDD = h;
            this.Screen = scr;
            this.Batt = b;
            this.BattLife = bl;
            this.Price = p;

        }

        public Laptop(string mod, double price)
            : this(mod, null, null, null, null, null, null, null, null, price)
        {

        }
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.manufacturer = null;
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.processor = null;
                }
                this.processor = value;
            }
        }

        public int? RAM
        {
            get { return this.ram; }
            set
            {
                if (value <= 0)
                {
                    this.ram = null;
                }
                else
                {
                    this.ram = value;
                }
            }
        }

        public string GraphicsCard
        {
            get { return this.gCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.gCard = null;
                }
                this.gCard = value;
            }
        }

        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.hdd = null;
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.screen = null;
                }
                this.screen = value;
            }
        }

        public Battery Batt
        {
            get { return this.battery; }
            set
            {
                this.battery = value;
            }
        }
        public double? BattLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value <= 0)
                {
                    this.batteryLife = null;
                }
                else
                {
                    this.batteryLife = value;
                }
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    this.price = 0;
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder laptopInfo = new StringBuilder();
            laptopInfo.AppendLine("Laptop description ");
            laptopInfo.AppendLine("model: " + this.Model);

            if (this.Manufacturer != null)
            {
                laptopInfo.AppendLine("manufacturer: " + this.Manufacturer);
            }

            if (this.Processor != null)
            {
                laptopInfo.AppendLine("processor: " + this.Processor);
            }

            if (this.RAM != null)
            {
                laptopInfo.AppendLine("RAM: " + this.RAM + " GB");
            }

            if (this.GraphicsCard != null)
            {
                laptopInfo.AppendLine("graphics card: " + this.GraphicsCard);
            }

            if (this.HDD != null)
            {
                laptopInfo.AppendLine("HDD: " + this.HDD);
            }

            if (this.Screen != null)
            {
                laptopInfo.AppendLine("screen: " + this.Screen);
            }

            if (this.Batt != null)
            {
                laptopInfo.AppendLine("battery: " + this.Batt);
            }
            if (this.BattLife != null)
            {
                laptopInfo.AppendLine("battery life: " + this.BattLife + " hours");
            }
            string p = string.Format("price: {0:00} lv.", this.Price);

            laptopInfo.AppendLine(p);

            return laptopInfo.ToString();
        }

    }
}
