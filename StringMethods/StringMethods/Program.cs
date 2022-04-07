using System;

namespace StringMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String name = Console.ReadLine();

            name = name.ToUpper();
            Console.WriteLine(name);

            Console.WriteLine(name.Insert(0, "Mr. "));
            name = name.Replace("R", "6");
            Console.WriteLine(name);

            name = name.Substring(0,3);
            Console.WriteLine(name);


        }
    }
}
