using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kap11_Linq
{
    class Aggregations
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Ab", "Bc", "Cd", "De" };

            var result = names.Aggregate((a, name)=>a + " " + name);

            Console.WriteLine(result);

            //int[] numbers = new int[] { 10, 12, 4, 15, 8 };
            ////var result = numbers.Max();

            ////var result = numbers.Where(number => number > 10).Min();
            ////var result = numbers.Average();
            ////var result1 = numbers.Sum();
            ////var result2 = numbers.Count();
            ////var result3 = numbers.Where(number => number > 10).Count();

            //var result4 = numbers.Aggregate((sum, val)=> sum + val);



            ////Console.WriteLine(result.ToString(), result1, result2, result4);
            //Console.WriteLine(result4);
        }
    }
}
