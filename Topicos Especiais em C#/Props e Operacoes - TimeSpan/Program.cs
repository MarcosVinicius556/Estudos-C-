using System;
internal partial class Program
{
    private static void Main(string[] args)
    {
        TimeSpan t1 = TimeSpan.MaxValue;
        TimeSpan t2 = TimeSpan.MinValue;
        TimeSpan t3 = TimeSpan.Zero;

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);

        TimeSpan t4 = new TimeSpan(2, 3, 4, 7, 11);

        //Devolve inteiros
        Console.WriteLine("Days: " + t1.Days);
        Console.WriteLine("Hours: " + t1.Hours);
        Console.WriteLine("Minutes: " + t1.Minutes);
        Console.WriteLine("MilliSeconds: " + t1.Milliseconds);
        Console.WriteLine("Seconds: " + t1.Seconds);
        Console.WriteLine("Tick: " + t1.Ticks);

        //Devolve fracionados, o total
        Console.WriteLine("TotalDays: " + t1.TotalDays);
        Console.WriteLine("TotalHours: " + t1.TotalHours);
        Console.WriteLine("TotalMinutes: " + t1.TotalMinutes);
        Console.WriteLine("TotalSeconds: " + t1.TotalSeconds);
        Console.WriteLine("TotalMilliseconds: " + t1.TotalMilliseconds);

        //Operações com TimeSpan
        TimeSpan t5 = new TimeSpan(1, 30, 10);
        TimeSpan t6 = new TimeSpan(0, 10, 5);

        TimeSpan sum = t5.Add(t6);
        TimeSpan dif = t5.Subtract(t6);
        TimeSpan mult = t6.Multiply(2.0);
        TimeSpan div = t6.Divide(2.0);

        Console.WriteLine(sum);
        Console.WriteLine(dif);
        Console.WriteLine(mult);
        Console.WriteLine(div);
    }
}