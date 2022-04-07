using System;

namespace UserInput
{
    class MainClass
    {
        public static void Main(string[] args)
        {

           
            Console.WriteLine("Please type the name of the University that you attend: ");
            String school = Console.ReadLine();
            Console.WriteLine("Welcome to the " + school + " University Portal!");
            Console.WriteLine();

            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oh!, so you are " + age + " years old\n");


            Console.WriteLine("Please enter a symbol of your choice: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Your schools instagram handle is " + symbol + school);
            

        }
    }
}
