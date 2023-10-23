using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockOOP_Dolgozat
{
    internal class Clock
    {

        //adattagok:
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string TimeZone { get; set; }
        public bool Is24HourFormat {  get; set; }

        //Konstruktor: 

        public Clock(int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            TimeZone = timeZone;
            Is24HourFormat = is24HourFormat;

            if (!is24HourFormat)
            {
                if (24 > Hour && Hour > 12)
                {
                    Hour -= 12;
                }
                else
                {
                    Console.WriteLine("Hibás időformátum!");
                }
            }
        }

        //Metódusok 
        public void SetTime(int hour, int minute, int second)
        {
            if (Is24HourFormat)
            {
                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59 && second >= 0 && second <= 59)
                {
                    Hour = hour;
                    Minute = minute;
                    Second = second;
                }
                else
                {
                    Console.WriteLine("Hibás időérték!");
                }
            }
            else
            {
                if (hour >= 1 && hour <= 12 && minute >= 0 && minute <= 59 && second >= 0 && second <= 59)
                {
                    Hour = hour;
                    Minute = minute;
                    Second = second;
                }
                else
                {
                    Console.WriteLine("Hibás időérték!");
                }
            }
        }

        public void DisplayTime()
        {
            Console.WriteLine($"Az aktuális idő: {Hour}:{Minute}:{Second} {TimeZone}");
        }

        public void SetTimeZone(string timeZone)
        {
            TimeZone = timeZone;
        }

        public void ToggleTimeFormat()
        {
            Is24HourFormat = !Is24HourFormat;
        }
    }
}
