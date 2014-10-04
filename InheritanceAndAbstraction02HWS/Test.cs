using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceAndAbstraction02HWS
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
                new Student("Mr.", "Muscule", "13542"),
                new Student("Dr.", "Alban", "13546"),
                new Student("Dr.", "Jekyll", "13555"),
                new Student("Dr.", "Ohboli", "13567"),
                new Student("Mr.", "Proper", "13562"),
                new Student("Ms", "Morkaflanelka", "13512"),
                new Student("Dr.", "Yoetker", "13135"),
                new Student("Dr.", "Radeva", "13548"),
                new Student("Svetlin", "Nakov", "111111"),
                new Student("Pamela", "Anderson", "1010010")
            };

            var byNameAscending = students
          .OrderBy(s => s.FacultyNr)
          .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, FacultyNr = s.FacultyNr });

            foreach (var s in byNameAscending)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", s.FirstName, s.LastName, s.FacultyNr));
            }
        }
    }
}
