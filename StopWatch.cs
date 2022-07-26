using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        DateTime start_time;
        public void Start()
        {
            //recording current time
            start_time = DateTime.Now;
            //start message
            Console.WriteLine("stopwatch has started");
            Console.WriteLine("Press 2 to stop the watch:");
            Selection();
        }
        public void Stop(DateTime start_time)
        {
            //variables
            long minutes, seconds, milli;
            double elapsed_secs;
            double elapsed_time;
            //record current time
            DateTime end_time = DateTime.Now;
            //calculating elapsed time
            elapsed_time = ((TimeSpan)(end_time - start_time)).TotalMilliseconds;
            //Converting elapsed time into human readable format
            minutes = Convert.ToInt64((elapsed_time / 1000) / 60);
            elapsed_secs = ((elapsed_time / 1000) % 60);
            seconds = Convert.ToInt64(elapsed_secs);
            milli = Convert.ToInt64((elapsed_secs - seconds) * 10);
            //stop message
            Console.WriteLine("Stop watch has been stopped");
            //output
            Console.WriteLine($"{minutes} minutes {seconds} seconds and {milli} ms");
        }

        public void Selection()
        {
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    //start stop watch
                    Start();
                    break;
                case 2:
                    // stopping stopwatch
                    Stop(start_time);
                    break;
                default:
                    //invalid selection
                    Console.WriteLine("Invalid selection made.");
                    break;
            }
        }

        public void StimulateStopWatch()
        {
            //stop watch 
            Console.WriteLine("~~~~~~~~~~STOPWATCH~~~~~~~~~~~~~~");
            Console.WriteLine("Press 1. to Start Stopwatch");
            //user input to start and stop.
            Selection();
        }
    }
}
