using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Variables
            string name, telNumber, employer;
            int dob, age;
       
            //Ask user for name, telephone number and employer
            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("What is your number: ");
            telNumber = Console.ReadLine();
            Console.WriteLine("Who do you work for: ");
            employer = Console.ReadLine();

            //Q. How would you modify this code to also show the user's date of birth and age?
            Console.WriteLine("What's your date of birth (DDmmYY): ");
            dob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How old are you: ");
            age = Convert.ToInt32(Console.ReadLine());

            //Print to console in the order: employer, name, telephone number
            Console.WriteLine("Your employer is: " + employer + "\nYour name is: " + name + "\nYour telephone number is: " + telNumber + "\nYour birthday is: " + dob + "\nYour age is: " + age);
            Console.ReadLine();
        }
    }
}
