using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncProgramming02Student
{
    class Student
    {
        private string fName;
        private string lName;
        private int age;
        private string facNr;
        private string phone;
        private string email;
        private IList<int> marks;
        private short gNumber;
        private string gName;

        public Student(string fn, string ln, int a, string fan, string p, string e, IList<int> m, short gn, string gname)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Age = a;
            this.FacultyNr = fan;
            this.Phone = p;
            this.Email = e;
            this.Marks = m;
            this.GroupNr = gn;
            this.GroupName = gname;
        }

        public string FirstName
        {
            get { return this.fName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.fName = value;
            }
        }

        public string LastName
        {
            get { return this.lName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.lName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.age = value;
            }
        }

        public string FacultyNr
        {
            get { return this.facNr; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.facNr = value;
            }
        }

        public string Phone
        {
            get { return this.phone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.phone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.email = value;
            }
        }

        public IList<int> Marks
        {
            get { return this.marks; }
            set
            {
                this.marks = value;
            }
        }

        public short GroupNr
        {
            get { return this.gNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.gNumber = value;
            }
        }

        public string GroupName
        {
            get { return this.gName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.gName = value;
            }
        }

        public static void PrintByGroup(short g, List<Student> students)
        {
            var group =
                from student in students
                where student.GroupNr == 2
                orderby student.FirstName
                select student;

            foreach (var s in group)
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }
        }

        public static void printByFAndLName(List<Student> students)
        {
            var byNames =
             from student in students
             where String.Compare(student.FirstName, student.LastName) < 0
             select student;

            foreach (var s in byNames)
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }
        }

        public static void printByAge(List<Student> students)
        {
            var byAge =
                from student in students
                where (student.Age >= 18 && student.Age <= 24)
                select student;
            Console.WriteLine("Students btw 18 and 24:");
            foreach (var s in byAge)
            {
                Console.WriteLine(string.Format("{0} {1}, Age: {2}", s.FirstName, s.LastName, s.Age));
            }

        }

        public static void SortStudents(List<Student> students)
        {
            var byNameDescending = students
           .OrderByDescending(s => s.FirstName)
           .ThenByDescending(s => s.LastName).Select(s => new { FirstName = s.FirstName, LastName = s.LastName });

            foreach (var s in byNameDescending)
            {
                Console.WriteLine(string.Format("{0} {1}", s.FirstName, s.LastName));
            }
        }

        public static void SortStudentsWithQuery(List<Student> students)
        {
            var withQuery =
                from s in students
                orderby s.FirstName descending, s.LastName descending
                select new { FirstName = s.FirstName, LastName = s.LastName };

            foreach (var s in withQuery)
            {
                Console.WriteLine(string.Format("{0} {1}", s.FirstName, s.LastName));
            }
        }

        public static void ByEmail(List<Student> students)
        {
            var abvUsers =
                from s in students
                where s.Email.EndsWith("@abv.bg")
                select s;
            Console.WriteLine("Abv.bg users: ");
            foreach (var s in abvUsers)
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }
        }

        public static void ByPhone(List<Student> students)
        {
            var sofia =
                from s in students
                where (s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592") || s.Phone.StartsWith("+359 2"))
                select s;

            Console.WriteLine("Students from Sofia: ");
            foreach (var s in sofia)
            {
                Console.WriteLine(string.Format("{0} {1}", s.FirstName, s.LastName));
            }
        }

        public static void IsExcellent(List<Student> students)
        {
            var excellentStudents =
           from s in students
           where s.Marks.Contains(6)
           select new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks };

            Console.WriteLine("Excellent students:");
            foreach (var s in excellentStudents)
            {
                var currentMarks = string.Join(", ", s.Marks.Select(x => x.ToString()).ToArray());
                Console.WriteLine(s.FullName + "\nMarks: " + currentMarks);
            }
        }

        // No idea for the extension methods ? 

        public static void IsWeak(List<Student> students)
        {
            var futureHobos = students
       .Where(s => s.Marks.Aggregate(0, (counter, mark) => counter + (mark == 2 ? 1 : 0)) == 2)
       .Select(s => s.FirstName + " " + s.LastName);

            Console.WriteLine("Weak students: ");
            foreach (var student in futureHobos)
            {
                Console.WriteLine(student);
            }
        }

        public static void ByEnrollmentYear(List<Student> students, int year)
        {
            var studs =
                from s in students
                where (s.FacultyNr[4] == year.ToString()[0] && s.FacultyNr[5] == year.ToString()[1])
                select s;

            Console.WriteLine("Notes of students, enrolled in year '{0}", year);
            foreach (var s in studs)
            {
                Console.WriteLine(string.Join(", ", s.Marks.Select(x => x.ToString()).ToArray()));
            }
        }

        public static void ByGroupName(List<Student> students)
        {
            var byGroupName =
                from st in students
                group st by st.GroupName into g
                orderby g.Key
                select new { GroupName = g.Key, students = g.ToList() };

            Console.WriteLine("\nStudents by Group name: ");
            foreach (var item in byGroupName)
            {
                Console.WriteLine("\nGROUP {0} ", item.GroupName);
                Console.WriteLine("{0}", string.Join("\n", item.students));
            }
        }

        public static void BySpecialty(List<Student> students, List<StudentSpecialty> specialties)
        {
            var studentsJoinedBySpecialties = students
       .Join(specialties,
           s => s.FacultyNr,
           sp => sp.FacultyNr,
           (s, sp) =>
               new
               {
                   FullName = s.FirstName + " " + s.LastName,
                   FacultyNumber = s.FacultyNr,
                   Specialty = sp.SpecialtyName
               })
       .OrderBy(s => s.FullName);

            Console.WriteLine("Students joined by Specialties: ");
            foreach (var student in studentsJoinedBySpecialties)
            {
                Console.WriteLine("{0}, {1}, {2}", student.FullName, student.FacultyNumber, student.Specialty);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, Age: {2}\nFaculty nr: {3}\nPhone: {4}\nE-mail: {5}\nGroup: {6}", this.FirstName, this.LastName, this.Age, this.FacultyNr, this.Phone, this.Email, this.GroupNr);
        }
    }
}
