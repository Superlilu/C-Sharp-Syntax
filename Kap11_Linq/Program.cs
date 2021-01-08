using System;
using System.Collections.Generic;
using System.Linq;

namespace Kap11_Linq
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //    //--------------------------------------------------------------
        //    //string[] names = {"Peter","Tanja","tobias","Luise", "Uwe"};
        //    //var linqTest = from name in names
        //    //               where name.Contains('t')
        //    //               select name;

        //    //var linqTest2 = names.Where(name => name.Contains('t'));


        //    ////names[0] = "tanja";

        //    //foreach (string name in linqTest)
        //    //{
        //    //    Console.WriteLine(name);
        //    //}

        //    //Console.ReadKey();
        //    //--------------------------------------------------------------

        //    List<Student> studentenListe = new List<Student>();
        //    studentenListe.Add(new Student(Studiengang.Biologie, 3, "Sabine", "Vogel"));
        //    studentenListe.Add(new Student(Studiengang.Informatik, 5, "Patrick", "Müller"));
        //    studentenListe.Add(new Student(Studiengang.Germanistik, 4, "Kurt", "Meier"));
        //    studentenListe.Add(new Student(Studiengang.Informatik, 1, "Anna", "Kohl"));
        //    studentenListe.Add(new Student(Studiengang.Mathematik, 2, "Sebastina", "Müller"));

        //    var informationStudenten = from student in studentenListe
        //                               where (student.Studiengang == Studiengang.Informatik) && (student.Semester < 4)
        //                               select student;

        //    foreach (Student student in informationStudenten)
        //    {
        //        Console.WriteLine(student.ToString());
        //    }

        //    Console.WriteLine();
        //}
    }

    enum Studiengang
    {
        Informatik,
        Biologie,
        Germanistik,
        Mathematik
    }
    class Student
    {
        public Studiengang Studiengang { get; set; }
        public int Semester { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Student (Studiengang studiengang, int semester, string vorname, string nachname)
        {
            Studiengang = studiengang;
            Semester = semester;
            Vorname = vorname;
            Nachname = nachname;
        }

        public override string ToString()
        {
            return Vorname + " " + Nachname + " " + Studiengang + " " + Semester + " Semester";
        }
    }
}
