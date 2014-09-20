using System;

namespace DefiningClasses02LaptopShop
{
    class LaptopTest
    {
        static void Main(string[] args)
        {
            try
            {
                Battery b = new Battery(BatteryType.NiCad, 4, 2550);
                Laptop lap = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", b, 4.7, 2259.00);
                Laptop lap1 = new Laptop("Asus", 25);

                Console.WriteLine(lap);
                Console.WriteLine(lap1);

            }
            catch (Exception e)
            {
                Console.WriteLine("why?");
            }
        }
    }
}
