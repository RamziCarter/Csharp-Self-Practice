using System;

namespace Raandom
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Program Generates two random numbers and compares to find maximum

            Random random = new Random();
            int num = random.Next(1, 7) +1000; // last number is not used so b/w 1001 and 1006
            Console.WriteLine(num);


            double num2 = random.NextDouble();
            Console.WriteLine(num2);

            double a = Math.Max(num,num2);
            Console.WriteLine(a);
        }
    }
}
