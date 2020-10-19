using System;

namespace DeliverableTwoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess which will have more: heads or tails?");
            string headsOrTailsGuess = Console.ReadLine();
            decimal guessNumber = 0;
            if (headsOrTailsGuess == "heads" || headsOrTailsGuess == "Heads")
            {
                guessNumber = 1;
            }
            else if (headsOrTailsGuess == "tails" || headsOrTailsGuess == "Tails")
            {
                guessNumber = 2;
            }

            Console.WriteLine("How many times shall we flip a coin?");
            decimal numberOfFlips = Decimal.Parse(Console.ReadLine());

            decimal correctCount = 0;

            for (int i = 0; i <= numberOfFlips; i++)
            {
                Random rand = new Random();
                int r = rand.Next(1, 3);
                
                
                if (r == 1 && r == guessNumber)
                {
                    correctCount++;
                    Console.WriteLine("Heads");
                }
                else if (r == 1 && r != guessNumber)
                {
                    Console.WriteLine("Heads");
                }
                else if (r == 2 && r == guessNumber)
                {
                    correctCount++;
                    Console.WriteLine("Tails");
                }
                else if (r == 2 && r != guessNumber)
                {
                    Console.WriteLine("Tails");
                }
            }
            Console.WriteLine("Your guess, " + headsOrTailsGuess + " came up " + correctCount + " times.");
            Console.WriteLine("That's " + correctCount / numberOfFlips * 100 + "%");

        }
    }
}
