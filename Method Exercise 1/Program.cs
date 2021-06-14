using System;

namespace Method_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"My name is {userName} and my favorite color is {color}.");
            Console.WriteLine($"Growing up my favorite animal was the {favoriteAnimal} and my favorite band is {favoriteBand}.");
        }
    }
}
