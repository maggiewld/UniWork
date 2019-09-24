using System;

namespace welcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string message;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            message = "Welcome " + name + " to " + "my program.";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
