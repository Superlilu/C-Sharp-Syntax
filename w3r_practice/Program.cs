﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

struct Books
{
    public string title;
    public string author;
    public int book_id;

    public void SetValue(string t, string a, int id)
    {
        title = t;
        author = a;
        book_id = id;

    }
    public void Display()
    {
        Console.WriteLine("title: {0}", title);
        Console.WriteLine("author: " + author);
        Console.WriteLine($"book_id is {book_id}");
    }
}

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
            //MultiArray();
            //Copies();
            //Multiple();
            //StartWith();
            //CheckRange();
            //CheckHP();
            //Compare3();
            //NearNr();
            //ThreeTimeW();
            //Upper();

            //Console.WriteLine("input a string: ");
            //string str2 = Console.ReadLine();
            //Console.WriteLine(Test4(str2));

            //while (true)
            //Test5();

            // num[0].Equals(nums[nums.Length-1]); → (True/False)

            //Rotate();
            //Compare4();

            //int[] nums = { 2, 4, 5, 7, 13 };
            //Console.WriteLine("array is: {0}", string.Join(", ", nums));
            //Console.WriteLine("Check if the array contains an odd nr: " + Oddnr(nums));

            //Cencury();

            //Console.WriteLine(Convert.ToString(Century2(1900)));          
            //Console.WriteLine(CheckPalidrome("abba"));
            //Console.WriteLine("\"aa\""); 
            //Console.WriteLine("'aa'");
            //Array1();
            //String1();
            //String2();

            ////Books Book1;

            ////Book1.title = "C Sharp Tutorial";
            ////Book1.author = "anonym";
            ////Book1.book_id = 645821;

            ////Console.WriteLine("Book 1 title: " + Book1.title);
            ////Console.WriteLine("Book 1 ID: {0}", Book1.book_id);
            ////Console.ReadKey();

            //Books Book1 = new Books();
            //Book1.SetValue("C Sharp", "Anonym", 35487);
            //Book1.Display();

            // enum Day = { Mon, Thu, Wen, Thur, Fri, Sat, Sun};

            //Console.WriteLine(Test(1, 2));
            
            //while (true)
            Console.WriteLine(Test7("C#1"));
            Console.ReadLine();
        }



        public static bool Test7(string s)
        {
            return (s.Length < 3 && s.Equals("C#") || (s.StartsWith("C#") && s[2] == ' '));
        }

        public static string TestStr6(string s)
        {
            if (s.Length < 3)
            {
                return s + s + s;
            }
            else
            {
                string x = s.Substring(0, 3);
                return x + s + x;
            }

        }

        public static bool Test6(int x)
        {
            return x % 3 == 0 || x % 7 == 0;
        }

        public static string TestStr5(string s)
        {
            //char c = s[s.Length - 1];
            string c = s.Substring(s.Length - 1);
            return c + s + c;
     
        }
        public static string TestStr4(string s)
        {
            return s.Length < 2 ? s : s.Substring(0, 2) + s.Substring(0,2);
        }


        public static string TestStr3(string s)
        {
            return s.Length > 1 ? s.Substring(s.Length-1) + s.Substring(1, s.Length-2) + s.Substring(0,1) : s;
        }

        public static string TestStr2(string s, int n)
        {
            return s.Remove(n, 1);
        }
        public static string TestStr(string s)
        {
            if (s.Length > 2 && s.Substring(0, 2) == "if")
                return s;
            return "if " + s;
        }

        public static bool Test10(int x)
        {
            if (Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
                return true;
            return false;
        }

        public static bool Test30(int x, int y)
        {
            return x == 30 || y == 30 || (x + y == 30);
        }

        public static int Test_50(int n)
        {
            const int x = 50;
            if (n > x)
            {
                return (n - x);
            }
            return (x - n) * 3;
        }

        public static int Test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
        private static void String1()
        {
            //just explain
            char[] letters = {'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters); // 构造函数

            string[] sarray = { "Helle", "from", "Peking" };
            string message = string.Join(" ", sarray);

            DateTime waiting = new DateTime(2020, 11, 23, 12, 35, 59);
            string chat = String.Format("Message sent at {0:t} on {0:D}");

        }

        private static void String2()
        {
            // just to explain
            string line = "its a sample of a string";
            string linex = "its just a text";
            String.Compare(line, linex);
            string.Concat(line, linex); // connect several obj
            line.Contains("test");
            line.EndsWith("abc");
            line.Equals("abc");
            string.Equals("ab", "bc");
            line.Insert(3, "hi");
            string.IsNullOrEmpty(line);
            line.Remove(3, 5);
            line.Replace('a', 'b');
            line.Replace("sample", "e.g.");
            line.Split(new[] { " " }, StringSplitOptions.None);
            line.ToCharArray();
            line.TrimEnd();
            line.ToUpper();
            string.Copy(line); //obsolete
            //line.CopyTo(2, 's', 3, 4);



        }

        private static void Array1()
        {
            // only to explain the array
            double[] balance = new double[10]; // ini. the array
            balance[1] = 3.25;
            //
            double[] balance1 = { 1, 2, 1.3, 2.5 };
            //
            int[] nums = new int[5] { 1, 5, 7, 4, 2 }; // without 5 is also ok: new int[] {1, 3, 4, 5, 3};
            int[] nums2 = nums;
            // all the components in a int [] will be initialised as 0

            // to explain the visit of array members
            DateTime a = new DateTime();
        }

        public static bool CheckPalidrome(string str)
        {
            char[] c = str.ToCharArray();
            //str.ToCharArray();
            return new string(c).Equals(str);
            // new string(c).Equals(str)
        }

        public static int Century2(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

        private static void Cencury()
        {
            Console.WriteLine("input a year: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = a / 100 + 1;

            Console.WriteLine("the century of the year {0} is {1}", a, b);
        }

        private static bool Oddnr(int[] nums)
        {


            foreach ( int x in nums)
            {
                if (x % 2 == 0)
                    return true;
            }
            return false;

        }

        private static void Compare4()
        {
            int[] num = { 8, 3, 6, 10, 2, 7};
            Console.WriteLine("\nArray is: [{0}]", string.Join(", ", num));
            int a = num[0];

            for (int i = 0; i < num.Length-1; i++)
            {
                if (num[i+1] > a)
                {
                    a = num[i + 1];
                }
              
            }
            Console.WriteLine($"the biggst nr. is: {a}");
        }

        private static void Rotate()
        {
            int[] num = { 1, 2, 8 };
            Console.WriteLine("\n Array1: [{0}]", string.Join(", ", num));
            // string.Join("separator", array);
            var temp = num[0];
            for (int i = 0; i < num.Length - 1; i++)
            {
                num[i] = num[i + 1];
            }
            num[num.Length - 1] = temp;
            Console.WriteLine("\n After Rotating the new array bekomes: [{0}]", string.Join(", ", num));
        }

        private static void Test5()
        {
            int[] nums = {1, 2, 3, 4, 5, 4, 3, 6, 4, 8, 3, 2};
            Console.WriteLine("Array: [{0}]", string.Join("; ", nums));
            // string.Join(",", nums)

            //string[] line2 = new[] { "" };
            //String line3 = new String("");
            string line2 = "";
            for (int i = 0; i < nums.Length; ++i)
            {
                char a = (char)(nums[i] + '0');
                // char a = (char) (nums[i] + '0'); → explizit convert to char: (char)
                line2 += a + " ";
            }
            Console.WriteLine(line2);

            Console.WriteLine("input an integer: ");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of " + x + " present in the said array: ");
            Console.WriteLine(nums.Count(s => s == x));
            //Console.WriteLine(nums.Count(s => s == x));
        }



        public static bool Test4(string str2)
        {
            int ctr = 0;
            for (int i = 0; i < str2.Length - 1; i++)
            {
                if (str2[i].Equals('w'))
                {
                    ctr++;
                }
                if (str2.Substring(i, 2).Equals("ww") && ctr > 2)
                {
                return true;
                }
            }
            return false;
        }

        private static void Upper()
        {
            Console.WriteLine("input a string: ");
            string str = Console.ReadLine();

            if (str.Length < 4)
            {
                Console.WriteLine(str.ToUpper());
            }    
            else
            {
                Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
            }

        }

        private static void ThreeTimeW()
        {
            Console.WriteLine("input a string that contains at least one 'w' char: ");
            string str = Console.ReadLine();

            int count = str.Count(s => s == 'w');
            Console.WriteLine("Test the string contains 'w' 1-3 times?");
            Console.WriteLine(count >= 1 && count <= 3);

        }
        
        private static void NearNr()
        {
            Console.WriteLine("Check which Nr. is near to 20");

            Console.WriteLine("\nInput first interger: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput 2nd interger: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int a = Math.Abs(x - 20);
            int b = Math.Abs(y - 20);

            Console.WriteLine("\nthe nr that is near to 20 is: ");
            Console.WriteLine(a == b ? 0: (a < b ? x: y));
            // Console.WriteLine(a == b ? 0: (a < b ? x: y));
        }

        private static void Compare3()
        {
            Console.WriteLine("\n Input first interger: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Input 2nd interger: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Input 3rd interger: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y,z)));
            Console.WriteLine("Smallest of three: " + Math.Min(x, Math.Min(y, z)));
        }

        private static void CheckHP()
        {
            Console.WriteLine("input a string: ");
            string str = Console.ReadLine();

            Console.WriteLine((str.Substring(1, 2).Equals("HP")) ? str.Remove(1, 2) : str);
            // str.Substring(0,1,2)
            // str.Equals("ABC")
            // str.Remove(0,1)
        }

        private static void CheckRange()
        {
            Console.WriteLine("input an integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input another interger: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a > -10 && a < 10) || (b > -10 && b < 10));
            //equal →  Console.WriteLine((a > -10 && a < 10) || (b > -10 && b < 10)? "True" : "False")
        }

        private static void StartWith()
        {
            Console.WriteLine("input a sentence: ");
            string line = Console.ReadLine();
            Console.WriteLine("check if the sentence start with Hello:");

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

            if (words[0] == "Hello")
            {
                Console.WriteLine("True");
            } 
            else
            {
                Console.WriteLine("False");
            }    
        }

        private static void Multiple()
        {
            Console.WriteLine("input a positive number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("check if the nr. is a multiple of 3 or 7: ");
            Console.WriteLine((a % 3 == 0 || a % 7 == 0) ? "yes" : "no");
        }

        private static void Copies()
        {
            Console.WriteLine("input a sentence: ");
            string str = Console.ReadLine();

            Console.WriteLine(str.Length < 4 ? str: str.Substring(str.Length-4) + str.Substring(str.Length-4));
            //str.Substring(i)  → start from i, continues to the end
        }

        private static void MultiArray()
        {
            int[] a = { 1, 3, -5, 4 };
            int[] b = { 1, 4, -5, -2 };

            //int[] c = {a[0] * b[0], a[1] * b[1], a[2] * b[2], a[3] * b[3]};
            //Console.WriteLine(c[0]);

            ////int[] c = new int[4];

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write(a[i] * b[i] + " ");
            //}

            int i = 0;
            while (true)
            {
                if (!(i < 4))
                    break;
                Console.Write(a[i] * b[i] + " ");
                i++;

            }


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
