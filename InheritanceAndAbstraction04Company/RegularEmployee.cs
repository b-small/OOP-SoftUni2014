using System;

namespace InheritanceAndAbstraction04Company
{
    abstract class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(string id, string fn, string ln, double sal, Departments dep)
            : base(id, fn, ln, sal, dep)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
