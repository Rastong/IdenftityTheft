using System;

namespace Day_1_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Identity stealer. I have a few questions for you =)");
            Console.WriteLine("Can you please give me your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Can you please enter your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Can you please enter your howntown?");
            string hometown = Console.ReadLine();

            //Console.WriteLine("Your name is " + name + ", at the age of " + age + ", who is from the town of " + hometown + ".");
            Console.WriteLine($"Your name is {name}. Your age is {age}. Your hometown is {hometown}.");
        }
    }
}
