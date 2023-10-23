using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockOOP_Dolgozat
{
    internal class Timer
    {
        public int RemainingSeconds;

        public Timer(int remainingSeconds)
        {
            RemainingSeconds = remainingSeconds;
        }

        public void SetTime(int seconds)
        {
            RemainingSeconds = seconds;
        }

        public void StartTimer()
        {
            while (RemainingSeconds > 0)
            {
                Console.WriteLine(RemainingSeconds);
                RemainingSeconds -= 1;
            }
            Console.WriteLine("Az időzító lejárt!"); 
        }
    }
}
