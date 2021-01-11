using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init
            string headsOrTailsGuess;
            string numberOfFlipsInput;
            int numberOfFlips = 0;
            int correctCount = 0;
            Random rnd = new Random();

            // Main Sequence
            GetUserInput();
            ProcessCoinFlips();
            PrintPlayerScore();

            #region Methods
            void GetUserInput()
            {
                Console.Write("Guess which will have more: heads or tails? ");
                headsOrTailsGuess = Console.ReadLine();
                Console.Write("How many times shall we flip a coin? ");
                numberOfFlipsInput = Console.ReadLine();
                if (Int32.TryParse(numberOfFlipsInput, out int result))
                {
                    numberOfFlips = result;
                }
                else
                {
                    Console.WriteLine("Please enter a number next time.");
                }
                Console.WriteLine("\n");
            }

            bool FlipCoin()
            {
                return rnd.Next(2) == 0;
            }

            void ProcessCoinFlips()
            {
                bool flipResult;

                for (int i = 0; i < numberOfFlips; i++)
                {
                    flipResult = FlipCoin();

                    Console.WriteLine((i+1) + ". " + ConvertBoolToCoinWords(flipResult));

                    if (ConvertCoinWordsToBool(headsOrTailsGuess) == flipResult)
                    {
                        correctCount++;
                    }
                }

                Console.WriteLine("\n");
            }

            void PrintPlayerScore()
            {
                string timesGrammar = "times";

                if (correctCount == 1)
                {
                    timesGrammar = "time";
                }

                if (headsOrTailsGuess.Equals("heads") | headsOrTailsGuess.Equals("tails"))
                {
                    Console.WriteLine($"Your guess, {headsOrTailsGuess}, came up {correctCount} {timesGrammar}.");
                    Console.WriteLine($"That's {ProcessScore()}%.");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine($"Sorry, you entered \"{headsOrTailsGuess}\", which is not a valid guess! Please only enter: heads or tails.");
                }


            }

            double ProcessScore()
            {
                if (correctCount != 0 || numberOfFlips != 0) // Avoiding dividing by zero
                {
                    return Math.Round((correctCount / (double)numberOfFlips) * 100, 2);
                }
                else
                {
                    return 0;
                }
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
