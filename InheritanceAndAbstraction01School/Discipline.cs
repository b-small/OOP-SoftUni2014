using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction01School
{
    abstract class Discipline
    {
        private string name;
        private int nrOfLectures;
        private List<Student> students;

        public Discipline(string n, int nrOfL, List<Student> s)
        {
            this.Name = n;
            this.NumberOfLectures = nrOfL;
            this.Students = s;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.nrOfLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.nrOfLectures = value;
            }
        }
        public List<Student> Students
        {
            get { return this.students; }
            set
            {
                this.students = value;
            }
        }
    }
}
