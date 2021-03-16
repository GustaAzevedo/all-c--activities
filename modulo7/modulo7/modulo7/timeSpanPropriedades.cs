using System;
using System.Collections.Generic;
using System.Text;

namespace modulo7
{
    class timeSpanPropriedades
    {
        static void x()
        {
            //  MaxValue, MinValue, Zero
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine();
            Console.WriteLine();

            //   propriedades
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            Console.WriteLine();
            Console.WriteLine();

            // operações
            TimeSpan time1 = new TimeSpan(1, 30, 10);
            TimeSpan time2 = new TimeSpan(1, 20, 5);
            TimeSpan sum = time1.Add(time2);
            TimeSpan dif = time1.Subtract(time2);
            TimeSpan mult = time2.Multiply(2.0);
            TimeSpan div = time2.Divide(2.0);
            Console.WriteLine(time1);
            Console.WriteLine(time2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
