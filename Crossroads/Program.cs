using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();
                int currentGreen = greenLightDuration;
                int currentFree = freeWindowDuration;

                if (input=="END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{counter} total cars passed the crossroads.");
                    break;
                }

                if (input=="green")
                {
                    while (currentGreen>0 && queue.Count !=0)
                    {
                        string firstInQueue = queue.Dequeue();
                        currentGreen -= firstInQueue.Length;
                        if (currentGreen>0)
                        {
                            counter++;
                        }
                        else
                        {
                            currentFree += currentGreen;
                            if (currentFree<0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{firstInQueue} was hit at {firstInQueue[firstInQueue.Length+currentFree]}.");
                                return;
                            }
                            counter++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
        }
    }
}
