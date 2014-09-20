using System;
using System.Text;


namespace DefiningClasses01Person
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string n, int a, string e) {
            this.Name = n;
            this.Age = a;
            this.Email = e;
        }

        public Person(string n, int a) : this(n, a, null) {

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
                else
                {
                    this.name = value;
                } 

            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null && !value.Contains("@")) {
                    throw new ArgumentException();
                }
                this.email = value;
            }
        }

        public override string ToString() {
            
            string result;

            if (string.IsNullOrEmpty(this.Email)) {
                result = string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
            } else {
                result = string.Format("Name: {0}, Age: {1}, E-mail: {2}", this.Name, this.Age, this.Email);
            }
            return result;
        }

    }
}
