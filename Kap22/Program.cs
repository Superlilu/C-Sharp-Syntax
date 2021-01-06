using System;
using System.Globalization;
namespace Kap22
{
    class Program
    {
        public static void GetSubstrings(string text)
        {
            string[] liste = text.Split(';');
            for (int i = 0; i <= liste.GetUpperBound(0); i++)
                Console.WriteLine(liste[i]);
            //Console.Write(liste[i] + " ");
        }
        static void Main(string[] args)
        {
            //float d = 0.01985F;
            //Console.WriteLine(d.ToString("P"));  // P: Prozent

            float d = 123.505F;
            Console.WriteLine(d.ToString("E"));

            double dbl = 12.25;
            CultureInfo culture = new CultureInfo("de-DE");
            NumberFormatInfo nfi = culture.NumberFormat;
            nfi.NumberDecimalSeparator = "*";
            Console.WriteLine(String.Format(culture, "{0}", dbl));

            //CultureInfo culture = new CultureInfo("it-IT");
            //// Ausgabe: sabato 17 settembre 2018
            //Console.WriteLine(String.Format(culture, "{0:D}", DateTime.Now));

            Console.WriteLine(DateTime.Now.ToString());  // 17.09.2018 20:51:56
            Console.WriteLine(String.Format("{0:F}", DateTime.Now)); // F: Date & Time    Mittwoch, 17. September 2018 20:51:56
            Console.WriteLine(String.Format("{0:D}", DateTime.Now)); // D: Date only      Mittwoch, 17. September 2018

            DateTime now = new DateTime(2002, 2, 3, 12, 0, 0);
            TimeSpan span = new TimeSpan(3, 12, 15);
            now = now.Add(span);
            Console.WriteLine(now);

            DateTime date = new DateTime(1965, 5, 12);
            Console.WriteLine("Datum: {0}", date);
            Console.WriteLine("Ticks: {0}", date.Ticks);

            Console.WriteLine(DateTime.Now.Ticks);
            Console.WriteLine(DateTime.Now);  // DateTime.Now
            DateTime newDate = DateTime.Now;
            Console.Write(newDate);
            Console.Write(" " + newDate.DayOfWeek.ToString());


            ////--------------Kap_16----------------------------
            //string text = "C# ist spitze.";
            //int x = text.IndexOf("spitze");
            //Console.WriteLine(x);

            //text = text.Insert(text.IndexOf("spitze"), "absolute ");
            //Console.WriteLine(text);

            //text = text.Insert(0, "I think ");
            //Console.WriteLine(text);

            //text = "Schule macht viel Spaß";
            //text = text.Replace('S', 'H'); // all the S in text will be replaced!
            //Console.WriteLine(text);
            //text = text.Replace("viel", "nie");
            //Console.WriteLine(text);

            ////------------------------------------
            //text = "Schule macht viel Spaß";
            ////string[] splits = text.Split("macht");
            ////string[] splits = text.Split("");
            //char[] chars = { 'u', 't', 'p' };
            //string[] splits = text.Split(chars);
            //Console.WriteLine(splits[0]);

            //foreach (string item in splits)
            //{
            //    Console.Write(item + "; ");
            //}
            ////-----------------------------------------

            //text = "Schule macht viel Spaß";
            //string[] liste = text.Split(' ');
            //int b = liste.GetUpperBound(0);  // return the index of last element in the array → here 3
            //Console.WriteLine("\n\n" + b);
            //Console.WriteLine();

            //for (int i = 0; i <= liste.GetUpperBound(0); i++)
            //    Console.WriteLine(liste[i]);

            ////--------------------------------------------
            //Console.WriteLine();
            //string[] str = new String[4];
            //str[0] = "Busch;";
            //str[1] = "Fridolin;";
            //str[2] = "Schlauberger Gasse 12;";
            //str[3] = "München";
            //string strArr;
            //strArr = string.Concat(str);
            //Console.WriteLine(strArr);
            //Console.WriteLine();
            //GetSubstrings(strArr); // defination see above

            //char[] charArr = { 'K', 'a', 'r', 'n', 'e', 'v', 'a', 'l' };
            //string text5 = new string(charArr);
            //Console.WriteLine(text5);

            //string text6 = "Quantenmechanik";
            //char[] charArray = text6.ToCharArray();
            //for (int i = 0; i <= charArray.GetUpperBound(0); i++)
            //    Console.Write(charArray[i] + " ");



            //string text = "Am Straßenrand sitzt eine Kröte.";
            //char[] charArr = { ' ', 'm', 'A', '.' };
            //text = text.Trim(charArr);  // parameters are removed from start and end of the string

            //string text2 = "Kaffeepause";
            //Console.WriteLine(text2.PadLeft(text2.Length + 3)); // pad: tianbu

            //string text3 = text2.PadLeft(text2.Length + 3, '*');
            //Console.WriteLine(text3);
            //string text4 = text3.PadRight(text3.Length + 3, '*');
            //Console.WriteLine(text4);
        }
    }
}
