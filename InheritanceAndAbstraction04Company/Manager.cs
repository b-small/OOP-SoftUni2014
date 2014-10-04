using System;
using System.Collections.Generic;

namespace InheritanceAndAbstraction04Company
{
    class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(string id, string fn, string ln, double sal, Departments dep, List<Employee> emps)
            : base(id, fn, ln, sal, dep)
        {
            this.Employees = emps;
        }
        public List<Employee> Employees
        {
            get { return this.employees; }
            set
            {
                this.employees = value;
            }
        }

        public override string ToString()
        {
            string res = "Employees:\n";
            foreach (var e in employees)
            {
                res += e.ToString() + "\n";
            }
            return base.ToString() + res;
        }
    }
}
