using System;
internal partial class Program
{
    private static void Main(string[] args)
    {
        DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);

        Console.WriteLine(d1);
        Console.WriteLine("1) Date: " + d1.Date);
        Console.WriteLine("2) Day: " + d1.Day);
        Console.WriteLine("3) DayOfWeek: " + d1.DayOfWeek);
        Console.WriteLine("4) DayOfYear: " + d1.DayOfYear);
        Console.WriteLine("5) Hour: " + d1.Hour);
        Console.WriteLine("6) Kind: " + d1.Kind);
        Console.WriteLine("7) MilliSecond: " + d1.Millisecond);
        Console.WriteLine("8) Minute: " + d1.Minute);
        Console.WriteLine("9) Month: " + d1.Month);
        Console.WriteLine("10) Second: " + d1.Second);
        Console.WriteLine("11) Ticks: " + d1.DayOfWeek);
        Console.WriteLine("12) TimeOfDay: " + d1.TimeOfDay);
        Console.WriteLine("13) Year: " + d1.Year);

        DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);
        string s1 = d1.ToString("yyyy-MM-dd HH:mm:ss");
        string s2 = d1.ToString("yyyy-MM-dd HH:mm:ss.fff"); //Milisegundos

        Console.WriteLine(d2.ToLongDateString()); //Imprime a data completa
        Console.WriteLine(d2.ToLongTimeString());
        Console.WriteLine(d2.ToShortDateString()); //Imprime a data reduzida
        Console.WriteLine(d2.ToShortTimeString());
        Console.WriteLine(s1);
        Console.WriteLine(s2);

        //Útil com calculo de vencimentos, multas, etc.
        DateTime d3 = d1.AddHours(2);
        DateTime d4 = d1.AddMinutes(3);
        
        Console.WriteLine(d3);
        Console.WriteLine(d4);

        //Comparacao
        DateTime d5 = new DateTime(2001, 8, 15, 13, 45, 58);
        DateTime d6 = new DateTime(2001, 8, 25, 13, 45, 58);

        TimeSpan t1 = d5.Subtract(d6);
        Console.WriteLine(t1);

    }
}