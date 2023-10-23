using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockOOP_Dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Feladat: Clock példány
            Clock myClock = new Clock(12, 30, 45, "UTC+2", true);

            //2. Feladat: List
            List<Alarm> alarms = new List<Alarm>();
            alarms.Add(new Alarm(6, 0));
            alarms.Add(new Alarm(8, 0));

            //3. Feladat: Timer példány
            Timer myTimer = new Timer(10);

            //4. Feladat: myClock kiíratása
            myClock.DisplayTime();

            //5. Feladat: Ellenőrzés
            //Ha a megfelelő idő van beállítva akkor kiírja, hogy "az ébresztő megszólalt!"
            foreach (var alarm in alarms) 
            {
                if (alarm.IsAlarmTime(myClock.Hour, myClock.Minute)) 
                {
                    Console.WriteLine("Az ébresztő megszólalt!");
                } else
                {
                    Console.WriteLine("Elaludtál, hahaha:D");
                }
            }
            
            //6. Feladat
            myTimer.StartTimer();

            //7. Feladat, ezt nem tudom hogy mutassam be, de futtattam többször a kódot és minden működött. :D 
            Console.WriteLine("Lefutott a feladat, kiírta a szükséges dolgokat.");





        }
    }
}
