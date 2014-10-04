using System;

namespace InheritanceAndAbstraction03Animals
{
    class Kitten : Cat
    {
          public Kitten(string name, int age)
            : base(name, age, Gender.Female)
        {
        }

         public override void ProduceSound()
         {
             Console.WriteLine("Oh myau cat, what a Tomcat myau myau");
         }

         public override string ToString()
         {
             return string.Format("I'm the {0}-year old {1} kitten {2} and i'm sexy", this.Age, this.Gender, this.Name);
         }
    }
}
