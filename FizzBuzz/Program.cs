using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz!");
            Console.WriteLine("Please enter one number at a time. Enter '0' to exit the application.");
            FizzBuzz fizzBuzzGame = new FizzBuzz();
            int num = 1;
            do
            {
                if (fizzBuzzGame.Get(num).Equals("Fizz"))
                    Console.WriteLine("FIZZ");
                else if (fizzBuzzGame.Get(num).Equals("Buzz"))
                    Console.WriteLine("BUZZ");
                else if (fizzBuzzGame.Get(num).Equals("FizzBuzz"))
                    Console.WriteLine("FIZZBUZZ!");
                num = Convert.ToInt32(Console.ReadLine());

            }
            while (num != 0);
        }
    }
}
