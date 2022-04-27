using System;

namespace ConditionalOperator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool runner = true;

            while (runner != false)
            {
                try
                {
                    Console.WriteLine("Enter the day of the week (1 - 7): ");
                    int dayofweek = Convert.ToInt32(Console.ReadLine());

                    String day = ""; // place holder for day, will be changed in switch statement

                    string itIsToday = DayPicker(dayofweek, day); // print what's returned from method

                    // (condition) ? x : y
                    // if true do x else if false do y

                    string finishingStatement = (itIsToday == "MONDAY" || itIsToday == "TUESDAY" || itIsToday == "WEDNESDAY" || itIsToday == "THURSDAY" || itIsToday == "FRIDAY") ? $"It is {itIsToday} which is a weekday " : "It is a weekend";
                    Console.WriteLine(finishingStatement);

                }

                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong. Make sure you enter a whole number from 1 -7");
                }

                finally
                {
                    Console.WriteLine("Ending Program...");
                    runner = false;
                }
            }
        }




        static string DayPicker(int numberDay, String dayShown)
        {
            switch (numberDay)
            {
                case 1:
                    dayShown = "MONDAY";
                    break;
                case 2:
                    dayShown = "TUESDAY";
                    break;
                case 3:
                    dayShown = "WEDNESDAY";
                    break;
                case 4:
                    dayShown = "THURSDAY";
                    break;
                case 5:
                    dayShown = "FRIDAY";
                    break;
                case 6:
                    dayShown = "SATURDAY";
                    break;
                case 7:
                    dayShown = "SUNDAY";
                    break;
                default:
                    Console.WriteLine("Enter a number 1 - 7");
                    break;
            }

            return dayShown;
        }
    }
}
