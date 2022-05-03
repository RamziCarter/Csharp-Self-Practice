using System;

namespace StringInterpolation
{
    class MainClass
    {

        static int AgeReducer(int number)
        {
            number = number - 10;
            return number;
        }

        static string JobFinder(params string [] jobs)
        {
            Random rand = new Random();
            int counter = 0;
            string randJob = "";
            foreach(string randjob in jobs)
            {
                counter++;
            }

            int usedCount = rand.Next(1, counter + 1); // last number is exclusive in random
            switch(usedCount)
            {
                case 1:
                    randJob = jobs[0];
                    break;
                case 2:
                    randJob = jobs[1];
                    break;
                case 3:
                    randJob = jobs[2];
                    break;
                case 4:
                    randJob = jobs[3];
                    break;
                case 5:
                    randJob = jobs[4];
                    break;
                case 6:
                    randJob = jobs[5];
                    break;
                default:
                    randJob = "Jobless piece of crap";
                    break;

            }
            return randJob ;
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a boolean value: True/False");
                bool runner = Convert.ToBoolean(Console.ReadLine());
                while (runner == true)
                {

                    string occupations = JobFinder("ForkLift Driver", "Swimmer", "Software Developer", "Doctor", "Desk Receptionist", "Bus Driver");
                    string name = "Sharon";
                    int age = 52;
                    int ageAfter = AgeReducer(age);
                    //Console.WriteLine($"Hello {name} you are {age} years old!");

                    //Console.WriteLine($"{ageAfter} is the age {name} is after being reduced!");

                    Console.WriteLine($"{name} is {age,5} years old and retired. \nHowever, when {name} was {ageAfter} she used to work as a {occupations} !");
                    runner = false;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Enter a value to run program: True or False!");
            }

            finally
            {
                Console.WriteLine("Ending Program...");
            }
            
        }
    }
}
