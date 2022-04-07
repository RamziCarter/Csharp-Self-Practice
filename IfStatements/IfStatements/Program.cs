using System;

namespace IfStatements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your age for credit card approval: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age < 0)
            {
                Console.WriteLine("You are not born yet!");

            }

            else if(age > 100)
            {
                Console.WriteLine("You are too old to apply for a credit card!");
            }

            else if(age == 18)
            {
                Console.WriteLine("You are approved, however I would recommend consulting a parent/Guardian about developing Credit Card Debt!");
            }

            else
            {
                Console.WriteLine("You have been approved to sign Up for a credit card");
            }


        }
    }
}
