using System;

namespace InheritanceAndAbstraction02HWS
{
    class Student : Human
    {
        private string facNr;

        public Student(string fn, string ln, string fcn)
            : base(fn, ln)
        {
            this.FacultyNr = fcn;
        }

        public string FacultyNr
        {
            get { return this.facNr; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.facNr = value;
            }
        }
    }
}
