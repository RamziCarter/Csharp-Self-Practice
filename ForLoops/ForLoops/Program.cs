using System;

namespace ForLoops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);

                if (i == 1)
                {
                    Console.WriteLine("HAPPY NEW YEAR!");
                }
            }
        }
    }
}
