using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockOOP_Dolgozat
{
    internal class Alarm
    {

        //Adattagok:
        public int AlarmHour { get; set; }
        public int AlarmMinute { get; set; }
        public bool IsAlarmOn = true;
        
        //Konstruktor: 
        public Alarm(int hour, int minute)
        {
            AlarmHour = hour;
            AlarmMinute = minute;
        }

        //Metódusok: 
        void SetAlarm(int hour, int minute)
        {

            if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            {
                AlarmHour = hour;
                AlarmMinute = minute;
            }
            else
            {
                Console.WriteLine("Helytelen érték, próbáld újra!");
            }
        }

        //TurnsOnAlarm
        public void TurnsOnAlarm()
        {
            IsAlarmOn = true;
        }

        //TurnsOffAlarm 
        public void TurnsOffAlarm()
        {
            IsAlarmOn = false;
        }

        //IsAlarmTime
        public bool IsAlarmTime(int hour, int minute)
        {
            if (IsAlarmOn && hour == AlarmHour && minute == AlarmMinute)
            {
                return true;
            }
            return false;
        }
    }
}
