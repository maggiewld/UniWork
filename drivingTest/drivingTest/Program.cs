﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drivingTest
{
    class Program
    {
        const int LEGAL_AGE = 17;

        static void Main(string[] args)
        {
            //This program will ask the user their age and tell them if they are able to take the UK driving test

            //Variables for user input
            string userInput, userCountry;
            int userAge, waitTime;

            //TODO: Modify the program for Nigeria, where the legal driving age is 18
            //Get User's country
            Console.WriteLine("Are you in the UK or Nigeria: ");
            userCountry = Console.ReadLine();

            //Select which message to show
            //Is the user old enough, factor in country
            //TODO: Modifiy the program to calculate and tell the user how many years they have to wait to be eligible to drive

            if (userCountry == "UK")
            {
                Console.WriteLine("You can take the test at 17. How old are you in whole years: ");
                userInput = Console.ReadLine();
                userAge = Int32.Parse(userInput);

                if (userAge >= LEGAL_AGE)
                {
                    Console.WriteLine("You're eligable for the test.");
                }
                else
                {
                    waitTime = LEGAL_AGE - userAge;
                    Console.WriteLine("You are too young for the test, please wait {0} years", waitTime);
                }
            }

            if (userCountry == "Nigeria")
            {
                Console.WriteLine("You can take the test at 18. How old are you in whole years: ");
                userInput = Console.ReadLine();
                userAge = Int32.Parse(userInput);

                if (userAge >= 18)
                {
                    Console.WriteLine("You're eligable for the test.");
                }
                else
                {
                    waitTime = 18 - userAge;
                    Console.WriteLine("You are too young for the test, please wait {0} years", waitTime);
                }
            }

            //Pause at end
            Console.ReadLine();
        }
    }
}
