using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction01School
{
    class Class
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private string uid;

        public Class(List<Teacher> t, List<Student> s, string uid) 
        {
            this.Teachers = t;
            this.Students = s;
            this.Uid = uid;
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set
            {
                this.teachers = value;
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

        public string Uid
        {
            get { return this.uid; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.uid = value;
            }
        }
    }
}
