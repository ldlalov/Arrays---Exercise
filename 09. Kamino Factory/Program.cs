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
            int bestNumSequence = 0;
            int currentSequence = 1;
            int[] bestsequence = new int[dna];
            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int sumOnes = 0;
                int oneCount = 0;
                int onesCount = 0;
                int position = int.MaxValue;
                int[] sequence = input.Split("!").Select(int.Parse).ToArray();
                foreach (int ones in sequence)
                {
                    if (ones == 1)
                    {
                        oneCount += ones;
                    }
                }
                int tempSumOnes = 0;
                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] == 1)
                    {
                        tempSumOnes++;
                    }
                    else
                    {
                        tempSumOnes = 0;
                    }
                    if (tempSumOnes > sumOnes)
                    {
                        sumOnes = tempSumOnes;
                            position = i;
                    }
                }
                if (sumOnes > moreOnes)
                {
                    moreOnes = sumOnes;
                    bestPosition = position;
                    bestsequence = sequence;
                    biggestOneCount = oneCount;
                    bestNumSequence = currentSequence;
                }
                else if (sumOnes == moreOnes && position < bestPosition)
                {
                    bestPosition = position;
                    bestsequence = sequence;
                    biggestOneCount = oneCount;
                    bestNumSequence = currentSequence;
                }
                else if (sumOnes == moreOnes && position == bestPosition && moreOnes < oneCount)
                {
                    bestsequence = sequence;
                    biggestOneCount = oneCount;
                    bestNumSequence = currentSequence;
                }


                input = Console.ReadLine();
                if (input != "Clone them!")
                {
                    sequence = input.Split("!").Select(int.Parse).ToArray();
                    currentSequence++;
                }
            }
            Console.WriteLine($"Best DNA sample {bestNumSequence} with sum: {biggestOneCount}.");
            Console.WriteLine($"{string.Join(" ", bestsequence)}");
        }
    }
}
