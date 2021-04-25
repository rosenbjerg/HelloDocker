using System;

namespace HelloDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}