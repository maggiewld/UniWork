using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countingUp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable to store total number
            int total = 1;

            Console.WriteLine("Total currently: {0}", total);
            total = total + 2;
            Console.WriteLine("Total now: {0}", total);
            total = total + 1;
            Console.WriteLine("Total changed to: {0}", total);

            //Shorthand form of addition
            total += 3;

            Console.WriteLine("Total finally: {0}", total);

            //Readline to make program pause
            Console.ReadLine();

            //Q. How would you alter this code to add up the numbers 2.2, 4.7 and 6.3 ?

            double decimalTotal = 0.0;
                        
            Console.WriteLine("Total currently: {0}", decimalTotal);
            decimalTotal += 2.2;
            Console.WriteLine("Total + 2.2 = {0}", decimalTotal);
            decimalTotal += 4.7;
            Console.WriteLine("Total + 4.7 = {0}", decimalTotal);
            decimalTotal += 6.3;
            Console.WriteLine("Total + 6.3 = {0}", decimalTotal);

            Console.ReadLine();
        }
    }
}
