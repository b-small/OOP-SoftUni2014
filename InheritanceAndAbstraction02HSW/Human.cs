
using System;
namespace InheritanceAndAbstraction02HWS
{
    abstract class Human
    {
        private string fName;
        private string lName;

        public Human(string fn, string ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }

        public string FirstName {
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
    }
}
