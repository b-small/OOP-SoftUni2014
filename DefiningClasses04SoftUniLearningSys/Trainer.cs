using System;


namespace DefiningClasses04SoftUniLearningSys
{
    class Trainer : Person
    {
        public Trainer(string fn, string ln, short a) : base(fn, ln, a) 
        {

        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine(string.Format("{0} {1}, you now created the course {2}.", this.FirstName, this.LastName, courseName));
        }
    }
}
