using System;

namespace ConsoleApp
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(AddUpTo(3));
        }

        public static int AddUpTo(int n)
        {
            return n * (n + 1) / 2;
        }

    }

}
