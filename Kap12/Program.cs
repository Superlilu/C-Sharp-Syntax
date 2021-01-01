using System;
using System.IO;
using System.Xml.Serialization;

namespace Kap12
{
    //public class ReadTest
    //{
    //    string Path1 { get; set; }
    //    public ReadTest()
    //    {
    //        Path1 = @"D:\C-Sharp-Syntax\Kap12\testText.txt";
    //    }
    //    public void ReadMethode()
    //    {
    //        try
    //        {
    //            using (StreamReader sr1 = new StreamReader(Path1))
    //            {
    //                string read;
    //                while ((read = sr1.ReadLine()) != null)  // no better choice
    //                {
    //                    Console.WriteLine(read);
    //                }

    //                /* worse alternativ for:  while ((read = sr1.ReadLine()) != null) 
                    
    //                string line2 = sr2.ReadLine();
    //                while (line2 != null)
    //                {
    //                    Console.WriteLine(line2);
    //                    line2 = sr2.ReadLine();
    //                }
    //                */
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //        Console.ReadKey();
    //    }
    //}

    [XmlRoot("PersonenListe")]
    public class Personenliste
    {
        [XmlElement("Listenbezeichner")]
        public string Listenname;
        [XmlArray("PersonenArray")]
        [XmlArrayItem("PersonObjekt")]
        public Person[] Personen;

        public Personenliste() { }
        public Personenliste(string name)
        {
            this.Listenname = name;
        }
    }
    public class Person
    {
        [XmlElement("Name")]
        public string Zuname;
        [XmlElement("Wohnort")]
        public string Ort;
        [XmlElement("Alter")]
        public int Lebensalter;
        [XmlAttribute("PersID", DataType = "string")]
        public string ID;

        public Person() { }
        public Person(string zuname, string ort, int alter, string id)
        {
            this.Zuname = zuname;
            this.Ort = ort;
            this.Lebensalter = alter;
            this.ID = id;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Personenliste catalog = new Personenliste("Teilnehmerliste");
            //catalog.Listenname = "Teilnehmerliste";
            Person[] persons = new Person[2];
            persons[0] = new Person("Peter", "Berlin", 45, "117");
            persons[1] = new Person();
            persons[1].Zuname = "Franz-Josef";
            persons[1].Ort = "Aschaffenburg";
            catalog.Personen = persons;
            // seralisieren---------------------------------------------------
            XmlSerializer serializer = new XmlSerializer(typeof(Personenliste));
            FileStream fs = new FileStream("Personenliste.xml", FileMode.Create);
            serializer.Serialize(fs, catalog);
            fs.Close();
            //catalog = null;
            // deserialisieren-------------------------------------------------
            Personenliste catalog2;
            XmlSerializer serializer2 = new XmlSerializer(typeof(Personenliste));
            FileStream fs2 = new FileStream("Personenliste.xml", FileMode.Open);
            catalog2 = (Personenliste)serializer2.Deserialize(fs2);
            serializer2.Serialize(Console.Out, catalog2);

            //string line = "";
            //using (StreamReader sr = new StreamReader("Personenliste.xml"))
            //{
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            //Console.ReadLine();

            //if (catalog2 == catalog)
            //{
            //    Console.WriteLine("they are the same obj");
            //}

            //-------------------------------

            //ReadTest rt = new ReadTest();
            //rt.ReadMethode();

            //--------------------------------------------

            //string[] names = new string[] { "Zara Ali", "Nuha Ali" };
            //using (StreamWriter sw = new StreamWriter("names.txt"))
            //{
            //    foreach (string s in names)
            //    {
            //        sw.WriteLine(s);

            //    }
            //}
            //string line = "";
            //using (StreamReader sr = new StreamReader("names.txt"))
            //{
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            //--------------------------------------------------------------

            //string[] robot = new string[] { "KR30", "iiwa", "LBR Med", "Quantec", "iisy" };
            //using (StreamWriter sw1 = new StreamWriter("robottyp.txt"))
            //{
            //    foreach (string rb in robot)
            //    {
            //        sw1.WriteLine(rb);
            //    }
            //}

            //string line2 = "";
            //using (StreamReader sr2 = new StreamReader("robottyp.txt"))
            //{
            //    while ((line2 = sr2.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line2);
            //    }
            //}

            //--------------------------------------------------------------

            //DirectoryInfo mydir = new DirectoryInfo(@"D:\LiLu2020\Heirat");
            //FileInfo[] f = mydir.GetFiles();
            //foreach (FileInfo file in f)
            //{
            //    Console.WriteLine("File Name: {0} Size: {1} Attribute: {2}", file.Name, file.Length, file.FullName);
            //}
            //DirectoryInfo x = mydir.CreateSubdirectory("Test");

            //FileInfo myfile = new FileInfo(@"robottyp");
            ////Console.WriteLine("Attribute: {0}", myfile.Directory);

            ////-------------------------------------------
            //var att = myfile.Attributes & FileAttributes.Hidden;  // att == "Hidden"
            //Console.WriteLine("att is: {0}", att); 

            //Console.ReadKey();
        }
    }
}
