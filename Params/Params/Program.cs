using System;

namespace Params
{
    class MainClass
    {

        static double checkoutTotal(params double [] prices)
        {
            double result = 0;

            foreach(double price in prices)
            {
                result = price + result;
            }

            return result;
        }

        static String GetNames(params String [] names)
        {
            String person = "";
            foreach (String people in names)
            {
                person = person + people + " ";
            }

            return person;
        }

        public static void Main(string[] args)
        {
            double result = checkoutTotal(2.59, 7.69, 8.99, 4, 99.98, 0.345, -25.1, 2);
            Console.WriteLine(result);

            String persons = GetNames("John", "Bill", "Derek", "Drake", "Yousif", "Alex");
            Console.WriteLine(persons);
        }
    }
}
