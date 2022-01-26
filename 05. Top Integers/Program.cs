using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int cmp = int.MinValue;
            int resultCount = 0;
            int[] result = new int[numbers.Length];
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                    if (numbers[i]>cmp)
                {
                    cmp = numbers[i];
                    result[i] = numbers[i];
                    resultCount++;
                }
            }
            int[] test = new int[resultCount];
            int testCount = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i]!=0)
                {
                    test[testCount] = result[i];
                    testCount++;
                }
            }
            Console.WriteLine($"{string.Join(" ", test)}");
        }
    }
}
