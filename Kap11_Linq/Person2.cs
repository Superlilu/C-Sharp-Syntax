using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kap11_Linq
{
    class Programm
    {
        //static void Main(string[] args)
        //{
        //    List<Person> personList = new List<Person>();
        //    personList.Add(new Person(20, "Benjamin", "Kohl", "Programmier"));
        //    personList.Add(new Person(19, "Benjamin", "Blume", "Bäcker"));
        //    personList.Add(new Person(22, "Alina", "Müller", "Programmier"));
        //    personList.Add(new Person(43, "Daniela", "Kohl", "Bäcker"));
        //    personList.Add(new Person(27, "Carlos", "Sanchez", "Maler"));

        //    //var groupQuery = from person in personList
        //    //                 group person by person.Job;

        //    var groupQuery = personList.GroupBy(person => person.Job);

        //    foreach (var group in groupQuery)
        //    {
        //        Console.WriteLine(group.Key);
        //        Console.WriteLine("--------------------");

        //        foreach ( Person person in group)
        //        {
        //            Console.WriteLine(person.ToString());
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadKey();
        //}
    }

    class Person
    {
        public int Age { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Job { get; set; }
        public Person(int age, string vorname, string nachname, string job)
        {
            Age = age;
            Vorname = vorname;
            Nachname = nachname;
            Job = job;
        }

        public override string ToString()
        {
            return Vorname + " " + Nachname + " (" + Age + ")" + " Job: " + Job;
        }
    }
}

