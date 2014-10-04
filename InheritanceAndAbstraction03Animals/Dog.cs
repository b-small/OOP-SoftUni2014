using System;

namespace InheritanceAndAbstraction03Animals
{
    class Dog : Animal
    {
         public Dog(string name, int age, Gender g)
            : base(name, age, g)
        {
        }

         public override void ProduceSound()
         {
             Console.WriteLine("Woooof woof, fatass!");
         }
         public override string ToString()
         {
             return string.Format("I'm the {0}-year old {1} dog {2}.", this.Age, this.Gender, this.Name);
         }
    }
}
