using System;

namespace GuessingGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int max = 100;
            int min = 0;
            int guess;
            int number;
            int guesses;
            bool playAgain = true;


            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                // Generate a random number from 0 to 100 

                // Console.WriteLine(random);

                while (guess != number)
                {
                    Console.Write("Guess a number between " + min + " and " + max + " : " );
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);



                    if (guess > number)
                    {
                        Console.WriteLine("Guess is too high!");
                    }

                    else if (guess < number)
                    {
                        Console.WriteLine("Guess is too low!");
                    }

                    guesses++;

                }

                Console.WriteLine("You got the number correct! It was: " + number);
                Console.WriteLine("It took you: " + guesses + " guesses to get it right");
                Console.Write("Would you Like to Play again? (Y/N): ");
                String answer = Console.ReadLine();
                answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing the number guessing game!");
                }


            }
        }
    }
}
