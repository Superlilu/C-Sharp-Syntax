using System;
using TT = Test22;

namespace Test22
    {
        class Test33
        {
            public int a = 5;

            public void test44()
            {
                Console.WriteLine("Hello World");
            }
        }
    }
namespace OOP_Konzept
{


    //class Demo
    //{
    //    public Demo() 
    //    {
    //        Console.WriteLine("just test");
    //    }

    //    public Demo (int x) : this()
    //    {
    //        this.aa = x;
    //    }

    //    private int aa = 10;
    //    public int test()
    //    {
    //        int a = 20;
    //        return this.aa;
    //    }

    //    public int test22()
    //    {

    //        return test();
    //    }


    //}

    class Circle
    {
        //private static int count = 0;
        private int Radius;

        public static int Bigger(Circle a, Circle b)
        {
            if (a.Radius == b.Radius)
            {
                return 0;
            }
            else
            {
                return a.Radius - b.Radius;
            }

        }

        public int Bigger2(Circle x)
        {
            if (x.Radius == this.Radius)
            {
                return 0;
            }
            else
            {
                return this.Radius - x.Radius;
            }
        }
        public Circle(int a)
        {
           
            this.Radius = a;
        }



        //public Circle()
        //{
        //    ++count;

        //}

        //public static void print1()
        //{

        //    Console.WriteLine("times: {0}", Circle.count);
        //}

        //public void print2()
        //{
        //    Console.WriteLine("test for print2");
        //}

    }

    class Trymain
    {

       


        static void Main(string[] args)
        {
            
            TT::Test33 r = new TT::Test33();
            r.test44();


            global::OOP_Konzept.Circle a = new Circle(3);
            Circle b = new Circle(5);

            Console.WriteLine(Circle.Bigger(a, b));
            Console.WriteLine(a.Bigger2(b));



            //Circle a = new Circle();
            //a.print2();
            //Circle.print1();


            //for (int i = 0; i <= 9; ++i)
            //{

            //    new Circle(); 

            //}

            //Circle.print1();

            //Demo x = new Demo();
            //Console.WriteLine("print: {0}", x.test22());

            //Demo y = new Demo(3);
            //Console.WriteLine("y: {0}", y.test());

            //Demo x = new Demo();
            //Console.WriteLine("x: {0}", x.test());
        }
    }

    //class Demo
    //{
    //    private int _Value;
    //    public void DoSomething(Demo obj)
    //    {
    //        obj._Value = 122;
    //    }
    //    public int Value
    //    {
    //        get { return _Value; }
    //        set { _Value = value; }
    //    }
    //}
    //class Demo1
    //{
    //    private int _Value;
    //    public void DoSomething(Demo obj)
    //    {
    //        obj._Value = 122;
    //    }
    //    public int Value
    //    {
    //        get { return _Value; }
    //        set { _Value = value; }
    //    }
    //}

    //class Tester
    //{
    //    static void Main (string[] args)
    //    {

    //        Demo a = new Demo();
    //        Demo b = new Demo();
    //        Demo c;
    //        c = b;

    //        a.Value = 10;
    //        b.Value = 20;
    //        Demo d;
    //        d = a;
    //        a = b;
    //        b = d;
    //        Console.WriteLine("a is: {0}, b is: {1} ", a.Value, b.Value);



    //        //Console.WriteLine(c.Value);


    //        a.DoSomething(b);

            //int x = 5;
            //Tester r = new Tester();
            //Console.WriteLine("x is: {0}", x);
            //Console.WriteLine("Area is: {0}", r.getArea(out x));
            //Console.WriteLine("x is: {0}", x);
            ////Console.WriteLine("Area2 is: {0}", Tester.getArea2(5));

            //Tester r = new Tester();
            //int[] a = {2, 3, 5};
            //Console.WriteLine("m[2]: {0}", r.Test2(a));
            //Console.WriteLine(a[2]);

            //int p = 8;
            //Console.WriteLine("ref x: {0}", Tester.getArea2(ref p));

            //Tester t = new Tester();
            //int[] a = { 1, 2, 3 };
            //Console.WriteLine("Add result: {0}", t.Add(4, 5, a));
            //Console.WriteLine("Add result: {0}", t.Add4(4, 5, 1, 2, 3));
            //Console.WriteLine("Add2 result: {0}", t.Add2(a));
            //Console.WriteLine("Add2 result: {0}", t.Add2(2,2,3));
            //Console.WriteLine("Add2 result: {0}", t.Add3(a));
            //Console.WriteLine("Add2 result: {0}", t.Add3(2, 2, 3));

            //Tester a = new Tester();
            //a.DoSomething("strname", value2: 5);

    //    }


    //    public void DoSomething(string name, int value = -1, int value2 = 2)
    //    {
    //        Console.WriteLine("print: {0} {1}", name, value);
    //        return;
    //    }

    //    public long Add(int value1, int value2, params int[] liste)
    //    {
    //        long sum = value1 + value2;
    //        foreach (int z in liste)
    //            sum += z;
    //        return sum;
    //    }
    //    public long Add4(int value1, int value2, params int[] liste)
    //    {
    //        long sum = 0;
    //        foreach (int z in liste)
    //        {
    //            sum += z;
    //            Console.WriteLine("{0} is in liste", z);
    //        }
                
    //        return sum;
    //    }

    //    public long Add2(params int[] liste)
    //    {
    //        long sum = 0;
    //        foreach (int z in liste)
    //            sum += z;
    //        return sum;
    //    }

    //    public long Add3(int[] liste)
    //    {
    //        long sum = 0;
    //        foreach (int z in liste)
    //            sum += z;
    //        return sum;
    //    }

    //    public int Test2(int[] m)
    //    {
    //        //m = {1,2,4};
    //        m[2] = m[2] + 10;
    //        return m[2]; 
            
    //    }

    //    public int getArea(out int y)
    //    {
    //       y = 10;
    //       return y + 1;
    //    }
    //    public static int getArea2(ref int x)
    //    {
    //        x = 10;
    //        return x + 1;
    //    }
    //}

    //class Circle
    //{
    //    private int radius = 10;
    //    public int Radius
    //    {
    //        get
    //        { return radius; }
    //        set
    //        {
    //            if (value >= 0)
    //                radius = value;
    //            else
    //                Console.WriteLine("error!");
    //        }
    //    }

    //    public int Ra { get; set; }

    //    public int getRadius()
    //    {
    //        return radius;
    //    }

    //    public void setRadius(int v)
    //    {
    //        if (v >= 0)
    //            radius = v;
    //        else
    //            Console.WriteLine("error!");
    //    }

    //}

    //class WhereIsMain
    //{

    //    void DoSomething(int x)
    //    {
    //        Console.WriteLine("calling method with int parameter");
    //    }

    //    void DoSomething(long x)
    //    {
    //        Console.WriteLine("calling method with long parameter");
    //    }

    //    static void Main(string[] args)
    //    {
            //Circle c = new Circle();
            ////c.radius = 10;
            //c.Radius = 10;
            //Console.WriteLine("radius is {0}!", c.getRadius());
            //c.setRadius(20);
            //Console.WriteLine("radius is {0}!", c.getRadius());

            //Console.WriteLine("Ra is {0}!", c.Ra);
            //c.Ra = 100;
            //Console.WriteLine("Ra is {0}!", c.Ra);
            //c.Ra = -50;
            //Console.WriteLine("Ra is {0}!", c.Ra);

            //WhereIsMain w = new WhereIsMain();
            //w.DoSomething(78);
            //w.DoSomething(78L);
            //w.DoSomething((long)78);

    //        string s = Console.ReadLine();
    //        Console.WriteLine(Convert.ToInt32("bdfdasfdsa"));

    //    }
    //}
    //class Child
    //{


    //    static int Bigger(int num1, int num2, int num3)
    //    {

    //        if (num1 > num2)
    //        {
    //            if (num1 > num3)
    //            {
    //                Console.WriteLine($"{num1} is the greatest among three \n");
    //                return num1;
    //            }

    //            else
    //            {
    //                Console.WriteLine($"{num3} is the greatest among three \n");
    //                return num3;
    //            }
    //        }

    //        else if (num2 > num3)
    //        {
    //            Console.WriteLine($"{num2} is the greatest among three \n");
    //            return num2;
    //        }

    //        else
    //        {
    //            Console.WriteLine($"{num3} is the greatest among three \n");
    //            return num3;
    //        }

    //    }

    //    static int Smallst(int num1, int num2, int num3)
    //    {
    //        if (num1 < num2)
    //        {
    //            if (num1 < num3)
    //            {
    //                Console.WriteLine("{0} is the smallst among three \n", num1);
    //                return num1;
    //            }
    //            else
    //            {
    //                Console.WriteLine($"{num3} is the smallst among three \n");
    //                return num3;
    //            }
    //        }
    //        else if (num2 < num3)
    //        {
    //            Console.WriteLine($"{num2} is the smallst among three \n");
    //            return num2;
    //        }

    //        else
    //        {
    //            Console.WriteLine($"{num3} is the smallst among three \n");
    //            return num3;
    //        }
    //    }

    //    static void Main (string[] args)
    //    {
    //         int h1 = 1;
    //         int w1 = 10;

    //         int h2 = 3;
    //         int w2 = 1000;

    //         int h3 = 2;
    //         int w3 = 50;

    //        int[] height = new int[3];
    //        height[0] = Bigger(h1, h2, h3);
    //        height[2] = Smallst(h1, h2, h3);
    //        height[1] = (h1 + h2 + h3) - height[0] - height[2];

    //        Console.WriteLine("the range of height of the three are: {0}, {1}, {2}", height[0], height[1], height[2]);

       
            
    //        //Console.WriteLine("the heighst Child is: ", Child.Bigger(h1, h2, h3));
    //        //Console.WriteLine("the lowst Child is: ", Child.Smallst(h1, h2, h3));

    //    }
    //}
      


    //public class Zuweis
    //{

    //}

    //public class Tester
    //{
    //    static void Main(string[] args)
    //    {
    //        Kind a = new Kind();
    //        Kind b = new Kind();
    //        Kind c = new Kind();

    //        a.height = 1;
    //        a.weight = 10;

    //        b.height = 2;
    //        b.weight = 1000;

    //        c.height = 3;
    //        c.weight = 50;



    //    }


    //}




    //{
     
        
    //}

    //class Line
    //{
    //private double length;   // 线条的长度
    //public Line()  // 构造函数
    //{
    //    Console.WriteLine("obj built");
    //}
    //~Line() //析构函数
    //{
    //    Console.WriteLine("obj deleted");
    //}

    //public void setLength(double len)
    //{
    //    length = len;
    //}
    //public double getLength()
    //{
    //    return length;
    //}

    //static void Main(string[] args)
    //{
    //    Line line = new Line();

    //    line.setLength(6.0);
    //    Console.WriteLine("line length： {0}", line.getLength());
    //    //line = null;
    //    //GC.Collect();
    //    //Console.ReadKey();
    //}
    //}

    /* ----------Exercise for Inheritance------------------------------------------------*/
    /* define a class according another class */

    //class NumberManipulator
    //{
    //    public int factorial(int num)
    //    {
    //        /* 局部变量定义 */
    //        int result;

    //        if (num == 1)
    //        {
    //            return 1;
    //        }
    //        else
    //        {
    //            result = factorial(num - 1) * num;
    //            return result;
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        NumberManipulator n = new NumberManipulator();
    //        //调用 factorial 方法
    //        Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
    //        Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
    //        Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));
    //        Console.ReadLine();

    //    }
    //}

    //class Rectangle
    //{
    //    protected double length;
    //    protected double width;
    //    public Rectangle(double x, double y)
    //    {
    //        length = x;
    //        width = y;
    //    }

    //    public double GetArea()
    //    {
    //        return length * width;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("length： {0}", length);
    //        Console.WriteLine("width： {0}", width);
    //        Console.WriteLine("area： {0}", GetArea());
    //    }
    //}

    //class Tabletop : Rectangle
    //{
    //    private double cost = 1000.0;
    //    public Tabletop(double l, double w) : base(w, w)
    //    { 

    //    }
    //    public double GetCost()
    //    {
    //        double cost;
    //        cost = GetArea() * 70 - this.cost;
    //        return cost;
    //    }

    //    public new void Display()
    //    {
    //        base.Display();
    //        Console.WriteLine("cost： {0}", GetCost());
    //    }
    //}

    //class ExecuteRectangle
    //{
    //    static void Main(string[] args)
    //    {
    //        Tabletop t = new Tabletop(4.5, 7.5);
    //        t.Display();
    //        Console.ReadLine();
    //    }
    //}

    //class Shape
    //{
    //    public void setWidth(int w)
    //    {
    //        width = w;
    //    }

    //    public void setHeight(int h)
    //    {
    //        height = h;
    //    }

    //    protected int width;
    //    protected int height;
    //}

    //class Rectangle: Shape
    //{
    //    public int getArea()
    //    {
    //        return width * height;
    //    }
    //}

    //class RectangleTester
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle Rect = new Rectangle();
    //        Rect.setWidth(5);
    //        Rect.setHeight(7);

    //        Console.WriteLine("the area: {0}", Rect.getArea());
    //        Console.ReadKey();
    //    }
    //}




    /* ----------Exercise for Class------------------------------------------------*/

    /* 把一个成员函数声明为 static。
     这样的函数只能访问静态变量。
    静态函数在对象被创建之前就已经存在。*/

    //class StaticVar
    //{
    //    public static int num;
    //    public void count()
    //    {
    //        num++;
    //    }
    //    public static int getNum()
    //    {
    //        return num;
    //    }
    //}
    //class StaticTester
    //{
    //    static void Main(string[] args)
    //    {
    //        StaticVar s = new StaticVar();
    //        s.count();
    //        s.count();
    //        s.count();
    //        Console.WriteLine("variable num： {0}", StaticVar.getNum());
    //        Console.ReadKey();
    //    }
    //}


    /* C#类的静态成员
    我们可以使用 static 关键字把类成员定义为静态的。
    当我们声明一个类成员为静态时，意味着无论有多少个类的对象被创建，只会有一个该静态成员的副本。

    关键字 static 意味着类中只有一个该成员的实例。
    静态变量用于定义常量，因为它们的值可以通过直接调用类而不需要创建类的实例来获取。
    静态变量可在成员函数或类的定义外部进行初始化。你也可以在类的定义内部初始化静态变量。*/

    //class StaticVar
    //{
    //    public static int num;  // try to remove static here, run again
    //    public void count()
    //    {
    //        num++;
    //    }

    //    public int getNum()
    //    {
    //        return num;
    //    }
    //}

    //class StaticTester
    //{
    //    static void Main(string[] args)
    //    {
    //        StaticVar s1 = new StaticVar();
    //        StaticVar s2 = new StaticVar();
    //        s1.count();
    //        s1.count();
    //        s1.count();
    //        s2.count();
    //        s2.count();
    //        s2.count();

    //        Console.WriteLine("variable of s1 num: {0}", s1.getNum());
    //        Console.WriteLine("variable of s2 num: {0}", s2.getNum());
    //        Console.WriteLine("variable of s2 num: {0}", StaticVar.num);
    //    }
    //}


    /* 类的 析构函数 是类的一个特殊的成员函数，当类的对象超出范围时执行。
    析构函数的名称是在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数。
    析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。*/

    //class Line
    //{
    //    private double length;
    //    public Line()
    //    {
    //        Console.WriteLine("obj is created");
    //    }
    //    ~Line()
    //    {
    //        Console.WriteLine("obj is deleted");
    //    }

    //    public void setLength(double len)
    //    {
    //        length = len;
    //    }
    //    public double getLength()
    //    {
    //        return length;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Line line = new Line();
    //        line.setLength(6.0);
    //        Console.WriteLine("the length of the line： {0}", line.getLength());
    //    }
    //}

    /*默认的构造函数没有任何参数。
     但是如果你需要一个带有参数的构造函数可以有参数，这种构造函数叫做参数化构造函数。
     这种技术可以帮助你在创建对象的同时给对象赋初始值 */

    //class Line
    //{
    //    private static double length = 1.0;


    //    public Line(double len)
    //    {
    //        //Console.WriteLine("the obj is created, length = {0}", len);
    //        length = len;
    //    }

    //    public void setLength(double len)
    //    {
    //        length = len;
    //    }
    //    public double getLength()
    //    {

    //        return length;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Line line = new Line(10.0);
    //        Console.WriteLine("the length is: {0}", line.getLength());

    //        Line line1 = new Line(8.0);
    //        Console.WriteLine("the length is: {0}", line1.getLength());

    //        line.setLength(6.0);
    //        Console.WriteLine("the length is： {0}", line.getLength());
    //        Console.ReadKey();
    //    }
    //}


    /*  C# 中的构造函数
    类的 构造函数 是类的一个特殊的成员函数，当创建类的新对象时执行。
    构造函数的名称与类的名称完全相同，它没有任何返回类型。*/

    //class Line
    //{
    //    private double length;
    //    public Line()
    //    {
    //        //Console.WriteLine("obj is created");
    //    }

    //    public void setLength(double len)
    //    {
    //        length = len;
    //    }

    //    public double getLength()
    //    {
    //        return length;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Line line1 = new Line();
    //        line1.setLength(6.0);
    //        Console.WriteLine($"the length of line1 is {line1.getLength()}");
    //    }

    //}



    /* 成员函数和封装
    类的成员函数是一个在类定义中有它的定义或原型的函数，就像其他变量一样。作为类的一个成员，它能在类的任何对象上操作，且能访问该对象的类的所有成员。
    成员变量是对象的属性（从设计角度），且它们保持私有来实现封装。这些变量只能使用公共成员函数来访问。*/

    //class Box
    //{
    //    public double length;
    //    public double breadth;
    //    public double height;

    //    public void setLenght(double len)
    //    {
    //        length = len;
    //    }

    //    public void setBreadth(double bre)
    //    {
    //        breadth = bre;
    //    }

    //    public void setHeight(double hei)
    //    {
    //        height = hei;
    //    }

    //    public double getVolumen()
    //    {
    //        return length * breadth * height;
    //    }

    //    class BoxTester
    //    {
    //        static void Main (string[] args)
    //        {
    //            Box Box1 = new Box();
    //            Box Box2 = new Box();
    //            double volume;

    //            Box1.setLenght(6.0);
    //            Box1.setBreadth(7.0);
    //            Box1.setHeight(5.0);

    //            Box2.setLenght(12.0);
    //            Box2.setBreadth(13.0);
    //            Box2.setHeight(10.0);

    //            volume = Box1.getVolumen();
    //            Console.WriteLine("Volume der Box1: {0}", volume);

    //            volume = Box2.getVolumen();
    //            Console.WriteLine("Volume der Box2: {0}", volume);
    //            Console.ReadKey();

    //        }
    //    }

    //}


    /* 1st e.g. for Class */

    //class Box
    //{

    //        public double length;
    //        public double breadth;
    //        public double height;
    //}

    //class Boxtester
    //{

    //        static void Main(string[] args)
    //        {
    //            Box Box1 = new Box();
    //            Box Box2 = new Box();
    //            double volume = 0.0;

    //            Box1.height = 5.0;
    //            Box1.length = 6.0;
    //            Box1.breadth = 7.0;

    //            Box2.height = 10.0;
    //            Box2.length = 12.0;
    //            Box2.breadth = 13.0;

    //            volume = Box1.length * Box1.breadth * Box1.height;
    //            Console.WriteLine("Volume der Box1: {0}", volume);

    //            volume = Box2.length * Box2.breadth * Box2.height;
    //            Console.WriteLine("Volume der Box2: {0}", volume);
    //            Console.ReadKey();

    //        }


    //}
}
