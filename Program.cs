using System;

namespace Day6LogicalProblem
{
    internal class Program
    {
       public static void ReverseNumber()
        {
            Console.WriteLine("Please Enter a Number To check Reverese Number: ");
            int num = int.Parse(Console.ReadLine());
            int temp, rem, rev = 0;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = ((rev * 10) + rem);
                num = num / 10;
            }

            Console.WriteLine("Reverse of the number "+temp+" is: "+rev);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Reverse number Program");
            Program.ReverseNumber();
        }
    }
}

