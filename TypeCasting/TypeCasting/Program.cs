using System;

namespace TypeCasting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double MU = 1881.4;

            int y = Convert.ToInt32(MU);

            Console.WriteLine(y);

            Console.WriteLine("The original variable of y is: " + MU + " " + MU.GetType());


            char firstLetter = 'D';
            String copy = Convert.ToString(firstLetter);

            Console.WriteLine(copy.GetType());



            String cars = "2";
            int Bullitt = Convert.ToInt32(cars);
            Bullitt++;
            Console.Write(Bullitt);
            Console.WriteLine("\t The type of Bullitt is " + Bullitt.GetType() + "\n");
        }
    }
}
