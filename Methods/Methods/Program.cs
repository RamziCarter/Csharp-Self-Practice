using System;

namespace Methods
{
    class MainClass
    {

        static void SingHappyBirthDay(String name, int age)
        {
           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Happy BirthDay to you!");
                Console.WriteLine("Happy BirthDay to you!");
                Console.WriteLine("Happy BirthDay Dear " + name + "!");
                Console.WriteLine("How old are you?\n"  + age + "!");
                Console.WriteLine("Happy BirthDay to you!");
            }

        }

        public static void Main(string[] args)
        {

            // A method performs a section of code when called or "invoked"
            // This lets us reuse code without writing it multiple times

            String name = "Ramzi";
            int age = 35;
            SingHappyBirthDay(name, age);
         

        }
    }
}
