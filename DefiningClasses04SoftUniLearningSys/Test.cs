using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses04SoftUniLearningSys
{
    class Test
    {
        static void Main(string[] args)
        {
          
                Trainer one = new Trainer("Ivan", "Ivanov", 27);
                SeniorTrainer onee = new SeniorTrainer("Dragan", "Draganov", 45);
                CurrentStudent c1 = new CurrentStudent("Pesho", "Petrov", 12, 1324, 5.7, "JavaScript");
                CurrentStudent c2 = new CurrentStudent("Petka", "Petkova", 35, 1244, 3.2, "OOP");
                CurrentStudent c3 = new CurrentStudent("Stefka", "Stefkova", 72, 1245, 3.00, "Java");
                OnsiteStudent o1 = new OnsiteStudent("Dimitrii", "Dimitrievich", 45, 1246, 5.6, "Java", 120000);
                OnsiteStudent o2 = new OnsiteStudent("Aleks", "Aleksiev", 23, 1247, 4.5, "C#", 13506);
                DropoutStudent ds1 = new DropoutStudent("Fail", "Failure", 21, 1256, 3.1, "Dumb");
                DropoutStudent ds2 = new DropoutStudent("MegaFail", "Failure", 17, 1258, 3.85, "Too much LOL");
                DropoutStudent ds3 = new DropoutStudent("WtfMan", "Failure", 36, 1259, 5.7, "Lazy");

                one.CreateCourse("QC");
                onee.DeleteCourse("PHP");
                onee.CreateCourse("C#");
                Console.WriteLine();
                ds1.Reapply();

                List<Person> softUniPeople = new List<Person>{
                one,
                onee,
                c1,
                c2,
                c3,
                o1,
                o2,
                ds1,
                ds2,
                ds3
            };
                Console.WriteLine();
                SULSTest test = new SULSTest(softUniPeople);
                test.ExtractCurrentStudents();
       
        }
    }
}
