﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncProgramming02Student
{
    class StudentTest
    {
        static void Main(string[] args)
        {

            Student uno = new Student("Georgi", "Parvanov", 73, "135444", "04815522", "gepi@gbg.bg", new List<int>() { 3, 4, 3 }, 1, "B");
            Student dos = new Student("Volen", "Siderov", 12, "135414", "04815522", "istinski_muj@ahaha.bg", new List<int>() { 5, 6, 6 }, 2, "A");
            Student tres = new Student("Nikolay", "Barekov", 11, "135446", "04815522", "neSteSami@gbg.bg", new List<int>() { 1, 3, 7 }, 2, "A");
            Student cuatro = new Student("Tsvetanka", "Rizova", 23, "135447", "0215522", "wiwiw@abv.bg", new List<int>() { 3, 4, 5 }, 1, "B");
            Student cinco = new Student("Sehrgay", "Stanishev", 20, "135814", "02155232", "la@abv.bg", new List<int>() { 2, 2, 5 }, 1, "B");
            List<Student> students = new List<Student>() { uno, dos, tres, cuatro, cinco };

            Student.PrintByGroup(2, students); // task 04
            Student.printByFAndLName(students); // task 05
            Student.printByAge(students); // task 06
            Student.SortStudents(students); // task 07
            Student.SortStudentsWithQuery(students);
            Student.ByEmail(students); // task 08
            Student.ByPhone(students); // task 09
            Student.IsExcellent(students); // task 10
            Student.IsWeak(students); // task 11
            Student.ByEnrollmentYear(students, 14); // task 12
            Student.ByGroupName(students); // task 13


            StudentSpecialty first = new StudentSpecialty("135414", "Lies");
            StudentSpecialty sec = new StudentSpecialty("135814", "Lies");
            StudentSpecialty thrd = new StudentSpecialty("135446", "Lies");
            StudentSpecialty frth = new StudentSpecialty("135447", "NothingToDoHere");
            StudentSpecialty ffth = new StudentSpecialty("135444", "NothingToDoHere");
            List<StudentSpecialty> specialties = new List<StudentSpecialty>() { first, sec, thrd, frth, ffth };

            Student.BySpecialty(students, specialties); // task 14

        }
    }
}
