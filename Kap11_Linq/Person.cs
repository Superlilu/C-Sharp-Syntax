using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace Kap11_Linq
//{
//    class Programm
//    {
//        static void Main(string[] args)
//        {
//            List<Person> personList = new List<Person>();
//            personList.Add(new Person(20, "Benjamin", "Kohl"));
//            personList.Add(new Person(19, "Benjamin", "Blume"));
//            personList.Add(new Person(22, "Alina", "Müller"));
//            personList.Add(new Person(43, "Daniela", "Kohl"));
//            personList.Add(new Person(27, "Carlos", "Sanchez"));

//            //var personQuery = from person in personList
//            //                  orderby person.Vorname descending, person.Nachname ascending
//            //                  select person;

//            //var personQuery = personList.OrderBy(person => person.Vorname).ThenBy(person => person.Nachname).ToList();
//            var personQuery = personList.OrderByDescending(person => person.Vorname).ThenBy(person => person.Nachname).ToList();

//            foreach (Person person in personQuery)
//            {
//                Console.WriteLine(person.ToString());
//            }
//            Console.ReadKey();
//        }
//    }

//    class Person
//    {
//        public int Age { get; set; }
//        public string Vorname { get; set; }
//        public string Nachname { get; set; }
//        public Person(int age, string vorname, string nachname)
//        {
//            Age = age;
//            Vorname = vorname;
//            Nachname = nachname;
//        }

//        public override string ToString()
//        {
//            return Vorname + " " + Nachname + " (" + Age + ")";
//        }
//    }
//}
