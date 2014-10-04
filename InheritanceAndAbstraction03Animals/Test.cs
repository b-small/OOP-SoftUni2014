using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction03Animals
{
    class Test
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] { 
            new Cat("Stamat", 12, Gender.Male),
            new Kitten("Safrida", 6),
            new Frog("Keleme", 3, Gender.Male),
            new Dog("Buki", 7, Gender.Male),
            new Dog("Isperih", 5, Gender.Male),
            new Tomcat("Ikonostas", 2),
            new Frog("Mara", 6, Gender.Female),
            new Frog("Miro", 6, Gender.Male),
            new Frog("Marda", 6, Gender.Female),
            new Dog("Ginko", 13, Gender.Male),
            new Kitten("Pena", 2),
            new Kitten("Gana", 3),
            new Tomcat("Ganio", 5),
            new Tomcat("Vanio", 7)
            };


            var groupedAnimals = from animal in animals
                                 group animal by (animal is Cat) ? typeof(Cat) : animal.GetType() into g
                                 select new { GroupName = g.Key, AverageAge = g.ToList().Average(an => an.Age) };

            foreach (var animal in groupedAnimals)
            {
                Console.WriteLine("{0} - average age - {1:N2}", animal.GroupName.Name, animal.AverageAge);
            }


        }
    }
}
