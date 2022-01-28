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
                string newSequence = "";
                int sumOnes = 0;
                int couple = 0;
                int couples = 0;
                int[] sequence = input.Split("!").Select(int.Parse).ToArray();
                foreach (int ones in sequence)
                {
                    sumOnes += ones;
                }
                for (int i = 0; i < sequence.Length; i++)
                {
                    newSequence += sequence[i].ToString();
                }
                for (int i = 0; i < input.Length; i++)
                {
                        couple = newSequence.IndexOf("11");
                    bestPosition = couple;
                    if (couple>0)
                    {
                        i = couple + 1;
                    }
                }

                //int oneCount = 0;
                //int onesCount = 0;
                //int position = int.MaxValue;
                //for (int i = 0; i < sequence.Length; i++)
                //{
                //    if (sequence[i] == 1)
                //    {
                //        oneCount++;
                //    }
                //}
                //    for (int i = 0; i < sequence.Length-1; i++)
                //{
                //    if (sequence[i] == 1 && sequence[i+1] == 1)
                //    {
                //        onesCount++;
                //        if (position==int.MaxValue)
                //        {
                //        position = i;
                //        }
                //        i++;
                //    }
                //}
                //if (onesCount > moreOnes)
                //{
                //    moreOnes = onesCount;
                //    bestPosition = position;
                //    bestsequence = sequence;
                //    biggestOneCount = oneCount;
                //    bestNumSequence = currentSequence;
                //}
                //else if (onesCount == moreOnes && position < bestPosition)
                //{
                //    moreOnes = onesCount;
                //    bestPosition = position;
                //    bestsequence = sequence;
                //    biggestOneCount = oneCount;
                //    bestNumSequence = currentSequence;
                //}
                //else if (onesCount == moreOnes && position == bestPosition && biggestOneCount < oneCount)
                //    {
                //    moreOnes = onesCount;
                //    bestPosition = position;
                //    bestsequence = sequence;
                //    biggestOneCount = oneCount;
                //    bestNumSequence = currentSequence;
                //}


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
