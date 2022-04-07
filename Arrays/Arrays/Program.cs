using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String[] numbers = { "1", "2", "3", "4", "5" };

            numbers[0] = "3";


            for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

        }
    }
}
