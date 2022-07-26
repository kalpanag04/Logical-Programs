using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public int DoReverse(int number)
        {
            //variables
            int reverse = 0, lastDigit;
            //check number is a 2 digit number and positive
            if (number <= 9)
            {
                Console.WriteLine(number +"should be greater than 10. ");
                return 0;
            }
            Console.WriteLine("Number entered: "+number);
            //reverse a number
            while (number != 0)
            {
                lastDigit = number % 10;
                reverse = (reverse * 10) + lastDigit;
                number /= 10;
            }
            Console.WriteLine("Reverse Number: "+reverse);
            return 0;
        }
    }
}
