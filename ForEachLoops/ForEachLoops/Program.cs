using System;

namespace ForEachLoops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 different numbers to array input!");
            int[] arr = new int[10];



            Console.WriteLine("Hello User! Please enter the values for the array so that you can print them!");

            Console.Write("arr[0] = ");
            arr[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr[1] = ");
            arr[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr[2] = ");
            arr[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr[3] = ");
            arr[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr[4] = ");
            arr[4] = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr[5] = ");
            arr[5] = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr[6] = ");
            arr[6] = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr[7] = ");
            arr[7] = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr[8] = ");
            arr[8] = Convert.ToInt32(Console.ReadLine());
            Console.Write("arr[9] = ");
            arr[9] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t The array values are:  ");
            int counter = 0;

            foreach (int nums in arr)
            {
              
                Console.Write($"\t arr[{counter}]: ");
                Console.WriteLine(nums);
                counter++;
            }

        }
    }
}
