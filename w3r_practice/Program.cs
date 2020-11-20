using System;
using System.Collections.Generic;
using System.IO;


namespace w3r_practice
{
    class Practice1
    {
        static void Main(string[] args)
        {
            //swap();
            //mod();
            //range();
            //average1();
            //fahrenheit();
            // //index1();
            //remove1();
            //changepos();
            //test1();
            //Longword();
            //Console.WriteLine(longword2(""));
            //Oddnr();
            //Prime_nr();
            //Digits2();
            //Convert2();
            //Convert3();

            //FileInfo f = new FileInfo("D:/LiLu2020/ALTEN/Technisches Profil_Nachname_Vorname.docx");
            //Console.WriteLine("\nSize of the file: " + f.Length.ToString());

            //Hex2Dec();


        }

        private static void Hex2Dec()
        {
            Console.WriteLine("input a Hex number: ");
            string hexnr = Console.ReadLine();

            int decnr = int.Parse(hexnr, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine("the decimal number is: " + decnr);
        }

        private static void Convert3()
        {
            Console.WriteLine("input a sentence: ");
            string line = Console.ReadLine();

            string result = "";

            List<string> wordsList = new List<string>();
            string[] words = line.Split(new [] { " " }, StringSplitOptions.None);

            for (int i = words.Length -1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);
            foreach (String s in wordsList)
            {
                Console.WriteLine("\nReverse String: " + s);
            }

        }

        private static void Convert2()
        {
            Console.WriteLine("input a sentence: ");
            string lines = Console.ReadLine();
            //string lines2 = Console.ReadLine();

            string words = "";
            string[] words2 = lines.Split(new [] { " " }, StringSplitOptions.None);

            int i;
            for (i = 0; i < words2.Length; ++i)
                {
                words += words2[words2.Length -1 - i] + " ";
            }

            Console.WriteLine(words);
        }

        private static int Digits2()
        {
            
            Console.WriteLine("input a integer: ");
            string a = Console.ReadLine();

            int i;
            int sum = 0;
            for (i = 0; i < a.Length; i++)
            {
                sum += a[i] - '0';
            }
            
            Console.WriteLine(sum);
            return sum;
        }

        private static void Prime_nr()
        {
            Console.WriteLine("\nthe sum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;

            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine(sum.ToString());
        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1)
                return false;
            if (n == 2)
                return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0)
                    return false;

            }
            return true;
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

        private static void range()
        {
            int a;

            Console.Write("\ninput a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }
        }
        private static void average1()
        {
            double a, b, c, d;

            Console.Write("\ninput the 1st number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\ninput the 2nd number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\ninput the 3rd number: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("\ninput the 4th number: ");
            d = Convert.ToDouble(Console.ReadLine());

            double result = (a + b + c + d) / 4;

            Console.WriteLine("\nthe average of {0}, {1}, {2}, {3} is: {4}", a, b, c, d, result);
        }

        //private static void fahrenheit()
        //{
        //    Console.Write("\ninput the celsius: ");
        //    int celsius = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Kelvin = {0}", celsius + 273);
        //    Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        //}
        //private static void index1()
        //{
        //    string text1 = "w3resource";
        //    Console.WriteLine(remove_char("w3resouce", 1));
        //    Console.WriteLine(remove_char(text1, 0));
        //}
        //public static string remove_char(string str, int n)
        //{
        //    return str.Remove(n, 1);
        //}

        public static void remove1()
        {
            string bla = "blablabla";
            bla.Remove(4, 1);
            bla = bla.Remove(4, 1);
            Console.WriteLine(bla);

            // Console.WriteLine(bla.Remove(4,1));
        }
        public static void changepos()
        {
            Console.Write("input a word: ");

            string input1 = Console.ReadLine();
            Console.WriteLine("the original input is: " + input1);

            Console.WriteLine("after the change: " + first_last(input1));

        }
        public static string first_last(string str1)
        {
            return str1.Length > 1
                ? str1.Substring(str1.Length - 1) + str1.Substring(1, str1.Length - 2) + str1.Substring(0, 1) : str1;
        }

        private static void test1()
        {

            Console.Write("input the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"the first number is: {a}");

            Console.Write("\ninput the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"the second number is: {b}");

            int c = a * b;

            if (c < 0)
            {
                Console.WriteLine("\nCheck if one is negative and one is positive: True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        private static bool test2(int n)
        {
            if (Math.Abs(n - 100) < 20 || Math.Abs(n - 200) < 20)
                return true;
            return false;
        }

        private static void longword()
        {
            string line = "Write something to test the longst word";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

            string word = "";
            int ctr = 0;

            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
        }

        private static string Longword2(string line)
        {
            Console.WriteLine("input a sentence: ");
            line = Console.ReadLine();
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

            string word = "";
            int ctr = 0;

            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine("the longest word in the sentence is: " + word);
            return word;
        }

        private static void Oddnr()
        {
            int a;
            for (a = 1; a < 100; a++)
            {
                if (a % 2 == 1)
                {
                    Console.WriteLine(a.ToString());
                }
            }

        }

    }
    
}
