using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x;
            x = 1015;

            int y = 23;

            int z = x + y;

            

            Console.WriteLine("The variable x is equal to: " + x);
            Console.WriteLine("The variable y is equal to: " + y);
            Console.WriteLine("The variable z is equal to: " + z);
            Console.WriteLine();


            int age = 23;
            Console.Write("I am a " + age + " year old developer who is applying for a job at MSI Data\n I look forward to the interview!");
            Console.WriteLine();
            Console.WriteLine();



            double height = 78.6;
            Console.WriteLine("Your height is " + height + "in, which means you are 6 feet 6 inches tall!");
            Console.WriteLine();

            char symbol = '@';
            bool isalive = true;

            String name = "Ramzi";
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your userName is " + symbol + name);
        }
    }
}
