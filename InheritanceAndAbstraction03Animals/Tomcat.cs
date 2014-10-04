using System;

namespace InheritanceAndAbstraction03Animals
{
    class Tomcat : Cat
    {
          public Tomcat(string name, int age)
            : base(name, age, Gender.Male)
        {
        }

         public override void ProduceSound()
         {
             Console.WriteLine("Rrrrrrrr RMYAU I'm a mannn!!!! HSS hsshshss");
         }

         public override string ToString()
         {
             return string.Format("I'm the {0}-year old {1} tomcat {2}.I like Kittens.", this.Age, this.Gender, this.Name);
         }
    }
}
