using System;
using System.Diagnostics;
using System.Threading;

namespace Day6LogicalProblem
{
    internal class Program
    {
        public static void CouponNumber()
        {
            Console.WriteLine("Please Enter how many Random distinct number you want: ");
            int num = int.Parse(Console.ReadLine());
            int[] ran = new int[num];
            Console.WriteLine("Enter the Starting range of Random Number you want");
            int str=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending range of Random numnber you want ");
            int end= int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Random random = new Random();
                int n = random.Next(str, end);
                ran[i] = n;
            }
            Console.WriteLine("All Random Distinct Numbers are: ");
            foreach (int j in ran)
            {
                Console.WriteLine(j);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Coupon Number Program");
            Program.CouponNumber();
        }
    }
}

