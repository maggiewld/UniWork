using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFromUser = 0;
            string userInput = "";

            Console.WriteLine("Please enter a number between 1 and 10. Then press Enter.");
            userInput = Console.ReadLine();

            //Convert userInput from string to int
            numberFromUser = Int32.Parse(userInput);

            //Test string has been converted by performing addition
            numberFromUser++;
            Console.WriteLine("Result plus one is: {0}", numberFromUser);

            Console.ReadLine();

            //Q. How could you modify the program so that it will work when the user enters '5.5'?
        }
    }
}
