using System;

namespace OtherTypes01GalacticGPS
{
    class LocationTest
    {
        static void Main(string[] args)
        {
            Location l0 = new Location(18.037986, 28.870097, Planet.Earth);
            Location l1 = new Location(-4, -243.645, Planet.Venus);

            Console.WriteLine(l0);
            Console.WriteLine(l1);
        }
    }
}
