using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kap11_Linq
{
    class AnimalProgramm
    {
        //static void Main(string[] args)
        //{
        //    List<Tier> tierList = new List<Tier>();
        //    tierList.Add(new Hund(4, Geschlecht.Weiblich, "Jill"));
        //    tierList.Add(new Reh(2, Geschlecht.Männlich));
        //    tierList.Add(new Reh(5, Geschlecht.Weiblich));
        //    tierList.Add(new Hund(2, Geschlecht.Männlich, "Coco"));
        //    tierList.Add(new Hund(4, Geschlecht.Weiblich, "Idefix"));

        //    var rehe = from reh in tierList.OfType<Reh>() // OfType stammt aus System.Linq
        //                select reh;

        //    foreach (Reh reh in rehe)
        //    {
        //        Console.WriteLine(reh);
        //    }
        //}
    }
    enum Geschlecht
    {
        Weiblich,
        Männlich
    }

    abstract class Tier
    {
        public int Alter { get; set; }
        public Geschlecht Geschlecht { get; set; }
        public abstract void Essen();
        public abstract void Trinken();

    }
    class Hund : Tier
    {
        public string Name { get; set; }
        public Hund(int alter, Geschlecht geschlecht, string name)
        {
            Alter = alter;
            Geschlecht = geschlecht;
            Name = name;
        }
        public void Bellen()
        {
            Console.WriteLine(Name + " bellt!");
        }
        public override void Essen()
        {
            Console.WriteLine(Name + " frisst!");
        }
        public override void Trinken()
        {
            Console.WriteLine(Name + " trinkt!");
        }
        public override string ToString()
        {
            return "Hund" + " Name: " + Name + " Alter: " + Alter + " " + Geschlecht;
        }
    }

    class Reh : Tier
    {
        public string Name { get; set; }
        public Reh(int alter, Geschlecht geschlecht)
        {
            Alter = alter;
            Geschlecht = geschlecht;
        }
        public override void Essen()
        {
            Console.WriteLine("Das Reh frisst!");
        }
        public override void Trinken()
        {
            Console.WriteLine("Das Reh trinkt!");
        }
        public void Flucht()
        {
            Console.WriteLine("Das Reh flüchtet");
        }
        public override string ToString()
        {
            return "Reh " + Alter + " Jahres alt " + Geschlecht;
        }
    }
}
