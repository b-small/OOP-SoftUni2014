using System;

namespace InheritanceAndAbstraction04Company
{
    abstract class Employee : Person, IEmployee
    {
        private double salary;
        private Departments department;

        public Employee(string id, string fn, string ln, double sal, Departments dep)
            : base(id, fn, ln)
        {
            this.Salary = sal;
            this.Department = dep;
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.salary = value;
            }
        }

        public Departments Department
        {
            get { return this.department; }
            set
            {
                this.department = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\t Department: {0} Salary: {1:F2}", this.department,this.salary);
        }

    }
}
