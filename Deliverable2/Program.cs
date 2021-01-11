using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string headsOrTailsGuess = System.String.Empty;
            int numberOfFlips;
            int correctCount;
            Random rnd = new Random();

            while (true)
            {
                Console.WriteLine(FlipCoin());
                Console.ReadKey();
            }

            bool FlipCoin()
            {
                return rnd.Next(2) == 0;
            }

        }
    }
}
