using System;

namespace RPS
{
    public class Rps
    {
        public int Cscore { get; set; }
        public int Uscore { get; set; }
        public int Count = 0;

        public Rps()
        {
            Cscore = 0;
            Uscore = 0;
        }
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random(); 
            return random.Next(min, max);
        }

        public void play(int a)
        {
            const int MIN = 1;
            const int MAX = 4;

            int returnValue = RandomNumber(MIN, MAX);
            if (a > 3 || a < 1)
            {
                Console.WriteLine("unvalid number! the number must be between 1 - 3!");
            }

            if (returnValue == 1)
            {
                Console.WriteLine("the Computer choses Rock.");
                switch (a)
                {
                    case 1:
                        Console.WriteLine("You also chose Rock, you tied!");
                        break;
                    case 2:
                        Console.WriteLine("You chose Paper, you win!");
                        Uscore++;
                        break;
                    case 3:
                        Console.WriteLine("You chose Scissors, you lose!");
                        Cscore++;
                        break;
                }
            }
            else if (returnValue == 2)
            {
                Console.WriteLine("the Computer choses Paper.");
                switch (a)
                {
                    case 1:
                        Console.WriteLine("You chose Rock, you lose!");
                        Cscore++;
                        break;
                    case 2:
                        Console.WriteLine("You also chose Paper, you tied!");
                        break;
                    case 3:
                        Console.WriteLine("You chose Scissors, you win!");
                        Uscore++;
                        break;
                }
            }
            else //(returnValue == 3)
            {
                Console.WriteLine("the Computer choses Scissors.");
                switch (a)
                {
                    case 1:
                        Console.WriteLine("You chose Rock, you win!");
                        Uscore++;
                        break;
                    case 2:
                        Console.WriteLine("You chose Paper, you lose!");
                        Cscore++;
                        break;
                    case 3:
                        Console.WriteLine("You chose Scissors, you tied!");
                        break;
                }
            }
            Count++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rps game = new Rps();

            Console.WriteLine("game begins: 1-Rock, 2-Paper, 3-Scissors");
            while ( game.Uscore < 10 && game.Cscore < 10)
            {
                Console.Write("\nplease input a number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                game.play(x);
                Console.WriteLine("You have played {0} times. Your score vs Computers score: {1} - {2}", game.Count, game.Uscore, game.Cscore );
                Console.WriteLine("----------------------------------------------------------------------------");
            }
        }
    }
}
