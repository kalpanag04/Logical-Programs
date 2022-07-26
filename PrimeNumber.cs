using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public int CheckPrime(int number)
        {
            //variables
            int flag = 0;
            //check number is positive
            if (number <= 1)
            {
                Console.WriteLine($"{number} is not a prime number");
                return 0;
            }
            //check for prime
            for (int divisor = 2; divisor <= number / 2; divisor++)
            {
                if (number % divisor == 0)
                {
                    Console.WriteLine($"{number} is not a prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            return 0;
        }
    }
}
