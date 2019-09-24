using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Modify the program so it asks for the comparison age as well
            
            //Variables
            int comparisonAge;
            int userAge, difference;
            string userName;
            

            //Ask user for age in years
            Console.WriteLine("How old are you in years: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an age to compare to: ");
            comparisonAge = Convert.ToInt32(Console.ReadLine());

            //Ask user for name
            Console.WriteLine("What's your name: ");
            userName = Console.ReadLine();

            //Display how much younger than Ian they are (Ian = 43yo)
            difference = comparisonAge - userAge;
            Console.WriteLine("{0}, there is {1} years before you are {2}.", userName, difference, comparisonAge);

            Console.ReadKey();
        }
    }
}
