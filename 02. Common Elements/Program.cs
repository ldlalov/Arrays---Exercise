using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] area1 = Console.ReadLine().Split().ToArray();
            string[] area2 = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < area2.Length; i++)
            {
                for (int j = 0; j < area1.Length; j++)
                {
                    if (area1[j] == area2[i])
                    {
                        Console.Write($"{area2[i]} ");
                    }
                }
            }
        }
    }
}
