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
            //Variables
            int ianAge = 43;
            int userAge, difference;
            string userName;
            

            //Ask user for age in years
            Console.WriteLine("How old are you in years: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            //Ask user for name
            Console.WriteLine("What's your name: ");
            userName = Console.ReadLine();

            //Display how much younger than Ian they are (Ian = 43yo)
            difference = ianAge - userAge;
            Console.WriteLine("{0}, you are {1} younger than Ian.", userName, difference);

            Console.ReadKey();
        }
    }
}
