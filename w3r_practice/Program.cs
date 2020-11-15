using System;

namespace w3r_practice
{
    class Practice1
    {
        static void Main(string[] args)
        {
            //swap();
            //mod();
        }

        private static void swap()
        {
            int a, b, temp;
            Console.Write("\n input the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\n input the second number: ");
            b = int.Parse(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;

            Console.Write("\nafter swap: \nthe first Number: {0} \nthe second Number: {1}", a, b);
            Console.Read();
        }

        private static void mod()
        {
            int a, b;
            Console.WriteLine("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} mod {1} = {2}", a, b, a % b);
        }
            

    }
}
