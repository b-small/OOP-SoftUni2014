using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses04SoftUniLearningSys
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string fn, string ln, short age)
            : base(fn, ln, age)
        {

        }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine(string.Format("{0} {1}, you've successfully deleted the course {2}.", this.FirstName, this.LastName, courseName));
        }
    }
}
