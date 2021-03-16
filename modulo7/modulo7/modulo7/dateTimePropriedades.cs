using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace modulo7
{
    class dateTimePropriedades
    {
        static void x()
        {
            //  Formatação (DateTime -> string)
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine();
            Console.WriteLine();

            //Operações com Datetime
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine();
            Console.WriteLine();

            //
            DateTime x = new DateTime(2002, 03, 23, 23, 45,50);
            DateTime x2 = new DateTime(2001, 09, 19, 20, 15, 40);
            TimeSpan x3 = new TimeSpan(2, 5, 49);

            DateTime y1 = x.Add(x3);
            DateTime y2 = x.AddDays(2);
            DateTime y3 = x.AddHours(2);
            DateTime y4 = x.AddMilliseconds(2);
            DateTime y5 = x.AddMinutes(2);
            DateTime y6 = x.AddMonths(2);
            DateTime y7 = x.AddSeconds(5);
            DateTime y8 = x.AddTicks(100);
            DateTime y9 = x.AddYears(2);
            DateTime y10 = x.Subtract(x3);
            TimeSpan y11 = x.Subtract(x2);
            Console.WriteLine(y1);
            Console.WriteLine(y2);
            Console.WriteLine(y3);
            Console.WriteLine(y4);
            Console.WriteLine(y5);
            Console.WriteLine(y6);
            Console.WriteLine(y7);
            Console.WriteLine(y8);
            Console.WriteLine(y9);
            Console.WriteLine(y10);
            Console.WriteLine(y11);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
