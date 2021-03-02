using System;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = PromptNumber();

            FizzBuzz(number);
        }

        private static int PromptNumber()
        {
            int number = 0;
            Console.WriteLine("Please type the number");
            string line = Console.ReadLine();
            while (!int.TryParse(line, out number))
            {
                Console.WriteLine("Error:" + line + " is not an integer\n" + "Try put integer instead!");
                line = Console.ReadLine();

            }
            return number;
        }
        private static void FizzBuzz(int number)
        {
            if (number % 3 == 0)
            {
                Console.Write("fizz");
                if (number % 5 == 0)
                {
                    Console.Write("buzz");
                }
            }
            else if (number % 5 == 0)
            {
                Console.Write("buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
