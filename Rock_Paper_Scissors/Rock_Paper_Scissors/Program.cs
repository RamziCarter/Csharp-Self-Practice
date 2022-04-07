using System;

namespace Rock_Paper_Scissors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a selection: Rock, Paper or Scissors: ");
            Console.ReadLine();

            int rock;
            int paper;

            Random random = new Random();
            String CpuChoice = random("Rock" , "Paper, "Scissors");
        }
    }
}
