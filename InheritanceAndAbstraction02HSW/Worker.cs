using System;

namespace InheritanceAndAbstraction02HWS
{
    class Worker : Human
    {
        private double weekSalary;
        private short workHoursPerDay;

        public Worker(string fn, string ln, double ws, short whpd)
            : base(fn, ln)
        {
            this.WeekSalary = ws;
            this.WorkHoursPerDay = whpd;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.weekSalary = value;
            }
        }

        public short WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = (this.weekSalary / 5) / this.workHoursPerDay;
            return moneyPerHour;
        }
    }
}
