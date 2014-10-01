using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncProgramming02Student
{
    class StudentSpecialty
    {
        private string facNr;
        private string specName;

        public StudentSpecialty(string fn, string sn)
        {
            this.FacultyNr = fn;
            this.SpecialtyName = sn;
        }

        public string FacultyNr
        {
            get { return this.facNr; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.facNr = value;
            }
        }

        public string SpecialtyName
        {
            get { return this.specName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.specName = value;
            }
        }
    }
}
