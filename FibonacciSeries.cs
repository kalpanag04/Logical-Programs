using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public int Fibonacciseries(int range)
        {
            //variables
            int fibonacci, previous_number = 1, current_number = previous_number + 1;
            //check if number is greater than one
            if (range <= 1)
            {
                Console.WriteLine("enter the range greater than 1.");
                return 0;
            }
            //display initial numbers 1 and 2.
            Console.Write("Fibonacci Series :" + previous_number + " " + current_number);
            for (int counter = 1; counter <= range; counter++)
            {
                fibonacci = previous_number + current_number;
                previous_number = current_number;
                current_number = fibonacci;
                Console.Write(" " + fibonacci);
            }
            return 0;

        }
    }
}