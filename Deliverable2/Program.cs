using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string headsOrTailsGuess = System.String.Empty;
            int numberOfFlips = 0;
            int correctCount = 0;
            Random rnd = new Random();

            // Main Sequence
            GetUserInput();
            ProcessCoinFlips();
            PrintPlayerScore();

            #region Methods
            void ProcessCoinFlips()
            {
                bool flipResult;

                for (int i = 0; i < numberOfFlips; i++)
                {
                    flipResult = FlipCoin();

                    Console.WriteLine(ConvertBoolToCoinWords(flipResult));

                    if (ConvertCoinWordsToBool(headsOrTailsGuess) == flipResult)
                    {
                        correctCount++;
                    }
                }
            }

            void PrintPlayerScore()
            {
                string timesGrammar = "times";

                if (numberOfFlips == 1)
                {
                    timesGrammar = "time";
                }

                Console.WriteLine($"Your guess, {headsOrTailsGuess}, came up {correctCount} {timesGrammar}.");
                Console.WriteLine($"That's {ProcessScore()}%.");
            }

            double ProcessScore()
            {
                Console.WriteLine(correctCount);
                Console.WriteLine(numberOfFlips);
                return Math.Round((correctCount / (double)numberOfFlips) * 100);
            }

            void GetUserInput()
            {
                Console.Write("Guess which  will have more: heads or tails? ");
                headsOrTailsGuess = Console.ReadLine();
                Console.Write("How many times shall we flip a coin? ");
                numberOfFlips = Convert.ToInt32(Console.ReadLine());
            }

            bool FlipCoin()
            {
                return rnd.Next(2) == 0;
            }

            bool ConvertCoinWordsToBool(string coinGuess)
            {
                bool result = false;

                if (coinGuess == "heads")
                {
                    result = true;
                }
                else if (coinGuess == "tails")
                {
                    result = false;
                }

                return result;
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
            #endregion

        }
    }
}
