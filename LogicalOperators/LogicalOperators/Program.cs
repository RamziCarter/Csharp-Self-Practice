using System;

namespace LogicalOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("What is the temperature outside? (F): ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if(temp <= -32 || temp >= 105)
            {
                Console.WriteLine("Do not go outside!");
            }

            if(temp >= -31 && temp <= 104)
            {
                Console.WriteLine("You should be okay to go outside.");
            }

            Console.WriteLine("The temperature is " + temp + " degrees (F) outside");
        }
    }
}
