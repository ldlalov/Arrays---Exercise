using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dna = int.Parse(Console.ReadLine());
            int bestPosition = 0;
            int moreOnes = 0;
            int biggestOneCount = 0;
            int bestNumSequence = 1;
            int currentSequence = 1;
            int[] bestsequence = new int[dna];
            string input;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int sumOnes = 0;
                int oneCount = 0;
                int position = 0;
                int[] sequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                foreach (int ones in sequence)
                {
                        oneCount += ones;
                }
                int tempSumOnes = 0;
                for (int i = 0; i < sequence.Length; i++)
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
                position -= sumOnes-1;
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
                currentSequence++;

            }
            Console.WriteLine($"Best DNA sample {bestNumSequence} with sum: {biggestOneCount}.");
            Console.WriteLine($"{string.Join(" ", bestsequence)}");
        }
    }
}