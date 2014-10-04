using System;
using System.Collections.Generic;

namespace InheritanceAndAbstraction04Company
{
    class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects;

        public Developer(string id, string fn, string ln, double sal, Departments dep, List<Project> p)
            : base(id, fn, ln, sal, dep)
        {
            this.Projects = p;
        }

        public List<Project> Projects
        {
            get { return this.projects; }
            set
            {
                this.projects = value;
            }
        }
    }
}
