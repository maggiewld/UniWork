/*
*Author: Maggie
*SID: [REDACTED]
*Edited: 24Sep2019
*/
using System;

namespace retirementPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string InputAge;
            int age;
            int oldAge = 65;
            int difference;

            Console.WriteLine("Please enter your age in whole years");
            InputAge = Console.ReadLine();

            //Convert console input from string to integer
            age = Convert.ToInt32(InputAge);

            difference = oldAge - age;
            Console.WriteLine("In {0} years you will be 65 years old.", difference);
            Console.ReadLine();
        }
    }
}
