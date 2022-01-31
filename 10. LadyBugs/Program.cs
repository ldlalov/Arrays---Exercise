using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fieldSize = new int[int.Parse(Console.ReadLine())];
            int[] ladyBugs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                foreach (int ladyBug in ladyBugs)
                {
                    if (ladyBug>=0 && ladyBug<fieldSize.Length)
                    {
                        fieldSize[ladyBug] = 1;
                    }
                }
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] position = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int oldPosition = int.Parse(position[0]);
                int flyLength = int.Parse(position[2]);
                
                if (oldPosition >= 0 && oldPosition < fieldSize.Length)
                {
                    if (fieldSize[oldPosition] == 1)
                    {
                        fieldSize[oldPosition] = 0;
                        if (position[1] == "right")
                        {
                            int newPosition = oldPosition + flyLength;
                            while (newPosition >= 0 && newPosition < fieldSize.Length)
                            {
                                if (fieldSize[newPosition] == 1)
                                {
                                    newPosition+= flyLength;
                                }
                                else
                                {
                                    fieldSize[newPosition] = 1;
                                    break;
                                }
                            }
                        }
                        else if (position[1] == "left")
                        {
                            int newPosition = oldPosition - flyLength;
                            while (newPosition >= 0 && newPosition < fieldSize.Length)
                            {
                                if (fieldSize[newPosition] == 1)
                                {
                                    newPosition-= flyLength;
                                }
                                else
                                {
                                    fieldSize[newPosition] = 1;
                                    break;
                                }
                            }

                        }
                    }
                }
            }
            Console.WriteLine($"{string.Join(" ", fieldSize)}");
        }
    }
}
