using System;

namespace Kap4_8
{
    public interface IDraw
    {
        void Graf();
    }

    public class GeometricObject
    {
        public GeometricObject()
        {

        }

        public virtual void Start()
        {
            Console.WriteLine("it's a GeometricObject");
        }
    }

    public class Circle : GeometricObject
    {

        public Circle()
        {

        }
        
        public override void Start()
        {
            Console.WriteLine("it's a Circle");
        }

        public int Radius { get; set; }
        
        public virtual void Eigenschaft1(int c)
        {
            Radius = c;
        }

    }

    public class GraficCircle : Circle, IDraw
    {
        public GraficCircle()
        {

        }

        public override void Eigenschaft1(int c)
        {
            base.Eigenschaft1(c);
            double Area1 = Math.Pow(c, 2) * Math.PI;
            Console.WriteLine("the Area of the Circle is: {0}", Area1);
        }

        public void Graf()
        {
            Console.WriteLine("draw the grafic in the instance of circle");
        }
    }

    public class Rectangle : GeometricObject
    {
        public Rectangle()
        {

        }

        public override void Start()
        {
            Console.WriteLine("it's a Rectangle");
        }

        public int Length {get; set;}
        public int Width { get; set; }

        public virtual void Eigenschaft2(int x, int y)
        {
            Length = x;
            Width = y;
        }

    }

    public class GraficRectangle : Rectangle, IDraw
    {
        public GraficRectangle()
        {

        }

        public int Area2 { get; set; }
        public override void Eigenschaft2(int x, int y)
        {
            base.Eigenschaft2(x, y);
            Area2 = x * y;
            Console.WriteLine("the Area of the Rectangle is: {0}", Area2);
        }

        
        public void Graf()
        {
            Console.WriteLine("draw the grafic in instanz of rectangle");
        }
    }


    public class Test
    {
        static void Main(string[] args)
        {
            GraficRectangle r = new GraficRectangle();
            r.Eigenschaft2(3, 5);
            r.Graf();

            Console.WriteLine("\n");

            GraficCircle c = new GraficCircle();
            c.Eigenschaft1(10);
            c.Graf();

            Console.WriteLine(typeof(string).Assembly.ImageRuntimeVersion);
          

        }
    }
}

//namespace Kap4_4
//{
//    public abstract class A
//    {
//        public abstract void Start();

//    }

//    //public sealed class B : A   //class sealed: class can not be inherated
//    public class B : A
//    {
//        //public sealed override void Start()  // methode sealed: method can not be overrided
//        public override void Start()
//        {
//            Console.WriteLine("start B");
//        }
//    }

//    public class C : B 
//    {
//        public override void Start()
//        {
//            Console.WriteLine("start C");
//        }
//    }


//    public class Test
//    {
//        static void Main(string[] args)
//        {
//            A ab = new B();
//            ab.Start();
//            B bc = new C();
//            bc.Start();

//            //Int32 a;
//            //a.ToString();
//        }
//    }


//}


//namespace Jicheng
//{

//    public abstract class Auto
//    {
//        public Auto(string x)
//        {
//            Farbe = x;
//        }

//        protected string Farbe;
//        public abstract void Drive(string x);
//        public virtual void Break()
//        {
//            Console.WriteLine("Auto is breaked");
//        }

//        public void Accelerate()
//        {
//            Console.WriteLine("Auto Accelerate");
//        }
//    }

//    public class PKW : Auto
//    {
//        public PKW(string y) : base(y)
//        {

//        }

//        public override void Drive(string x)
//        {
//            Console.WriteLine("typ of drive:{0}, color is: {1}", x, base.Farbe);
//        }

//        public override void Break()
//        {
//            Console.WriteLine("PKW is breaked again");
//        }

//        public new void Accelerate()
//        {
//            Console.WriteLine("New Auto Accelarate");
//        }
//    }
//    public class LKW : Auto
//    {
//        public LKW() : base("")
//        { }
//        public override void Drive(string n)
//        {
//        }

//    }


//    class Program
//    {
//        public static void TestTyp(Auto x)
//        {
//            if (x is Auto)
//            {
//                Console.WriteLine($"{x} is Auto Typ");
//            }
//            if (x is PKW)
//            {
//                Console.WriteLine($"{x} is PKW Typ");
//            }
//        }
//        static void Main(string[] args)
//        {
//            PKW r = new PKW("red");  // by the Polymophism (virtual) the obj typ coresponds the newed typ (here PKW)
//            r.Drive("automatic");
//            r.Break();

//            Auto a = r;  // a is actually a PKW typ, so a.Break() will call the class PKW → Polymophism (Break method is marked as virtual)
//            a.Break();

//            r.Accelerate();
//            a.Accelerate(); // a corresponds here the base

//            LKW k = new LKW();

//            TestTyp(k);
//            TestTyp(a);
//            TestTyp(r);

//            PKW p;
//            p = a as PKW;
//            //p = (PKW)a;


//        }
//    }
//}


//namespace Kap4
//{

//    public class Circle
//    {
//        public Circle(int x)
//        {
//            _Radius = x;
//        }

//        protected int _Radius;
//        public int Radius
//        {
//            get { return _Radius; }
//            set { _Radius = value; }
//        }

//        public void Draw()
//        {
//            Console.WriteLine("Circle draw.");
//        }

//    }

//    public class NewCircle : Circle
//    {
//        public NewCircle(int y) : base(y)
//        {

//        }

//        public new void Draw()
//        {
//            base.Draw();
//            Console.WriteLine("overwrite for newCircle");
//        }

//        public void NewDraw()
//        {
//            base.Draw();
//            Console.WriteLine("NewCircle Radius: {0}", _Radius);
//        }
//    }



//    //public sealed class Circle1 : Circle
//    //{

//    //}

//    //public sealed class Circle2 : Circle1
//    //{

//    //}



//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Circle r = new NewCircle(5);
//            NewCircle n = (NewCircle)r;
//            n.Draw();
//            r.Draw();  // r correspondes a Circle typ (without polyphism/without virtual)

//            ((NewCircle)r).Draw();
//            Console.WriteLine("r.radius is: {0}", r.Radius);
//            Console.WriteLine("r.radius is: {0}", r._Radius);

//            //Circle r = new Circle();
//            //NewCircle m = new NewCircle();
//        }
//    }
//}
