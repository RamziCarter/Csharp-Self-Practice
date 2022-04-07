using System;

namespace Switches
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Which month is it currently? ");
            String month = Console.ReadLine();

            switch(month)
            {
                case "January":
                    Console.WriteLine("The month is January");
                    break;
                case "February":
                    Console.WriteLine("The month is February");
                    break;
                case "March":
                    Console.WriteLine("The month is March");
                    break;
                case "April":
                    Console.WriteLine("The month is April");
                    break;
                case "May":
                    Console.WriteLine("The month is May");
                    break;
                case "June":
                    Console.WriteLine("The month is June");
                    break;
                case "July":
                    Console.WriteLine("The month is July");
                    break;
                case "August":
                    Console.WriteLine("The month is August");
                    break;
                case "September":
                    Console.WriteLine("The month is September");
                    break;
                case "October":
                    Console.WriteLine("The month is October");
                    break;
                case "November":
                    Console.WriteLine("The month is November");
                    break;
                case "December":
                    Console.WriteLine("The month is December");
                    break;
                default:
                    Console.WriteLine(month + " is not a month");
                    break;
            }
        }
    }
}
