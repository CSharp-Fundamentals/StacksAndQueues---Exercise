using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = ParseArray();
            int[] bottles = ParseArray();
            Queue<int> cupQueue = new Queue<int>(cups);
            Stack<int> bottlesStack = new Stack<int>(bottles);
            int wastedWater = 0;

            while (true)
            {
                if (cupQueue.Count == 0)
                {
                    bottlesStack.Reverse();
                    Console.WriteLine($"Bottles: {string.Join(' ', bottlesStack)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    break;
                }
                if (bottlesStack.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(' ', cupQueue)}");
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    return;
                }
                int currentCup = cupQueue.Peek();

                while (true)
                {
                    if (bottlesStack.Count == 0)
                    {
                        Console.WriteLine($"Cups: {string.Join(' ', cupQueue)}");
                        Console.WriteLine($"Wasted litters of water: {wastedWater}");
                        return;
                    }
                    int currentBottle = bottlesStack.Peek();

                    if (currentCup > currentBottle)
                    {
                        currentCup -= bottlesStack.Pop();
                    }
                    else
                    {
                        wastedWater += bottlesStack.Pop() - currentCup;
                        cupQueue.Dequeue();
                        break;
                    }
                }
            }
        }

        private static int[] ParseArray()
        => Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}
