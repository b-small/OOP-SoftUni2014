using System;
using System.Collections.Generic;


namespace DefiningClasses03PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
 
            List<Component> l = new List<Component>();
            Computer first = new Computer("Asus", l);
            Computer second = new Computer("Lenovo", l);
            first.AddComponent(new Component("ram", "8GB", 40));
            first.AddComponent(new Component("graphics card", "IntelHD Graphics 4600", 120.49));
            first.AddComponent(new Component("motherboard", "Intel Z97 TUF", 459.90));
            second.AddComponent(new Component("motherboard", "Socket AM3+ MSI 970A-G43", 140.45));
            second.AddComponent(new Component("hdd", "128GB SSD", 230.32));
            second.AddComponent(new Component("battery", "Li-ion, 4-cells, 2550mAh", 160.45));

            first.displayInfo();
            Console.WriteLine();
            second.displayInfo();
         }
    }
}
