using System;

namespace InheritanceAndAbstraction04Company
{
    abstract class Person : IPerson
    {
        private string id;
        private string fName;
        private string lName;

        public Person(string id, string fn, string ln)
        {
            this.ID = id;
            this.FirstName = fn;
            this.LastName = ln;
        }

        public string FirstName
        {
            get { return this.fName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
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
                    throw new ArgumentNullException();
                }

                this.lName = value;
            }
        }

        public string ID
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.id = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}", this.id, this.fName, this.lName);
        }
    }
}
