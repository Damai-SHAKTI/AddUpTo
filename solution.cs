// Solution in C#
using System;

namespace ConsoleApp
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Input A Positive Number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Not A Positive Integer!");
                }
                else
                {
                    Console.WriteLine("Sum of {0}: {1}", n, AddUpTo(n));
                }
            } 
            catch (Exception)
            {
                Console.WriteLine("Invalid Input!");
            }

        }

        public static int AddUpTo(int n)
        {
            return n * (n + 1) / 2;
        }

    }

}
