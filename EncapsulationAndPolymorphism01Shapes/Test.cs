using System;
using System.Collections.Generic;
using System.Linq;


namespace EncapsulationAndPolymorphism01Shapes
{
    class Test
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[]
            {
                new Rectangle(2,4),
                new Rectangle(1,5),
                new Triangle(4,5,90),
                new Triangle(5,5,30),
                new Circle(5),
                new Circle(3)
            };

            foreach (var s in shapes)
            {
                Console.WriteLine(string.Format("{0}, P = {1:F2}, S = {2:F2}", s.GetType().Name, s.CalculatePerimeter(), s.CalculateArea()));
            }
        }
    }
}
