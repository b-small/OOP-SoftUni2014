using System;

namespace DefiningClasses04SoftUniLearningSys
{
    class Person
    {
        private string fName;
        private string lName;
        private short age;

        public Person(string fn, string ln, short a)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Age = a;
        }

        public string FirstName
        {
            get { return this.fName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.fName = value;
            }
        }

        public string LastName
        {
            get { return this.lName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.lName = value;
            }
        }

        public short Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.age = value;
            }
        }
        
    }
}
