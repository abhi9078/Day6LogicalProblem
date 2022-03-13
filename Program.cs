using System;

namespace Day6LogicalProblem
{
    internal class Program
    {
        public static void Fibonacci()
        {
            int num1 = 0, num2 = 1, temp, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            for (i = 2; i < number; ++i)
            {
                temp = num1 + num2;
                Console.Write(temp + " ");
                num1 = num2;
                num2 = temp;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Fibonacci Series");
            Program.Fibonacci();
        }
    }
}
