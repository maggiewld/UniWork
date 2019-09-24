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

            message = "Welcome " + name + ", to " + "my program.";
            Console.WriteLine(message);
            Console.ReadLine();

            //Q. How would you modify this program to also ask the user which course they were on?
            string course;

            Console.WriteLine("What course are you studying: ");
            course = Console.ReadLine();

            //Q. Having done so, how would you modify the program to print a welcome to that course?
            message = course + "! That must be interesting!";
            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
