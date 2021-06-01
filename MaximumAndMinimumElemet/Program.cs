using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElemet
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> info = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                switch (input[0])
                {
                    case 1:
                        info.Push(input[1]);
                        break;
                    case 2:
                        info.Pop();
                        break;
                    case 3:
                        if (info.Any())
                        {
                            Console.WriteLine(info.Max());
                        }
                        break;
                    case 4:
                        if (info.Any())
                        {
                            Console.WriteLine(info.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",info)); ;
        }
    }
}
