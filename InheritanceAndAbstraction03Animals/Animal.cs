using System;

namespace InheritanceAndAbstraction03Animals
{
    abstract class Animal: ISound
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string n, int a, Gender g)
        {
            this.Name = n;
            this.Age = a;
            this.Gender = g;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.age = value;
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set
            {
                this.gender = value;
            }
        }

        public abstract void ProduceSound();
       
      
    }
}
