using System;
using System.Collections.Generic;
using System.Text;

namespace Interwal
{
    class Timer
    {
        public Timer()
        {
            int _dokladnoscsek = 1;

        }
        public int TotalSeconds { get; set; }
        public double TotalHours
        {
            get
            {
                return TotalMinutes / 60;
            }
            set
            {
                TotalMinutes = value * 60;

            } }
        public double TotalMinutes
        {
            get
            {
                return TotalSeconds / (double)60;
            }
            set
            {
                TotalSeconds = (int)(value * 60);
            }
        }

        public int Seconds
        {
            get { return (int)TotalSeconds % 60; }
            set
            {
                TotalSeconds = TotalSeconds - Seconds + value;
            
            }
        }

        public int Minutes
        {
            get { return (int) TotalMinutes%60; }
            set
            {
                TotalMinutes = TotalMinutes - Minutes + value;
            
            }
        }

        public int Hours
        {
            get { return (int)TotalHours; }
            set { TotalHours = TotalHours- Hours + value;            }
        }

        public void Print()

        {
            Console.WriteLine("Ilosc sekund  = {0}", TotalSeconds);
            Console.WriteLine("Ilosc minut = {0}", TotalMinutes);
            Console.WriteLine("Ilosc godzin = {0}", TotalHours);
       


        }
            
    }
}
