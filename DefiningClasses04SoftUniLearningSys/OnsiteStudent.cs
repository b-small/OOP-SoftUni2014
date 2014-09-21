using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses04SoftUniLearningSys
{
    class OnsiteStudent : CurrentStudent
    {

        private uint nrOfVisits;

        public OnsiteStudent(string fn, string ln, short a, long stNr, double avgGr, string currC, uint nrVis) : base (fn,ln,a,stNr,avgGr,currC)
        {
            this.NumberOfVisits = nrVis;
        }

        public uint NumberOfVisits
        {
            get { return this.nrOfVisits; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("NumberOfVisits", "Nr of visits cannot be negative or 0");
                }
                this.nrOfVisits = value;
            }
        }
    }
}
