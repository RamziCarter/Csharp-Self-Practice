using System;

namespace ExceptionHandling
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            // try --> to execute code that could possibly have errors
            // catch --> if error is found print exception
            // finally --> always executes if error is caught or not!
            try
            {
                Console.WriteLine("Enter a number: ");
                int x = Convert.ToInt32(Console.ReadLine());

                int power2 = x * x;
                Console.Write($"{x} multipilied by {x} is: ");
                Console.WriteLine(power2);

            }


            catch(FormatException e)
            {
                Console.WriteLine("You did not enter a whole number!");
            }

            finally
            {
                Console.WriteLine("Ending program...");
            }

        }
    }
}
