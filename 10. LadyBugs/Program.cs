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
            if (ladyBugs.Length<=fieldSize.Length)
            {
                foreach (var ladyBug in ladyBugs)
                {
                    if (ladyBug>=0 && ladyBug<fieldSize.Length)
                    {
                        fieldSize[ladyBug] = 1;
                    }
                }
            }
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] position = input.Split();
                if (int.Parse(position[0]) >= 0 && int.Parse(position[0]) < fieldSize.Length)
                {
                    if (fieldSize[int.Parse(position[0])] == 1)
                    {
                        fieldSize[int.Parse(position[0])] = 0;
                        if (position[1] == "right")
                        {
                            int newPosition = int.Parse(position[0]) + int.Parse(position[2]);
                            while (newPosition < fieldSize.Length)
                            {
                                if (fieldSize[newPosition] == 1)
                                {
                                    newPosition++;
                                }
                                else
                                {
                                    fieldSize[newPosition] = 1;
                                }
                            }
                        }
                        else if (position[1] == "left")
                        {
                            int newPosition = int.Parse(position[0]) - int.Parse(position[2]);
                            while (newPosition >= 0)
                            {
                                if (fieldSize[newPosition] == 1)
                                {
                                    newPosition++;
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
                input = Console.ReadLine();
            }
            Console.WriteLine($"{string.Join(" ", fieldSize)}");
        }
    }
}
