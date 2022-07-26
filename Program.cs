using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("        Welcome to Logical Programs        ");

            while (true)
            {
                Console.WriteLine("Press 1. for Fibonacci Series.");
                Console.WriteLine("Press 2. for Perfect number.");
                Console.WriteLine("Press 3. for Prime number.");
                Console.WriteLine("Press 4. for Reverse number.");
                Console.WriteLine("Press 5. to Stimulate Stop watch.");
                Console.WriteLine("|--------------------------------------------------|");
                Console.WriteLine("| Press 1. for Fibonacci Series.                   |");
                Console.WriteLine("| Press 2. for Perfect Number.                     |");
                Console.WriteLine("| Press 3. for Prime Number.                       |");
                Console.WriteLine("| Press 4. for Reverse Number.                     |");
                Console.WriteLine("| Press 5. for Stimulate Stop Watch.               |");
                Console.WriteLine("| Press 6. To Exit.                                |");
                Console.WriteLine("|--------------------------------------------------|");
                Console.WriteLine(" Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Fibonacci Series
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.Fibonacciseries(10);
                        break;

                    case 2:
                        //perfect number (6, 28, 496, 8128 )
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.CheckPerfectNumber(8128);
                        break;

                    /* case 3:
                         //prime number (2,3,5,7,11... )
                         PrimeNumber prime = new PrimeNumber();
                         prime.CheckPrime(23);
                         break;

                     case 4:
                         ////Reverse a number
                         ReverseNumebr reverse = new ReverseNumebr();
                         reverse.DoReverse(123);
                         break;

                     case 5:
                         //Stopwatch
                         StopWatch watch = new StopWatch();
                         watch.StimulateStopWatch();
                         break; */

                    case 6:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("invalid selection made.");
                        break;

                }
            }
        }
    }
}