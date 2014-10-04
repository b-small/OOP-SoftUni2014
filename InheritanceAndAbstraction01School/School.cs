using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction01School
{
    class School
    {
        private List<Class> classes;

        public School() : this(null)
        { 
        }

        public School(List<Class> c)
        {
            this.Classes = c;
        }

        public List<Class> Classes
        {
            get { return this.classes; }
            set
            {
                this.classes = value;
            }
        }
    }
}
