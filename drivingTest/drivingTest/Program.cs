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
            string userInput, userCountry;
            int userAge;

            //Get user's age
            Console.WriteLine("Please enter your current age in whole years: ");
            userInput = Console.ReadLine();
            userAge = Int32.Parse(userInput);

            //TODO: Modify the program for Nigeria, where the legal driving age is 18
            //Get User's country
            Console.WriteLine("Are you in the UK or Nigeria: ");
            userCountry = Console.ReadLine();

            //Select which message to show
            //Is the user old enough, factor in country
            //TODO: Modifiy the program to calculate and tell the user how many years they have to wait to be eligible to drive

            if (userAge >= 17)
                Console.WriteLine("You are old enough to take the test.");
            else
                Console.WriteLine("You are not old enough");

            //Pause at end
            Console.ReadLine();
        }
    }
}
