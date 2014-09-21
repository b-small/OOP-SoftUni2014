using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses04SoftUniLearningSys
{
    class CurrentStudent : Student
    {
        private string currCourse;

        public CurrentStudent(string fn, string ln, short age, long stNr, double avgGr, string currC)
            : base(fn, ln, age, stNr, avgGr)
        {
            this.CurrentCourse = currC;
        }

        public string CurrentCourse
        {
            get { return this.currCourse; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("CurrentCourse", "No current course!");
                }
                this.currCourse = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Age: {2}, Number: {3}, Avg grade: {4}, Current course: {5}", this.FirstName, this.LastName, this.Age, this.StudentNr, this.AverageGrade, this.CurrentCourse);
        }
    }
}
