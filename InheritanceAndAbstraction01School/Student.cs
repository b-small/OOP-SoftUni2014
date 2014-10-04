using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction01School
{
    class Student:Person
    {
        private int number;

        public Student(string name, int nr)
            : base(name)
        {
            this.Number = nr;
        }

        public int Number
        {
            get { return this.number; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.number = value;
            }
        }
    }
}
