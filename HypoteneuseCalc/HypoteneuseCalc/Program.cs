using System;

namespace HypoteneuseCalc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());


            /*double powerA = Convert.ToDouble(Math.Pow(a, 2));
            double powerB = Convert.ToDouble(Math.Pow(b, 2));

            // square both variables a and b

            double squareRT = a + b;
            squareRT = Math.Sqrt(squareRT);
            */

            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("The hypotenuse of the triangle is: " + c);
        }

            
    }
}
