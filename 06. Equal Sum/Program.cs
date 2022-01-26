using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (numbers.Length==1)
            {
                Console.WriteLine(0);
                return;
            }
            bool found = false;
            for (int i = 0; i < numbers.Length ; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                int currCell = i;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += numbers[j];
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sumRight += numbers[j];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
