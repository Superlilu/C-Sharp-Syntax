using System;

namespace RPS
{
    public class Rps
    {
        public int Cscore { get; set; }
        public int Uscore { get; set; }
        public int Count { get; set; }

        public Rps()
        {
            Cscore = 0;
            Uscore = 0;
            Count = 0;
        }
        public enum Role  // enum belongs to class, thus is "static"
        {
            Rock = 1,
            Paper,
            Scissors
        }
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random(); 
            return random.Next(min, max);
        }

        public void play(Role a)
        {
            const int MIN = 1;
            const int MAX = 4;

            int returnValue = RandomNumber(MIN, MAX);

            //try
            //{
                if (returnValue == 1)
                {
                    Console.WriteLine("\nComputer choses Rock.");
                    switch (a)
                    {
                        case Role.Rock:
                            Console.WriteLine("You also chose Rock, you tied!");
                            break;
                        case Role.Paper:
                            Console.WriteLine("You chose Paper, you win!");
                            Uscore++;
                            break;
                        case Role.Scissors:
                            Console.WriteLine("You chose Scissors, you lose!");
                            Cscore++;
                            break;
                        //default:
                        //    throw new Exception("unvalid number!the number must be between 1 - 3!");
                             

                    }
                }
                else if (returnValue == 2)
                {
                    Console.WriteLine("\nComputer choses Paper.");
                    switch ((Role)a)
                    {
                        case Role.Rock:
                            Console.WriteLine("You chose Rock, you lose!");
                            Cscore++;
                            break;
                        case Role.Paper:
                            Console.WriteLine("You also chose Paper, you tied!");
                            break;
                        case Role.Scissors:
                            Console.WriteLine("You chose Scissors, you win!");
                            Uscore++;
                            break;
                        //default:
                        //    throw new Exception("unvalid number!the number must be between 1 - 3!");
                    }
                }
                else //(returnValue == 3)
                {
                    Console.WriteLine("\nComputer choses Scissors.");
                    switch (a)
                    {
                        case Role.Rock:
                            Console.WriteLine("You chose Rock, you win!");
                            Uscore++;
                            break;
                        case Role.Paper:
                            Console.WriteLine("You chose Paper, you lose!");
                            Cscore++;
                            break;
                        case Role.Scissors:
                            Console.WriteLine("You chose Scissors, you tied!");
                            break;
                        //default:
                        //    throw new Exception("invalid number!the number must be between 1 - 3!");
                            // turn into catich after "trow Exception": Count ++ will not be executed!
                    }
                }
                Count++;
            //}
            //catch (InvalidNumberException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }

    //public class InvalidNumberException : Exception
    //{
    //    public InvalidNumberException() : base("invalid number!the number must be between 1 - 3!")
    //    {
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Rps game = new Rps();

            Console.WriteLine("game begins: 1-Rock, 2-Paper, 3-Scissors");
            while ( game.Uscore < 10 && game.Cscore < 10)
            {
                Console.WriteLine("\n----------------------------------------------------\n\nRound: {0}", game.Count + 1);
                Console.Write("please input a number: ");
                try
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (!((x == 1) || (x == 2) || (x == 3)))
                    {
                        throw new Exception("invalid number!the number must be between 1 - 3!");
                    }
                    game.play((Rps.Role)x);   // enum belongs to class, thus is "static" → Rps.Role
                    Console.WriteLine("\nScore(You vs Computer): {0} - {1}", game.Uscore, game.Cscore);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine("\n----------------------------------------------------\nGame Over!");
            if (game.Cscore > game.Uscore)
            {
                Console.WriteLine("Computer achieved 10 points. Computer wins!\n");
            }
            else
            {
                Console.WriteLine("You achieved 10 points. You win!\n");
            }
        }
    }
}
