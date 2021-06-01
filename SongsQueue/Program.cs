using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songs = new Queue<string>(input);

            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string name = "";

                for (int i = 1; i < tokens.Length - 1; i++)
                {
                    name += tokens[i] + " ";
                }
                name += tokens[tokens.Length - 1];

                switch (command)
                {
                    case "Play":
                        songs.Dequeue();
                        if (!songs.Any())
                        {
                            Console.WriteLine("No more songs!");
                            return;
                        }
                        break;
                    case "Add":
                        if (songs.Contains(name))
                        {
                            Console.WriteLine($"{name} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(name);
                        }
                        break;
                    case "Show":
                        StringBuilder result = new StringBuilder();
                        foreach (var song in songs)
                        {
                            result.Append(song + ", ");
                        }
                        result.Remove(result.Length - 2, 2);
                        Console.WriteLine(result);
                        break;
                }
            }
        }
    }
}
