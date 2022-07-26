using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public int CheckPerfectNumber(int number)
        {
            //varibles
            int perfect_number = 0, original_number = number;
            //check for postive number
            if (number <= 0)
            {
                Console.WriteLine("Invalid number");
                return 0;
            }
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    perfect_number += i;
            }
            if (perfect_number == original_number)
                Console.WriteLine($"{number} is a Perfect Number.");
            else
                Console.WriteLine($"{number} is not a perfect number.");
            return 0;
        }
    }
}
