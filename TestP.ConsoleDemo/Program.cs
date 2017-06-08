using System;

namespace TestP.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var command in args)
            {
                Console.WriteLine(command);
            }
        }
    }
}