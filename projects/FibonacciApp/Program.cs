using System;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Sequence Calculator");
            Console.WriteLine("Enter 'exit' to quit.");

            while (true)
            {
                Console.Write("Enter the position in the Fibonacci sequence: ");
                Console.WriteLine("Enter 'exit' to quit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (int.TryParse(input, out int position))
                {
                    if (position < 0)
                    {
                        Console.WriteLine("Please enter a non-negative integer.");
                    }
                    else
                    {
                        Console.WriteLine($"Fib({position}) = {CalculateFibonacci(position)}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or type 'exit' to quit.");
                }
            }
        }

        static int CalculateFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int first = 0;
            int second = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }
    }
}
