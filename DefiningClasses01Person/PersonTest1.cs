using System;


namespace DefiningClasses01Person
{
    class PersonTest1
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person("Pesho", 25, "whaaat@shit.bg");
                Person p1 = new Person("IVan", 24);
                //Person p2 = new Person("Pesho", 25, "whaaatshit.bg");
                //Person p3 = new Person("IVan", 245);

                Console.WriteLine(p);
                Console.WriteLine(p1);
                //Console.WriteLine(p2);
                // Console.WriteLine(p3);
            }
            catch (Exception e)
            {
                Console.WriteLine("Why");
            }
        }
    }
}
