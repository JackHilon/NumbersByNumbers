using System;
using System.Collections.Generic;

namespace NumbersByNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the sum of numbers which are multiplication of n and less than or equal than m.");
            Console.WriteLine("Your entries must be positive and less than 1000.");

            Console.Write("Enter number n: ");
            int n = EnterNumber();

            Console.Write("Enter number m: ");
            int m = EnterNumber();

            Console.Write("The sum is: " + SumList(FindMultiplication(n,m)));
            

        }
        private static int SumList(List<int> nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum = sum + nums[i];
            }
            return sum;
        }
        private static List<int>  FindMultiplication(int number, int limit)
        {
            var results = new List<int>();
            try
            {
                if (number > limit)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                results.Add(0);
                return results;
            }
            
            for (int i = number; i <=limit; i++)
            {
                if (i % number == 0)
                    results.Add(i);
            }
            return results;
        }
        private static int EnterNumber()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a <= 0 || a > 1000)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.Write("Enter number ]0 , 1000]: ");
                return EnterNumber();
            }
            return a;
        }
    }
}
