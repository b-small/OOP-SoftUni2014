using System;

namespace InheritanceAndAbstraction03Animals
{
    class Cat : Animal
    {
        public Cat(string name, int age, Gender g)
            : base(name, age, g)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Myaayauauaauuuuurrrhrhrh rhhhrh rhhrhhh");
        }

        public override string ToString()
        {
            return string.Format("I'm the {0}-year old {1} cat {2}.", this.Age, this.Gender, this.Name);
        }
        
    }
}
