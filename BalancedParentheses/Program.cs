using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            string input = Console.ReadLine();
            bool isValid = true;

            foreach (var symbol in input)
            {
                switch (symbol)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (!stack.Any() || stack.Pop() !=symbol)
                        {
                            isValid = false;
                        }
                        break;
                    default:
                        break;
                }
                if (!isValid)
                {
                    break;
                }
            }
            isValid &= !stack.Any();

            Console.WriteLine(isValid ? "YES" : "NO");
        }
    }
}