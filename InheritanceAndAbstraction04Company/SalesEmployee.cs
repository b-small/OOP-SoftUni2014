using System;
using System.Collections.Generic;

namespace InheritanceAndAbstraction04Company
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(string id, string fn, string ln, double sal, Departments dep, List<Sale> ss)
            : base(id, fn, ln, sal, dep)
        {
            this.Sales = ss;
        }
        public List<Sale> Sales
        {
            get { return this.sales; }
            set
            {
                this.sales = value;
            }
        }

        public override string ToString()
        {
            string res = "";
            foreach (var s in sales)
            {
                res += s.ToString() + "\n";
            }
            return base.ToString() + res;
        }

    }
}
