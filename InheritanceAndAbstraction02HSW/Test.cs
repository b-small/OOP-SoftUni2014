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
                new Student("Ms.", "WetTshirt", "13512"),
                new Student("Dr.", "Yoetker", "13135"),
                new Student("Dr.", "Radeva", "13548"),
                new Student("Svetlin", "Nakov", "111111"),
                new Student("Pamela", "Anderson", "1010010")
            };

            var byFacNr = students
          .OrderBy(s => int.Parse(s.FacultyNr))
          .Select(s => new Student(s.FirstName, s.LastName, s.FacultyNr));

            foreach (var s in byFacNr)
            {
                Console.WriteLine(string.Format("{0} {1}\t{2}", s.FirstName, s.LastName, s.FacultyNr));
            }

            List<Worker> workers = new List<Worker>() {

                new Worker("Baba", "Yaga", 100, 5),
                new Worker("Cingo", "Mingo", 50.5, 4),
                new Worker("Bai", "Ivan", 140, 7),
                new Worker("Chicho", "Suncho", 1780, 12),
                new Worker("Bai", "Blagoi", 370, 11),
                new Worker("Petkan", "P", 300, 7),
                new Worker("Makak", "Ne", 245, 8),
                new Worker("Taoing", "Tsu", 333, 4),
                new Worker("Bill", "Gates", 5, 9),
                new Worker("Ivana", "Kalpazana", 1000, 1)
            };

            Console.WriteLine();

            var bySalary = workers
                           .OrderByDescending(w => w.MoneyPerHour())
                           .Select(w => new Worker(w.FirstName, w.LastName, w.WeekSalary, w.WorkHoursPerDay));

            foreach (var w in bySalary)
            {
                Console.WriteLine(string.Format("{0} {1}\t{2:F2}", w.FirstName, w.LastName, w.MoneyPerHour()));
            }

            List<Human> people = new List<Human>();

            foreach (var s in students)
            {
                people.Add(s);
            }

            foreach (var w in workers)
            {
                people.Add(w);
            }

            Console.WriteLine();

            var byName = students
                         .OrderBy(s => s.FirstName)
                         .ThenBy(s => s.LastName).Select(s => new { FirstName = s.FirstName, LastName = s.LastName });

            foreach (var s in byName)
            {
                Console.WriteLine(string.Format("{0} {1}", s.FirstName, s.LastName));
            }

        }
    }
}
