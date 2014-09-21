using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses04SoftUniLearningSys
{
    class DropoutStudent : Student
    {
        private string dReason;

        public DropoutStudent(string fn, string ln, short a, long stNr, double avgGr, string dr)
            : base(fn, ln, a, stNr, avgGr)
        {
            this.DropoutReason = dr;
        }

        public string DropoutReason
        {
            get { return this.dReason; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("DropoutReason", "no dropout reason entered");
                }
                this.dReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine(string.Format("First name: {0} \nLast name: {1}\nAge: {2}\nStudent number: {3}\nAverage grade: {4:0.00}\nDropout reason: {5}", this.FirstName, this.LastName, this.Age, this.StudentNr, this.AverageGrade, this.DropoutReason));
        }
    }
}
