using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = ParseArray();
            int[] locksInput = ParseArray();
            int intelligenceValue = int.Parse(Console.ReadLine());
            Queue<int> locks = new Queue<int>(locksInput);
            Stack<int> bullets = new Stack<int>(bulletsInput);
            int tempBarrelSize = gunBarrelSize;

            int counter = 0;

            while (true)
            {
                int currentLock = locks.Peek();
                int currentBullet = bullets.Pop();
                counter++;
                tempBarrelSize--;
                if (currentBullet<=currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (tempBarrelSize==0 && bullets.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    tempBarrelSize = gunBarrelSize;
                }
                if (locks.Count == 0)
                {
                    int moneyEarned = intelligenceValue - (bulletPrice * counter);
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
                    return;
                }
                if (bullets.Count==0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    return;
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
