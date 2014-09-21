using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses04SoftUniLearningSys
{
    class Student : Person
    {
        private long stNumber;
        private double avgGrade;

        public Student(string fn, string ln, short age, long stNr, double avgg) : base(fn,ln,age)
        {
            this.StudentNr = stNr;
            this.AverageGrade = avgg;
        }

        public long StudentNr
        {
            get { return this.stNumber; }
            set
            {
                if (value < 0 || value > long.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("StudentNr", "Student nr out of range");
                }
                this.stNumber = value;
            }
        }

        public double AverageGrade
        {
            get { return this.avgGrade; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("grade cannot be negative");
                }
                this.avgGrade = value;
            }
        }
    }
}
