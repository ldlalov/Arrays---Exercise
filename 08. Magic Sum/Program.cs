using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int cmp = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i+1 ; j < numbers.Length; j++)
                {
                    if (cmp == numbers[i] + numbers[j])
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }
            }
        }
    }
}
