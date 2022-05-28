using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    public class DayofWeek
    {
        int day, year, month;
        public void DOW(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            int year0 = year - (14 - month) / 12;
            int leapyear = year0 + year0 / 4 - year0 / 100 + year0 / 400;
            int month0 = month + 12 * ((14 - month) / 12) - 2;
            int day0 = (day + (leapyear * month0) / 12) % 7;
            switch (day0)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("TuesDay");
                    break;
                case 3:
                    Console.WriteLine("WednesDay");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 0:
                    Console.WriteLine("Sunaday");
                    break;
            }
        }
    }
}
