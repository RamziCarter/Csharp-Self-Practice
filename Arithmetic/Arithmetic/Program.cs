using System;

namespace Arithmetic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // lets make some friends today with math!

            /*
             * 
             * This is a multi 
             * Line
             * Comment!
             * 
             */


            int friends = 5;
            friends++;
            friends--;
            friends--;
            bool isName = true;

            friends = friends + 1;
            Console.WriteLine(friends);
            friends = friends - 1;
            Console.WriteLine(friends);
            friends = friends * 3;
            Console.WriteLine(friends);
            friends = friends / 2;
            Console.WriteLine(friends);
            // trunkate variable because int type
            // not a double so it will not show the decimal

            double friendly = Convert.ToDouble(friends);
            Console.WriteLine(friendly + 2.5);
            isName.GetType();
            Console.WriteLine(friends.GetType());

            // today we started off with 5 friends

            // Operators + - / *
            // Operators numbers, quantities, values and 
        }
    }
}
