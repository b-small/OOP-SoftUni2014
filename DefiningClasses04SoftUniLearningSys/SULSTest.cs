using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses04SoftUniLearningSys
{
    class SULSTest
    {
        private List<Person> softUniPeople;
        public SULSTest(List<Person> softUniPeople)
        {
            this.SoftUniPeople = softUniPeople;
        }

        public List<Person> SoftUniPeople
        {
            get { return this.softUniPeople; }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("SoftUniPeople", "SoftUni people list is empty!");
                }
                this.softUniPeople = value;
            }
        }

        public void ExtractCurrentStudents()
        {
            IEnumerable<CurrentStudent> currStudents = this.SoftUniPeople.Where(x => x is CurrentStudent).Cast<CurrentStudent>().Select(x => x);
            currStudents = currStudents.OrderByDescending(student => student.AverageGrade);
         
            foreach (var student in currStudents)
            {
                Console.WriteLine(string.Format("{0}", student));
            }
        }
        
    }
}
