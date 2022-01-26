using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines= int.Parse(Console.ReadLine());
            int[] array1 = new int[lines];
            int[] array2 = new int[lines];
            for (int i = 1; i <= lines; i++)
            {
                int[] tempArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2 != 0)
                {
                    array1[i-1] = tempArray[0];
                    array2[i-1] = tempArray[1];
                }
                else
                {
                    array1[i-1] = tempArray[1];
                    array2[i-1] = tempArray[0];
                }
            }
            Console.WriteLine("{0}", string.Join(" ", array1));
            Console.WriteLine("{0}", string.Join(" ", array2));
        }
    }
}
