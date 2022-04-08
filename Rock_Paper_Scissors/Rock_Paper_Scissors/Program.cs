using System;

namespace Rock_Paper_Scissors
{
    static class GloblaVar
        {

        public static int userValue;

        }


    class MainClass
    {

        public static void Main(string[] args)
        {

            bool playing = true; // run loop until false, which means game is over

            while(playing)
            {
                Console.WriteLine("Enter a selection: Rock, Paper or Scissors: ");
                String userChoice = Console.ReadLine();
                userChoice = userChoice.ToUpper();

                GloblaVar.userValue = 0;

                int counter = 100; // 100 possible guesses for the user to enter the wrong selection from rock paper or scissors


                for (int i = 0; i <= counter; i++)
                {

                    if (userChoice == "ROCK")
                    {
                        GloblaVar.userValue = 1;
                        i = counter;
                    }
                    else if (userChoice == "PAPER")
                    {
                        GloblaVar.userValue = 2;
                        i = counter;
                    }
                    else if (userChoice == "SCISSORS")
                    {
                        GloblaVar.userValue = 3;
                        i = counter;
                    }
                    else
                    {
                        Console.Write("Please enter a correct choice! Rock, Paper or Scissors ");
                        userChoice = Console.ReadLine();
                        userChoice = userChoice.ToUpper();
                    }
                }

                // CPU CHOICE
                int rock = 1;
                int paper = 2;
                int scissors = 3;

                // random object to pick CPU choice
                Random random = new Random();
                int CpuChoice = random.Next(1, 4); // 4 is exclusive, will not be used in random range
                String cpuValue;


                switch(CpuChoice)
                {
                    case 1:
                        cpuValue = "ROCK";
                        Console.WriteLine("The computer chose " + cpuValue);
                        break;
                    case 2:
                        cpuValue = "PAPER";
                        Console.WriteLine("The computer chose " + cpuValue);
                        break;
                    case 3:
                        cpuValue = "SCISSORS";
                        Console.WriteLine("The computer chose " + cpuValue);
                        break;
                }

                
                
                // conditional statements to determine the result of the game
                while (GloblaVar.userValue == 1 || GloblaVar.userValue == 2 || GloblaVar.userValue == 3 )
                {

                    // draw
                    if(GloblaVar.userValue == 1 && CpuChoice == 1 || GloblaVar.userValue == 2 && CpuChoice == 2 || GloblaVar.userValue == 3 && CpuChoice == 3)
                    {
                        Console.WriteLine("Draw!  No one wins.");
                        Console.WriteLine();
                        GloblaVar.userValue = 9;
                    }
                    // wins for user
                    else if (GloblaVar.userValue == 1 && CpuChoice == 3)
                    {
                        Console.WriteLine("You wim!  Rock beats Scissors.");
                        Console.WriteLine();
                        GloblaVar.userValue = 9;
                    }
                    else if (GloblaVar.userValue == 2 && CpuChoice == 1)
                    {
                        Console.WriteLine("You wim!  Paper beats Rock.");
                        Console.WriteLine();
                        GloblaVar.userValue = 9;
                    }
                    else if (GloblaVar.userValue == 3 && CpuChoice == 2)
                    {
                        Console.WriteLine("You wim!  Scissors beats Paper.");
                        Console.WriteLine();
                        GloblaVar.userValue = 9;
                    }

                    // wins for computer
                    else if (GloblaVar.userValue == 3 && CpuChoice == 1)
                    {
                        Console.WriteLine("You lose!  Rock beats Scissors.");
                        Console.WriteLine();
                        GloblaVar.userValue = 9;
                    }
                    else if (GloblaVar.userValue == 1 && CpuChoice == 2)
                    {
                        Console.WriteLine("You lose!  Papers beats Rock.");
                        Console.WriteLine();
                        GloblaVar.userValue = 9;
                    }
                    else if (GloblaVar.userValue == 2 && CpuChoice == 3)
                    {
                        Console.WriteLine("You lose!  Scissors beats Paper.");
                        Console.WriteLine();
                        GloblaVar.userValue = 9;
                    }

                }
            }
        }
    }
}
