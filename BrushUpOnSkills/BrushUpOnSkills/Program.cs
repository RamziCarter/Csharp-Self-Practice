using System;

namespace BrushUpOnSkills
{

    static class Globals
    {
        public static int revolutions; // global variable for revolutions
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            // This is a program to see how much I remember!

            Console.WriteLine("Hello user! My name is Jason I will guide you through the program today!");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter your name to Start: ");
            String name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", thank you for playing today!");
            Console.WriteLine();
            Console.WriteLine();
            int min = 1;
            int max = 4;

            Random random = new Random(); // random object created

            int randNum = random.Next(min, max); // 1 to 3 numbers randomly 4 is exclusive
            Console.WriteLine("The number of times this games is supposed to iterate is: " + randNum);     // number of time the game should iterate

            bool recycle = true; // always keep while loop running

             int revolutions = 0;

            while (recycle)
            { 
    
                
                int userGuess = 0;
                
                int randNum2 = random.Next(0, 1001); // guess number 0 to 1000



                while (userGuess != randNum2)
                {
                  
                    Console.Write("Please guess a number 0 to 1000? ");
                    userGuess = Convert.ToInt32(Console.ReadLine()); //user Guess
                    Console.WriteLine();

                   
                   if (userGuess < randNum2)
                    {
                        Console.Write("Your guess was too low. Please Pick a higher number! ");
                        Console.WriteLine();
                    }


                    else if (userGuess > randNum2)
                    {

                        Console.Write("Your guess was too high. Please Pick a lower number! ");
                        Console.WriteLine();
                    }

                   else
                    {

                        revolutions++;
                        Console.WriteLine(revolutions);
                        Console.WriteLine("Your guess right! ");
                        Console.WriteLine();

                        if (revolutions == randNum)
                        {
                            recycle = false;
                        }
                    }


                }


            }
            
        

        }
    }
}
