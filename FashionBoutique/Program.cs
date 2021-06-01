using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> rack = new Stack<int>(sequence);
            int sum = 0;
            int racksCounter = 1;

            while (rack.Count > 0)
            {
                int current = rack.Pop();
                sum += current;

                if (sum > capacity)
                {
                    sum = 0;
                    sum += current;
                    racksCounter++;
                }
            }
            Console.WriteLine(racksCounter);
        }
    }
}
