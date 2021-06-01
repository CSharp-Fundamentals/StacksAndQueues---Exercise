using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = ParseArray();

            int n = tokens[0];
            int s = tokens[1];
            int x = tokens[2];

            int[] input = ParseArray();

            Queue<int> numbers = new Queue<int>(input);

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }

        private static int[] ParseArray()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}