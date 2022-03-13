using System;

namespace Day6LogicalProblem
{
    internal class Program
    {
       public static void PrimeNumber()
        {
            Console.WriteLine("Enter a Number to Check prime or not: ");
            int num=int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Enetred Number "+num+" Is a prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Prime number Program");
            Program.PrimeNumber();
        }
    }
}

