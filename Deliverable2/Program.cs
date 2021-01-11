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

            Console.Write("Guess which  will have more: heads or tails? ");
            headsOrTailsGuess = Console.ReadLine();
            Console.Write("How many times shall we flip a coin? ");
            numberOfFlips = Convert.ToInt32(Console.ReadLine());

            //test
            Console.WriteLine(headsOrTailsGuess + ", " + numberOfFlips);
            


/*            while (true)
            {
                Console.WriteLine(ConvertBoolToCoinWords(FlipCoin()));
                Console.ReadKey(true);
            }*/

            // Methods
            bool FlipCoin()
            {
                return rnd.Next(2) == 0;
            }

            string ConvertBoolToCoinWords(bool coinState)
            {
                string result = System.String.Empty;

                if (coinState)
                {
                    result = "heads";
                }
                else
                {
                    result = "tails";
                }

                return result;
            }

        }
    }
}
