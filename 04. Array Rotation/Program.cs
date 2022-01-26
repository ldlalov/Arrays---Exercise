using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] tempArray = new int[array1.Length];
            int moves = int.Parse(Console.ReadLine());
            for (int i = 0; i < moves; i++)
            {
                int first = array1[0];
                for (int j = 0; j < tempArray.Length-1; j++)
                {
                    tempArray[j] = array1[j+1];
                }
                tempArray[array1.Length - 1] = first;
                array1 = tempArray;
            }
            Console.WriteLine("{0}", string.Join(" ", array1));
        }
    }
}
