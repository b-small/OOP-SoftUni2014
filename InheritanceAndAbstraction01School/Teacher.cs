using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction01School
{
    class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disc)
            : base(name)
        {
         
        }
    }
}
