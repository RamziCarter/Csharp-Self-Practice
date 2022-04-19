using System;

namespace ReturnKeyword
{
    class MainClass
    {
        static void namePicker(String name1r, String name2r, String name3r, int number)
        {


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The random name chosen is: ");

           switch(number)
            { 
                case 1:
                    Console.WriteLine(name1r);
                    break;
                case 2:
                    Console.WriteLine(name2r);
                    break;
                case 3:
                    Console.WriteLine(name3r);
                    break;
                default:
                    break;
            }

        }


        static String EndProgram(String EndNote)
        {
            return EndNote + " Termination Complete!";
        }

        public static void Main(string[] args)
        {



            Console.WriteLine("Enter the first name of your choice?");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter a second name of your choice?");
            String secondName = Console.ReadLine();

            Console.WriteLine("Enter a third name of your choice?");
            String thridName = Console.ReadLine();


            int min = 1;
            int max = 4;

            Random randNum = new Random();
            int choice = randNum.Next(min, max);

            namePicker(firstName, secondName, thridName, choice);
            Console.WriteLine();

            String e = "Ending Program....";
            String finishStatement = EndProgram(e);
            Console.WriteLine(finishStatement);


        }
    }
}
