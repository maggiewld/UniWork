using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drivingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program will ask the user their age and tell them if they are able to take the UK driving test

            //Variables for user input
            string userInput;
            int userAge;

            //Get user's age
            Console.WriteLine("Please enter your current age in whole years: ");
            userInput = Console.ReadLine();
            userAge = Int32.Parse(userInput);

            //Select which message to show
            //Is the user old enough
            if (userAge > 17)
                Console.WriteLine("You are old enough to take the test.");

            //Pause at end
            Console.ReadLine();
        }
    }
}
