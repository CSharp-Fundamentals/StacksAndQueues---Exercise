using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> orders = new Queue<int>(numbers);
            Console.WriteLine(orders.Max());

            while (orders.Any())
            {
                if (quantity >= orders.Peek())
                {
                    quantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (orders.Any())
            {
                Console.Write($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
