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
            decimal age, difference;
            decimal oldAge = 65;
           
            Console.WriteLine("Please enter your age");
            InputAge = Console.ReadLine();

            //Convert console input from string to integer
            age = Convert.ToDecimal(InputAge);

            difference = oldAge - age;
            Console.WriteLine("In {0} years you will be 65 years old.", difference);
            Console.ReadLine();

            //Modify code to accept fractional values - DONE using decimals.
        }
    }
}
