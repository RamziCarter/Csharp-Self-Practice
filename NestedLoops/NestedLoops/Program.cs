using System;

namespace NestedLoops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("How many Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nHow many Columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nWhat symbol will the picture be made out of? ");
            char symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }


        }
    }
}
