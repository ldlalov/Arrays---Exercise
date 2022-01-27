using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dna = int.Parse(Console.ReadLine());
            int bestPosition = int.MaxValue;
            int moreOnes = 0;
            int biggestOneCount = 0;
            int currentSequence = 0;
            int [] bestsequence = new int[dna];
            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int oneCount = 0;
                int onesCount = 0;
                int position = 0;
                int[] sequence = input.Split("!").Select(int.Parse).ToArray();
                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == 1)
                    {
                        oneCount++;
                    }
                }
                    for (int i = 0; i < sequence.Length-1; i++)
                {
                    if (sequence[i] == 1 && sequence[i+1] == 1)
                    {
                        onesCount++;
                        position = i;
                    }
                }
                if (onesCount > moreOnes)
                {
                    moreOnes = onesCount;
                    bestPosition = position;
                    bestsequence = sequence;
                    biggestOneCount = oneCount;
                    currentSequence++;
                }
                else if (onesCount == moreOnes && position < bestPosition)
                {
                    moreOnes = onesCount;
                    bestPosition = position;
                    bestsequence = sequence;
                    biggestOneCount = oneCount;
                    currentSequence++;
                }
                else if (onesCount == moreOnes && position == bestPosition && biggestOneCount < oneCount)
                    {
                    moreOnes = onesCount;
                    bestPosition = position;
                    bestsequence = sequence;
                    biggestOneCount = oneCount;
                    currentSequence++;
                }


                input = Console.ReadLine();
                if (input != "Clone them!")
                {
                    sequence = input.Split("!").Select(int.Parse).ToArray();
                }
            }
            Console.WriteLine($"Best DNA sample {currentSequence} with sum: {biggestOneCount}.");
            Console.WriteLine($"{string.Join(" ", bestsequence)}");
        }
    }
}
