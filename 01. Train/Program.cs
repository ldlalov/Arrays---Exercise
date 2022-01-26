using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());
            int[] train = new int[vagons];
            int sum = 0;
            for (int vagon = 0; vagon<vagons;vagon++)    
            {
                int passengers = int.Parse(Console.ReadLine());
                train[vagon] =  passengers;
                sum += passengers;
            }
            Console.WriteLine("{0}", string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
