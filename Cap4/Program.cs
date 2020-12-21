using System;
using System.Collections;

namespace Kap4_8
{
    //public interface ICompare
    //{
    //    int Compare(object x, object y);
    //}

    public class GeometricObjectCompare : IComparer
    {
        public int Compare(object? x, object? y)
        {
            GeometricObject geo1 = x as GeometricObject;
            GeometricObject geo2 = y as GeometricObject;
            if (geo1 != null && geo2 != null)
                return Bigger(geo1, geo2);
            else
                throw new InvalidCastException();
        }

        public static int Bigger(GeometricObject x, GeometricObject y)
        {
            if (x.GetValue() > y.GetValue()) 
                return 1;
            else if (x.GetValue() < y.GetValue())
                return -1;
            else 
                return 0;
        }
    }


    public interface IDraw
    {
        int Param { get; set; }
        int IDraw(int x);
    }

    public class GeometricObject
    {
        public GeometricObject(string name)
        {
            this.name = name;
        }

        protected string name;
        public void Start()
        {
            Console.WriteLine(name);
        }
        public virtual int GetValue()
        {
            return name.Length;
        }
    }

    public class Circle : GeometricObject, IDraw
    {
        public Circle(string name) : base(name)
        {

        }
        public int Param { get; set; }

        public int IDraw(int x)
        {
            int Wert = x * 2;
            return Wert ;
        }

        public override int GetValue()
        {
            return name.Length;
        }

    }

    public class Rectangle : GeometricObject, IDraw
    {
        public Rectangle(string name): base(name)
        {
        }
        public int Param { get; set; }

        public int IDraw(int x)
        {
            int Wert = x * x;
            return Wert;
        }

        public override int GetValue()
        {
            return name.Length;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            GeometricObject[] arr = new GeometricObject[3];
            arr[0] = new GeometricObject("hallo");
            arr[1] = new Circle("hh");
            arr[2] = new Rectangle("ffff");

            foreach (GeometricObject geo in arr)
                geo.Start();

            Console.WriteLine("------------------------------");

            //GeometricObjectCompare a = new GeometricObjectCompare();
            //Array.Sort(arr, a);

            Array.Sort(arr, new GeometricObjectCompare());

            foreach (GeometricObject geo in arr)
                geo.Start();
        }
    }
    
}

//namespace Cap4
//{



//    public interface ICompare
//    {
//        int Compare();
//    }

//    public interface IDraw
//    {
//        /// <summary>
//        /// Test property for ***; Graf() method for the funtion of ***.
//        /// </summary>
//        string Test { get; set; }
//        void Graf();
//        void NewGraf();
//    }

//    public interface ICopy
//    {
//        void Graf();
//    }

//    public class GeometricObject
//    {
//        public GeometricObject()
//        {

//        }

//        public virtual void Start()
//        {
//            Console.WriteLine("it's a GeometricObject");
//        }
//    }

//    public class Circle : GeometricObject
//    {

//        public Circle()
//        {

//        }

//        public override void Start()
//        {
//            Console.WriteLine("it's a Circle");
//        }

//        public int Radius { get; set; }

//        public virtual void Eigenschaft1(int c)
//        {
//            Radius = c;
//        }

//    }

//    public class GraficCircle : Circle, IDraw, ICopy
//    {
//        public string Test { get; set; }
//        public GraficCircle()
//        {

//        }

//        public override void Eigenschaft1(int c)
//        {
//            base.Eigenschaft1(c);
//            double Area1 = Math.Pow(c, 2) * Math.PI;
//            Console.WriteLine("the Area of the Circle is: {0}", Area1);
//        }

//        public void Graf()
//        {
//            Console.WriteLine("draw the grafic in the instance of circle");
//        }

//        public void NewGraf()
//        {
//            throw new NotImplementedException();  // automatic implemention by klicking "implemente interface"
//        }

//        void ICopy.Graf()
//        {
//            Console.WriteLine("copy the circle");
//        }

//        //public void NewGraf()
//        //{
//        //    Console.WriteLine("test of NewGraf");
//        //}
//    }

//    public class Rectangle : GeometricObject
//    {
//        public Rectangle()
//        {

//        }

//        public override void Start()
//        {
//            Console.WriteLine("it's a Rectangle");
//        }

//        public int Length { get; set; }
//        public int Width { get; set; }

//        public virtual void Eigenschaft2(int x, int y)
//        {
//            Length = x;
//            Width = y;
//        }

//    }

//    public class GraficRectangle : Rectangle, IDraw
//    {
//        public string Test { get; set; }
//        public GraficRectangle()
//        {

//        }

//        public int Area2 { get; set; }
//        public override void Eigenschaft2(int x, int y)
//        {
//            base.Eigenschaft2(x, y);
//            Area2 = x * y;
//            Console.WriteLine("the Area of the Rectangle is: {0}", Area2);
//        }


//        public void Graf()
//        {
//            Console.WriteLine("draw the grafic in instanz of rectangle");
//        }

//        public void NewGraf()
//        {
//            Console.WriteLine("test of NewGraf");
//        }

//        public class UnknownGrafic : IDraw
//        {
//            public UnknownGrafic()
//            {

//            }
//            public string Test { get; set; }

//            public void Graf()
//            {
//                Console.WriteLine("test IDraw arr");
//            }

//            public void NewGraf()
//            {
//                Console.WriteLine("test IDraw arr again");
//            }
//        }
//    }

//    public class UnknownGrafic2 : IDraw
//    {
//        public string Test { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public void Graf()
//        {
//            throw new NotImplementedException();
//        }

//        public void NewGraf()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class Test
//    {
//        static void Main(string[] args)
//        {
//            GraficCircle c1 = new GraficCircle();
//            IDraw draw = c1;
//            draw.Graf();
//            ICopy copy = c1;
//            copy.Graf();
//            Console.WriteLine();

//            IDraw[] arr = new IDraw[5];
//            arr[0] = new GraficCircle();
//            arr[1] = new GraficRectangle();
//            arr[2] = new GraficCircle();
//            arr[3] = new GraficRectangle.UnknownGrafic();
//            arr[4] = new GraficRectangle.UnknownGrafic();
//            //arr[4] = new UnknownGrafic2();
//            foreach (IDraw i in arr)
//            {
//                i.Graf();
//            }
//            Console.WriteLine();

            
//            GraficRectangle r = new GraficRectangle();
//            r.Eigenschaft2(3, 5);
//            r.Graf();
//            r.NewGraf();

//            Console.WriteLine("\n");

//            GraficCircle c = new GraficCircle();
//            c.Eigenschaft1(10);
//            c.Graf();
//            c.NewGraf();

//            Console.WriteLine(typeof(string).Assembly.ImageRuntimeVersion);



//        }
//    }


//    //namespace Kap4_4
//    //{
//    //    public abstract class A
//    //    {
//    //        public abstract void Start();

//    //    }

//    //    //public sealed class B : A   //class sealed: class can not be inherated
//    //    public class B : A
//    //    {
//    //        //public sealed override void Start()  // methode sealed: method can not be overrided
//    //        public override void Start()
//    //        {
//    //            Console.WriteLine("start B");
//    //        }
//    //    }

//    //    public class C : B 
//    //    {
//    //        public override void Start()
//    //        {
//    //            Console.WriteLine("start C");
//    //        }
//    //    }


//    //    public class Test
//    //    {
//    //        static void Main(string[] args)
//    //        {
//    //            A ab = new B();
//    //            ab.Start();
//    //            B bc = new C();
//    //            bc.Start();

//    //            //Int32 a;
//    //            //a.ToString();
//    //        }
//    //    }


//    //}


//    //namespace Jicheng
//    //{

//    //    public abstract class Auto
//    //    {
//    //        public Auto(string x)
//    //        {
//    //            Farbe = x;
//    //        }

//    //        protected string Farbe;
//    //        public abstract void Drive(string x);
//    //        public virtual void Break()
//    //        {
//    //            Console.WriteLine("Auto is breaked");
//    //        }

//    //        public void Accelerate()
//    //        {
//    //            Console.WriteLine("Auto Accelerate");
//    //        }
//    //    }

//    //    public class PKW : Auto
//    //    {
//    //        public PKW(string y) : base(y)
//    //        {

//    //        }

//    //        public override void Drive(string x)
//    //        {
//    //            Console.WriteLine("typ of drive:{0}, color is: {1}", x, base.Farbe);
//    //        }

//    //        public override void Break()
//    //        {
//    //            Console.WriteLine("PKW is breaked again");
//    //        }

//    //        public new void Accelerate()
//    //        {
//    //            Console.WriteLine("New Auto Accelarate");
//    //        }
//    //    }
//    //    public class LKW : Auto
//    //    {
//    //        public LKW() : base("")
//    //        { }
//    //        public override void Drive(string n)
//    //        {
//    //        }

//    //    }


//    //    class Program
//    //    {
//    //        public static void TestTyp(Auto x)
//    //        {
//    //            if (x is Auto)
//    //            {
//    //                Console.WriteLine($"{x} is Auto Typ");
//    //            }
//    //            if (x is PKW)
//    //            {
//    //                Console.WriteLine($"{x} is PKW Typ");
//    //            }
//    //        }
//    //        static void Main(string[] args)
//    //        {
//    //            PKW r = new PKW("red");  // by the Polymophism (virtual) the obj typ coresponds the newed typ (here PKW)
//    //            r.Drive("automatic");
//    //            r.Break();

//    //            Auto a = r;  // a is actually a PKW typ, so a.Break() will call the class PKW → Polymophism (Break method is marked as virtual)
//    //            a.Break();

//    //            r.Accelerate();
//    //            a.Accelerate(); // a corresponds here the base

//    //            LKW k = new LKW();

//    //            TestTyp(k);
//    //            TestTyp(a);
//    //            TestTyp(r);

//    //            PKW p;
//    //            p = a as PKW;
//    //            //p = (PKW)a;


//    //        }
//    //    }
//    //}


//    //namespace Kap4
//    //{

//    //    public class Circle
//    //    {
//    //        public Circle(int x)
//    //        {
//    //            _Radius = x;
//    //        }

//    //        protected int _Radius;
//    //        public int Radius
//    //        {
//    //            get { return _Radius; }
//    //            set { _Radius = value; }
//    //        }

//    //        public void Draw()
//    //        {
//    //            Console.WriteLine("Circle draw.");
//    //        }

//    //    }

//    //    public class NewCircle : Circle
//    //    {
//    //        public NewCircle(int y) : base(y)
//    //        {

//    //        }

//    //        public new void Draw()
//    //        {
//    //            base.Draw();
//    //            Console.WriteLine("overwrite for newCircle");
//    //        }

//    //        public void NewDraw()
//    //        {
//    //            base.Draw();
//    //            Console.WriteLine("NewCircle Radius: {0}", _Radius);
//    //        }
//    //    }



//    //    //public sealed class Circle1 : Circle
//    //    //{

//    //    //}

//    //    //public sealed class Circle2 : Circle1
//    //    //{

//    //    //}



//    //    class Program
//    //    {
//    //        static void Main(string[] args)
//    //        {
//    //            Circle r = new NewCircle(5);
//    //            NewCircle n = (NewCircle)r;
//    //            n.Draw();
//    //            r.Draw();  // r correspondes a Circle typ (without polyphism/without virtual)

//    //            ((NewCircle)r).Draw();
//    //            Console.WriteLine("r.radius is: {0}", r.Radius);
//    //            Console.WriteLine("r.radius is: {0}", r._Radius);

//    //            //Circle r = new Circle();
//    //            //NewCircle m = new NewCircle();
//    //        }
//    //    }
//    //}

//}
