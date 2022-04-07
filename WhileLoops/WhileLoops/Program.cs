using System;

namespace WhileLoops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String last = "";
           

            while(last == "")
            {
                Console.WriteLine("Enter your last name, no input recieved" );
                last = Console.ReadLine();
            }

            Console.WriteLine("Hello Mr. " + last);
        }
    }
}
