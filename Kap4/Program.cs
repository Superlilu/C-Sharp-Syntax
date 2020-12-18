using System;


namespace Jicheng
{

    public abstract class Auto
    {
        public Auto(string x)
        {
            Farbe = x;
        }

        protected string Farbe;
        public abstract void Drive(string x);
        public virtual void Break()
        {
            Console.WriteLine("Auto is breaked");
        }

        public void Accelerate()
        {
            Console.WriteLine("Auto Accelerate");
        }
    }

    public class PKW : Auto
    {
        public PKW (string y) : base(y)
        {

        }

        public override void Drive(string x)
        {            
            Console.WriteLine("typ of drive:{0}, color is: {1}", x, base.Farbe);
        }

        public override void Break()
        {
            Console.WriteLine("PKW is breaked again");
        }

        public new void Accelerate()
        {
            Console.WriteLine("New Auto Accelarate");
        }
    }
    public class LKW : Auto
    {
        public LKW () : base("")
        { }
        public override void Drive(string n)
        {
        }

    }

 
    class Program
    {
        public static void TestTyp(Auto x)
        {
            if (x is Auto)
            {
                Console.WriteLine($"{x} is Auto Typ");
            }
            if (x is PKW)
            {
                Console.WriteLine($"{x} is PKW Typ");
            }
        }
        static void Main(string[] args)
        {
            PKW r = new PKW("red");  // by the Polymophism (virtual) the obj typ coresponds the newed typ (here PKW)
            r.Drive("automatic");
            r.Break();

            Auto a = r;  // a is actually a PKW typ, so a.Break() will call the class PKW → Polymophism (Break method is marked as virtual)
            a.Break();

            r.Accelerate();
            a.Accelerate(); // a corresponds here the base

            LKW k = new LKW();

            TestTyp(k);
            TestTyp(a);
            TestTyp(r);


        }
    }
}


//namespace Kap4
//{

    //public class Circle
    //{
    //    public Circle(int x)
    //    {
    //        _Radius = x;
    //    }

    //    protected int _Radius;
    //    public int Radius
    //    {
    //        get { return _Radius; }
    //        set { _Radius = value; }
    //    }

    //    public void Draw()
    //    {
    //        Console.WriteLine("Circle draw.");
    //    }

    //}

    //public class NewCircle : Circle
    //{
    //    public NewCircle(int y): base(y)
    //    {

    //    }

    //    public new void Draw()
    //    {
    //        base.Draw();
    //        Console.WriteLine("overwrite for newCircle");
    //    }

    //    public void NewDraw()
    //    {
    //        base.Draw();
    //        Console.WriteLine("NewCircle Radius: {0}", _Radius);
    //    }
    //}

    

    //public sealed class Circle1 : Circle
    //{

    //}

    //public sealed class Circle2 : Circle1
    //{

    //}



//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Circle r = new NewCircle(5);
//            //NewCircle n = (NewCircle)r;
//            //n.Draw();
//            //r.Draw();  // r correspondes a Circle typ (without polyphism/without virtual)

//            //((NewCircle)r).Draw();
//            //Console.WriteLine("r.radius is: {0}", r.Radius);
//            //Console.WriteLine("r.radius is: {0}", r._Radius);

//            //Circle r = new Circle();
//            //NewCircle m = new NewCircle();
//        }
//    }
//}
