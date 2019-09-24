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
        }
    }
}
