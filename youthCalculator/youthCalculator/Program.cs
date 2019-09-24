using System;

namespace youthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TODO Modify the program so it asks for the comparison age as well
             *TODO Modify the program so it calculates and displays the age difference in months(to the nearest year).
             */
            
            //Variables
            int comparisonAge;
            int userAge, difference, differenceMonths, nearestYear;
            string userName;
            

            //Ask user for age in years
            Console.WriteLine("How old are you in years: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an age to compare to: ");
            comparisonAge = Convert.ToInt32(Console.ReadLine());

            //Ask user for name
            Console.WriteLine("What's your name: ");
            userName = Console.ReadLine();

            //Display the age difference
            difference = comparisonAge - userAge;
            Console.WriteLine("{0}, there is {1} years before you are {2}.", userName, difference, comparisonAge);

            differenceMonths = difference * 12;
            Console.WriteLine("difference in months: " + differenceMonths);
            
            //Console.WriteLine("The difference in months is {0}, rounded to the nearest year is {1}", differenceMonths, nearestYear)

            Console.ReadKey();
        }
    }
}
