﻿#define MYDEBUG
#define TEST
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Kap9_8
{
    public class Person
    {
        public string Name { get; set; }
        public int Nr { get; set; }
        public Person(string name, int nr)
        {
            Name = name;
            Nr = nr;
        }

        public override string ToString()
        {
            return Name.ToString() + Nr.ToString();
        }
    }

    public class Test
    {
        public Test(int a)
        {
            _t = a;
        }
        private int _t;
        public static int operator +(Test a, Test b)
        {
            return a._t + b._t;
            //return a._t - b._t;
        }

        public static int AddTwoInstances(Test a, Test b)
        {
            return a._t + b._t;
        }
    }

    public class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            //Test a = new Test(3);
            //Test b = new Test(1);

            //Console.WriteLine(a + b);
            //Console.WriteLine(Test.AddTwoInstances(a, b));
            //Dictionary<string, Person> liste2 = new Dictionary<string, Person>();
            //Person per1 = new Person("Ara", 1001);
            //Person per2 = new Person("Bill", 1002);
            //Person per3 = new Person("Cindy", 1003);
            //liste2.Add(per1.Name, per1);
            //liste2.Add(per2.Name, per2);
            //liste2.Add(per3.Name, per3);

            //foreach (KeyValuePair<string, Person> item in liste2)
            //{
            //    Console.WriteLine(item.Value.Name + item.Value.Nr);
            //}



            //Console.WriteLine("-----------------------------");

            //foreach (KeyValuePair<string, Person> item in liste2)
            //{
            //    Console.WriteLine(item.Value);
            //    //Console.WriteLine(item.Value.ToString());
            //}



            //List<Person> liste = new List<Person>();
            //liste.Add(new Person() { Name = "Ara", Nr = 1001 });
            //liste.Add(new Person() { Name = "Bill", Nr = 1002 });
            //liste.Add(new Person() { Name = "Cindy", Nr = 1003 });

            //foreach (Person per in liste)
            //{
            //    Console.WriteLine($"liste contains the person {per.Name} with the Nr. {per.Nr}");
            //}
        }

    }
}

//namespace Kap9_2
//{
    //public class Demo
    //{
    //    public Demo()
    //    {

    //    }
        
    //    public static void Add<T>(T a, T b)
    //    {
    //        Console.WriteLine("execute adding {0} and {1}", a, b);
    //        Console.WriteLine($"the typ of a is: {a.GetType()}");
    //        //int x = 5;
    //        //Type n = typeof(Int32);
    //        Console.WriteLine("the value of the a: {0}", a);
    //    }
    //}

    //public class Demo<T, K>
    //{
    //    public Demo(T t, K k)
    //    {
    //        Value = t;
    //        Feature = k;
    //    }
    //    private T Value;
    //    private K Feature;
    //    public void Add(Demo<T, K> d)
    //    {
    //        Console.WriteLine("execute adding {0} and {1}", Value, d.Value);
    //        Console.WriteLine($"the typ of K is: {Feature.GetType()}");
    //        //int x = 5;
    //        //Type n = typeof(Int32);
    //        Console.WriteLine("the value of the Feature: {0}", d.Feature);
    //    }

    //    public void Minus(Demo<T, K> d) => Console.WriteLine("execute minus {0} and {1}", Value, d.Value);
    //}

    //public class Test
    //{
    //    static void Main(string[] args)
    //    {
    //        int x = 4;
    //        int y = 5;
    //        Demo.Add(x, y);
    //        Console.WriteLine();

    //        string m = "apple";
    //        string n = "orange";
    //        Demo.Add(m, n);
    //        Console.WriteLine();

    //        Demo.Add<string>(m, n);
    //        //Demo.Add<string>(x, y);  // unexcepted types will not be accepted

            //---------------------------------
            //Demo<string, int> demo = new Demo<string, int>("test", 5);
            //Demo<string, int> demo1 = new Demo<string, int>("Test1", 5);
            //Demo<string, string> demo2 = new Demo<string, string>("test2", "Test22");
            //Demo<string, string> demo3 = new Demo<string, string>("test3", "Test33");
            //demo.Add(demo1);
//            //Console.WriteLine();
//            //demo2.Add(demo3);
//        }
//    }

//}

//namespace Kap8_2_5
//{
//    //public class Handy
//    //{
//    //    public string Name { get; set; }
//    //    public int Nr { get; set; }
//    //    public Handy(string name, int nr)
//    //    {
//    //        Name = name;
//    //        Nr = nr;
//    //    }
//    //}

    
//    //public class Person : IComparable
//    //{
//    //    public string Name { get; set; }
//    //    public string City { get; set; }

//    //    public int CompareTo(object obj)
//    //    {
//    //        if (obj == null) return 1;
//    //        Person per = obj as Person;
//    //        if (per != null)
//    //            return Name.CompareTo(per.Name);
//    //        throw new ArgumentException("Objekt ist nicht vom Typ Person");
//    //    }
//    //}
//    public class Programm
//    {
//        //static void ShowSortedList(ArrayList list)
//        //{
//        //    foreach (Person item in list)
//        //        if (item != null)
//        //        {
//        //            Console.Write($"Name: {item.Name,-12}");
//        //            Console.WriteLine($"City: {item.City}");
//        //        }
//        //}
//        //---------------------------------

//        public class Seasons : IEnumerable
//        {
//            string[] seasons = new string[] { "spring", "summer", "autum", "winter" };

//            public IEnumerator GetEnumerator()
//            {
//                yield return seasons[0];
//                yield return seasons[1];
//                yield return seasons[2];
//                yield return seasons[3];
//            }

//            //public IEnumerator GetEnumerator()
//            //{
//            //    for(int i = 0; i < seasons.Length; i++)
//            //    {
//            //        Console.WriteLine("in class Seasons: ");
//            //        yield return seasons[i];
//            //    }
//            //}
//        }
//        static void Main(string[] args)
//        {
//            Seasons s = new Seasons();
//            foreach(string item in s)
//            {
//                Console.WriteLine("in Main: ");
//                Console.WriteLine(item + "\n");
//            }


//            //----------------------------------------------
//            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//            //Queue myQueue = new Queue();
//            //foreach(int x in arr)
//            //{
//            //    myQueue.Enqueue(x);
//            //}

//            //Console.WriteLine("the members of the Queue: ");
//            ////myQueue.Clear();
//            ////int c = myQueue.Count;
//            ////Console.WriteLine("\n" + c);
//            //while (myQueue.Count != 0)
//            //{
//            //    Console.Write("{0,-2}", myQueue.Dequeue());
//            //}
//            //int c = myQueue.Count;
//            //Console.WriteLine("\n" + c);

//            //--------------------------------------------------
//            //foreach (int a in arr)
//            //{
//            //    Console.Write(a + " ");
//            //}

//            //Stack myStack = new Stack(9);
//            //Console.WriteLine("\n\npush elements into myStack");
//            //foreach (int a in arr)
//            //{
//            //    myStack.Push(a);
//            //    Console.WriteLine("push element {0} in myStack.", a);
//            //}

//            ////myStack.Pop();
//            ////myStack.Pop();
//            ////int x = myStack.Count;
//            ////Console.WriteLine(x);


//            //Console.WriteLine("\n\npop all elements from myStack:");


//            //while (myStack.Count != 0)
//            //{
//            //    Console.WriteLine("element {0} is poped from myStack.", myStack.Pop());
//            //}




//            ////Hashtable hash = new Hashtable();
//            ////hash.Add("Alex", 1001);
//            ////hash.Add("Bill", 1002);
//            //hash.Add("Cindi", 1003);
//            //hash.Add("Dora", 1004);

//            //foreach(string item in hash.Keys)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //Console.WriteLine();
//            //foreach(int item in hash.Values)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //Console.WriteLine();
//            //foreach(DictionaryEntry item in hash)
//            //{
//            //    Console.WriteLine("Name: {0,-8}HandyNr.: {1}", item.Key, item.Value);
//            //}

//            //Console.WriteLine("input a probe/test key: ");
//            //string t = Console.ReadLine();

//            ////bool b = hash.Contains(t) ? true : false;

//            ////Console.Write{the }
//            //string s = (hash.Contains(t) ? "hash contains the key {0}" : "hash doesn't contain the key {0}");
//            //Console.WriteLine(s, t);

//            //Console.WriteLine("input a Handynr.: ");
//            //int h = Convert.ToInt32(Console.ReadLine());

//            //string s2 = (hash.ContainsValue(h) ? "hash contains the value {0}" : "hash doesn't contain the value {0}");
//            //Console.WriteLine(s2, h);


//            //---------------------------------------------------------------------------------------

//            //ArrayList person = new ArrayList();
//            //person.Add(new Person() { Name = "Lily", City = "Xingyang"});
//            //person.Add(new Person() { Name = "Peiren", City = "Qingyang" });
//            //person.Add(new Person() { Name = "Lily2", City = "Xingyang2" });
//            //person.Add(new Person() { Name = "Someone", City = "Somewhere" });

//            //Console.WriteLine("list before Sort: ");
//            //ShowSortedList(person);

//            //Console.WriteLine("\nlist after Sort: ");
//            //person.Sort();
//            //ShowSortedList(person);

//            //Person[] replace = new Person[4];
//            //person.CopyTo(replace);

//            //Console.WriteLine("\nnew list:");
//            //foreach (Person item in replace)
//            //{
//            //    Console.WriteLine("Name: {0,-12}City: {1}", item.Name, item.City);
//            //}

//            //Console.WriteLine("\ntry Adapter");
//            //ArrayList liste = ArrayList.Adapter(replace);
//            //liste.Sort();
//            //liste.Reverse();
//            //ShowSortedList(liste);

//            //Console.WriteLine("\noriginal Array after Adapter-action");
//            //foreach (Person item in replace)
//            //{
//            //    Console.WriteLine("Name: {0,-12}City: {1}", item.Name, item.City);
//            //}


//            //ArrayList a = new ArrayList();
//            //a.Add("ab");
//            //a.Add("bc");

//            //string[] x = { "cd", "de", "ef", "fg", "gh"};
//            //a.AddRange(x);
//            //a.Remove(a[2]);
//            //a.RemoveAt(3);

//            //a.Sort();
//            //string[] b = new string[a.Count+2];
//            //a.CopyTo(b, 2);

//            //int Count = 0;

//            //foreach(string item in b)
//            //{
//            //    Console.WriteLine(item);
//            //    ++Count;
//            //}

//            //Console.WriteLine(Count);

//            //------------------------------------------------------------------------

//            //ArrayList a = new ArrayList();
//            ////int index1 = a.Add(3);
//            ////int index2 = a.Add(5);
//            //a.Add(3);
//            //a.Add(5);

//            //int[] x = { 2, 4, 6, 8, 10 };
//            //a.AddRange(x);
//            //a.Remove(a[1]);

//            //a.Sort();
//            //int[] b = new int[a.Count + 2];
//            //a.CopyTo(b, 2);

//            //foreach (int item in b)
//            //{
//            //    Console.WriteLine(item.ToString());
//            //}


//        }
//    }
//}

//namespace Kap7_3
//{
//    class Program2
//    {
//        static void Main(string[] args)
//        {
//            int x = 10;
//            int y = 23;
//            int z = x + y;
//            //DebugTestProc();
//            //Console.Write(z);
//            Console.WriteLine(4.CompareTo(7));
//        }
//        static void DebugTestProc()
//        {
//            Console.WriteLine("In DebugTestProc");
//        }
//    }
//}

//namespace Kap7_1
//{

//    public class Anwendung
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Anwendung obj = new Anwendung();
//                obj.Test();
//            }
//            catch (TooLongException e)
//            {
//                Console.WriteLine(e.Message);
//#if(MYDEBUG)
//                Console.WriteLine("hint: max 2 significants");
//#endif
//            }
//            catch (TooBigException e) when (e.HResult == 25)
//            {
//                Console.WriteLine(e.Message);
//                Console.WriteLine("hint: max permitted interger: 20");
//            }
//            catch (TooSmallException e) when (e.Result == 5)  // there existing HResult available, in fact no need to creat a Result 
//            {
//#if (MYDEBUG)
//                Console.WriteLine(e.Message);
//#elif(TEST)
//                Console.WriteLine("hint: min permitted integer: 10");
//#endif
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//                Console.WriteLine("unknown Exception");
//            }

//        }
//        public void Test()
//        {
//            Console.WriteLine("input something: ");
//            var a = Console.ReadLine();
//            Debug.WriteLine("Ausgabe 1");
//            Debug.Indent();
//            Debug.WriteLineIf(a == "25", "Ausgabe 2");

//            if (a.Length > 2)
//            {
//               throw new TooLongException();
//            }
//            else
//            {
//                Console.WriteLine("great, the lenght is {0}!", a.Length);
//                int x = Convert.ToInt32(a);
                
//                Debug.Assert(x >= 0, "value ist negativ");

//                if (x > 10 && x < 20)
//                {
//                    Console.WriteLine("great, x is bigger than 10 and smaller than 20!");
//                }
//                else if (x <= 10)
//                {
//                    TooSmallException ts = new TooSmallException();
//                    ts.Result = x;
//                    throw ts;
//                }
//                else
//                {
//                    TooBigException tb = new TooBigException();
//                    tb.HResult = x;
//                    throw tb;
//                }
//            }
//        }
//    }

//    public class TooLongException : Exception
//    {
//        public TooLongException() : base("the lengh of the input should not be bigger than 2.")
//        {
//        }
//    }

//    public class TooBigException : Exception
//    {
//        public TooBigException() : base("the converted number is too big")
//        {
//        }
//    }

//    public class TooSmallException : Exception
//    {
//        public TooSmallException() : base("the converted number is too small")
//        {
//        }
//        public int Result { get; set; }  // there existing HResult available, in fact no need to creat a Result 
//    }
//}


    //class Programm2
    //{


    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            StreamReader stream = new StreamReader(@"C:\Text5.txt");
    //            Console.WriteLine(stream.ReadToEnd());
    //            stream.Close();
    //            Console.ReadLine();
    //        }
    //        catch (ArgumentException e)
    //        {
    //            Console.WriteLine("test if runned into catch");
    //            Console.WriteLine(e.Message);
    //        }
    //        catch (FileNotFoundException e)
    //        {
    //            Console.WriteLine("test if runned into catch");
    //            Console.WriteLine(e.Message);
    //            Console.WriteLine(e.Source);
    //            Console.WriteLine(e.StackTrace);
    //            // return; // finally block will be executed anyway
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("test if runned into catch");
    //            Console.WriteLine(e.Message);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("just to test finally");
    //        }
    //    }
//}


//namespace Kap_6
//{
//    public enum Op
//    {
//        add = 1,
//        sub,
//        mul,
//        div
//    }

//    public class Test
//    {

//        public static int Operator(int a, int b, int x)
//        {
//            //Console.WriteLine("input the first value: ");
//            //int a = Convert.ToInt32(Console.ReadLine());
//            //Console.WriteLine("input the second value: ");
//            //int b = Convert.ToInt32(Console.ReadLine());

//            switch ((Op)x)
//            {
//                case Op.add:
//                    Console.WriteLine("the numbers will be added, result is: {0}", a + b);
//                    return a + b;

//                case Op.sub:
//                    Console.WriteLine("the numbers will be subtracted, result is: {0}", a - b);
//                    return a - b;

//                case Op.mul:
//                    Console.WriteLine("the numbers will be multiplied, result is: {0}", a * b);
//                    return a * b;

//                case Op.div:
//                    Console.WriteLine("the numbers will be divided, result is: {0}", a / b);
//                    return (int)(a / b);

//                default:
//                    Console.WriteLine("Default case.");
//                    return -1;
//            }
//        }

//        static void Main(string[] args)
//        {
//            int x = 3;
//            int y = 5;

//            Console.WriteLine("input a integer: 1 → +, 2 → -, 3 → *, 4 → /");
//            int m = Convert.ToInt32(Console.ReadLine());
//            Test.Operator(x, y, m);
//        }

//        static void VoidFunc()
//        {
//            return;
//        }
//    }
//}

//namespace Lambda
//{
//    public delegate double CalculateHandler(double x, double y);
//    public class Test
//    {
//        public static double Jisuan(double a, double b)
//        {
//            return a + b;
//        }

//        static void Main(string[] args)
//        {
//            CalculateHandler calculate;
//            int a = 4;
//            int b = 5;

//            calculate = delegate(double a, double b)
//            {
//                return b + a;
//            };

//            double result = calculate(a, b);  // Variante 1: anomy methode
//            Console.WriteLine(result);

//            calculate = Jisuan; // Variante 3: normal methode(Jisuan) → Zuweisung 
//            double result2 = calculate(a, b);
//            Console.WriteLine(result2);

//            calculate = (double a, double b) => { return a + b; }; // Variante 2.1: Lambda Ausdrücke
//            result = calculate(a, b);
//            Console.WriteLine(result);

//            calculate = (a, b) => (a + b); // Variante 2.2: Lambda Ausdrücke → kürzeste Fassung
//            result = calculate(a, b);
//            Console.WriteLine(result);
//        }
//    }
//}

//namespace EreignisHandler
//{
//    public delegate void InvalidMeasureEventHandler(Object sender, InvalidMeasureEventArgs e);

//    public class InvalidMeasureEventArgs : EventArgs
//    {
//        private int _InvalidMeasure;
//        public int InvalidMeasure
//        {
//            get { return _InvalidMeasure; }
//        }
//        public InvalidMeasureEventArgs(int invalidMeasure)
//        {
//            _InvalidMeasure = invalidMeasure;
//        }
//    }

//    public class Circle
//    {
//        public event InvalidMeasureEventHandler Loesung;

//        private int _Radius;
//        public virtual int Radius
//        {
//            get { return _Radius; }
//            set
//            {
//                if (value >= 0)
//                    _Radius = value;
//                else
//                    Loesung?.Invoke(this, new InvalidMeasureEventArgs(value));
//                    //Loesung.Invoke(this, new InvalidMeasureEventArgs(value));
//            }
//        }

//        public static void LoesungMethod(object sender, InvalidMeasureEventArgs e)
//        {
//            Console.Write($"Ein Radius von {e.InvalidMeasure} ist nicht zulässig.");
//            Console.Write("Neueingabe: ");
//            Circle circle = sender as Circle;
//            if (circle != null)
//                circle.Radius = Convert.ToInt32(Console.ReadLine());
//        }
//    }

//    public class Test2
//    {
//        static void Main(string[] args)
//        {
//            Circle r = new Circle();
//            r.Loesung += Circle.LoesungMethod;
//            //r.Loesung += new InvalidMeasureEventHandler(LoesungMethod);
//            r.Radius = -4;
//        }
//    }





//}

//namespace Ereignis
//{
//    public delegate void Test(int x);

//    public class TestNumber
//    {
//        public int Wert(int a)
//        {
//            if (a < 10)
//            {
//                Loesung1?.Invoke(a);
//            }
//            //{
//            //    if (Loesung1 != null)
//            //    {
//            //        Loesung1(a);
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("React1 is not aboniert");
//            //    }
//            //}
//            else if (a > 20)
//            {
//                Loesung2(a);
//            }
//            else
//            {
//                Console.WriteLine("good job!");
//            }

//            return a;
//        }
//        public event Test Loesung1;
//        public event Test Loesung2;
//    }
//    public class Programm
//    {

//        static void Main(string[] args)
//        {

//            Console.WriteLine("input a number between 10 to 20: ");
//            int b = Convert.ToInt32(Console.ReadLine());

//            TestNumber p = new TestNumber();
//            p.Loesung1 += React1;
//            //p.Loesung1 += P_Loesung1;
//            //p.Loesung2 += React2; → äquivalent wie folgendes
//            p.Loesung2 += new Test(React2);
//            //p.Loesung2 += P_Loesung2;

//            p.Wert(b);

//        }

//        //private static void P_Loesung2(int x)
//        //{
//        //    throw new NotImplementedException();
//        //}

//        //private static void P_Loesung1(int x)
//        //{
//        //    throw new NotImplementedException();
//        //}

//        public static void React1(int x)
//        {

//            Console.WriteLine("{0} is too small, a number between 10-20 is expected", x);
//        }

//        public static void React2(int x)
//        {

//            Console.WriteLine("{0} is too big, a number between 10-20 is expected", x);
//        }
//    }

//}

//namespace Kap5_1_Beispiel1
//{
//    public delegate double CalculateHandler(double value1, double value2);

//    class Programm
//    {
//        static void Main(string[] args)
//        {
//            CalculateHandler calculate; // instanzierung of the delegate

//            do
//            {
//                Console.Clear();
//                Console.WriteLine("first Operator: ");
//                double input1 = Convert.ToDouble(Console.ReadLine());
//                Console.WriteLine("second Operator: ");
//                double input2 = Convert.ToDouble(Console.ReadLine());

//                Console.WriteLine("Addition(A) or Subtract(S)");
//                string wahl = Console.ReadLine().ToUpper();

//                if (wahl == "A")
//                {
//                    calculate = new CalculateHandler(Mathematics.Add);
//                    // -------------
//                }
//                else if (wahl == "S")
//                {
//                    calculate = new CalculateHandler(Mathematics.Subtract);
//                    // -------------
//                }
//                else
//                {
//                    Console.WriteLine("Ungültige Eingabe");
//                    Console.ReadLine();
//                    return;
//                }

//                double result = calculate(input1, input2); 
//                // aufruf Add or Subtract über Delegate
//                Console.WriteLine("------------------------------------");
//                Console.WriteLine($"Ergebnis = {result}\n\n");
//                Console.WriteLine("zum Beenden F12 drücken");
//            }
//            while (Console.ReadKey(true).Key != ConsoleKey.F12);
//        }
//    }

//    class Mathematics
//    {
//        public static double Add(double x, double y)
//        {
//            return x + y;
//        }
//        public static double Subtract(double x, double y)
//        {
//            return x - y;
//        }
//    }
//}

//namespace Kap5_1_Cainiao
//{
//    delegate int NumberChanger(int n);

//    class TestDelegate
//    {
//        static int num = 10;
//        public static int AddNum(int p)
//        {
//            num += p;
//            return num;
//        }
//        public static int MultNum(int q)
//        {
//            num *= q;
//            return num;
//        }
//        public static int getNum()
//        {
//            return num;
//        }

//        static void Main(string[] args)
//        {
//            NumberChanger nc1 = new NumberChanger(AddNum);
//            NumberChanger nc2 = new NumberChanger(MultNum);

//            nc1(25);
//            Console.WriteLine("Value of Num: {0}", getNum());
//            nc2(5);
//            Console.WriteLine("Value of Nume: {0}", getNum());
//            Console.ReadKey();

//            NumberChanger nc;
//            nc = nc1;
//            nc += nc2;

//            nc(5);
//            Console.WriteLine("Value of Num: {0}", getNum());
//            Console.ReadKey();
//        }
//    }

//}

//namespace Aufwecken
//{
//    public delegate void Aufwecken();

//    public class Hotel
//    {
//        private int roomnr;
//        private int wakeupTime;
//        private Aufwecken service;

//        public Hotel(int x, int y, Aufwecken z)
//        {
//            roomnr = x;
//            wakeupTime = y;
//            service = z;
//        }

//        public void duty(int x)
//        {
//            Console.WriteLine("current time is: {0}", x);
//            if (wakeupTime == x)
//            {
//                service();
//            }
//        }
//    }

//    public class Test
//    {
//        public static void DoAufwecken()
//        {
//            Console.WriteLine("wake up the guest by calling");
//        }

//        static void Main(string[] args)
//        {
//            Hotel nc = new Hotel(01, 13, DoAufwecken);
//            int globalTime = 0;
//            while (globalTime < 25)
//            {
//                nc.duty(globalTime);
//                ++globalTime;
//            }
//        }
//    }
//}



//namespace Kap5_1_Beispiel1
//{
//    public delegate double CalculateHandler(double value1, double value2);

//    class Programm
//    {

//        public static double Add(double x, double y)
//        {
//            return x + y;
//        }
//        public static double Subtract(double x, double y)
//        {
//            return x - y;
//        }
//        public static double Mult(double x, double y)
//        {
//            return x * y;
//        }

//        static void Main(string[] args)
//        {
//            CalculateHandler calculate;

//            do
//            {
//                Console.Clear();
//                Console.Write("Geben Sie den ersten Operanden ein: ");
//                double input1 = Convert.ToDouble(Console.ReadLine());
//                Console.Write("Geben Sie den zweiten Operanden ein: ");
//                double input2 = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Operation: Addition - (A) oder Subtraktion - (S)? oder Multi (M) ");
//                string wahl = Console.ReadLine().ToUpper();

//                if (wahl == "A")
//                {
//                    calculate = new CalculateHandler(Add);
//                }
//                else if (wahl == "S")
//                {
//                    calculate = new CalculateHandler(Subtract);
//                }
//                else if (wahl == "M")
//                {
//                    calculate = new CalculateHandler(Mult);
//                }
//                else
//                {
//                    Console.Write("Ungültige Eingabe");
//                    Console.ReadLine();
//                    return;
//                }

//                double result = calculate(input1, input2);

//                Console.WriteLine("----------------------------------");
//                Console.WriteLine($"Ergebnis = {result}\n\n");
//                Console.WriteLine("Zum Beenden F12 drücken.");
//            }
//            while (Console.ReadKey(true).Key != ConsoleKey.F12);
//        }
//    }
//}

//namespace Kap5_1_SimpleDelegate
//{
//    public delegate double CalculateHandler(double value1, double value2);

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Variable vom Typ des Delegaten
//            CalculateHandler calculate;

//            do
//            {
//                // Eingabe der Operation
//                Console.Clear();
//                Console.Write("Geben Sie den ersten Operanden ein: ");
//                double input1 = Convert.ToDouble(Console.ReadLine());
//                Console.Write("Geben Sie den zweiten Operanden ein: ");
//                double input2 = Convert.ToDouble(Console.ReadLine());

//                // Wahl der Operation
//                Console.Write("Operation: Addition - (A) oder Subtraktion - (S)? ");
//                string wahl = Console.ReadLine().ToUpper();

//                // In Abhängigkeit von der Wahl des Anwenders wird die Variable 'calculate'
//                // mit einem Zeiger auf die auszuführende Methode initialisiert
//                if (wahl == "A")
//                    calculate = new CalculateHandler(Mathematics.Add);
//                else if (wahl == "S")
//                    calculate = new CalculateHandler(Mathematics.Subtract);
//                else
//                {
//                    Console.Write("Ungültige Eingabe");
//                    Console.ReadLine();
//                    return;
//                }

//                // Aufruf der Operation 'Add' oder 'Subtract' über den Delegaten
//                double result = calculate(input1, input2);
//                Console.WriteLine("----------------------------------");
//                Console.WriteLine($"Ergebnis = {result}\n\n");
//                Console.WriteLine("Zum Beenden F12 drücken.");

//            } while (Console.ReadKey(true).Key != ConsoleKey.F12);
//        }
//    }

//    class Mathematics
//    {
//        public static double Add(double x, double y)
//        {
//            return x + y;
//        }
//        public static double Subtract(double x, double y)
//        {
//            return x - y;
//        }
//    }

//}

