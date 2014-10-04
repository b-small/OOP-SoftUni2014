using System;

namespace InheritanceAndAbstraction03Animals
{
    class Frog : Animal
    {
       public Frog(string name, int age, Gender g)
            : base(name, age, g)
        {
        }

         public override void ProduceSound()
         {
             Console.WriteLine("Quackkk, quack quack");
         }

         public override string ToString()
         {
             return string.Format("I'm the {0}-year old {1} frog {2}.", this.Age, this.Gender, this.Name);
         }
    }
}
