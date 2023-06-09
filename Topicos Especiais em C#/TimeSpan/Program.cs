﻿using System;
internal partial class Program
{
    private static void Main(string[] args)
    {
        //TimeSpan representa uma duração na forma de Ticks
        //Tipo Struct

        TimeSpan t1 = new TimeSpan(0, 1, 30);
        TimeSpan t2 = new TimeSpan();
        TimeSpan t3 = new TimeSpan(90000000L);
        TimeSpan t4 = new TimeSpan(2, 11, 21); //Com hora
        TimeSpan t5 = new TimeSpan(1, 2, 11, 21); //Com dia e hora
        TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321); //Com dia, hora e milis.
        TimeSpan t7 = TimeSpan.FromDays(1.5); //Método from pega a partir de um periodo determinável
        TimeSpan t8 = TimeSpan.FromHours(1.5);
        TimeSpan t9 = TimeSpan.FromMinutes(1.5);
        TimeSpan t10 = TimeSpan.FromSeconds(1.5);
        TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
        TimeSpan t12 = TimeSpan.FromTicks(900000000L);


        Console.WriteLine(t1);
        Console.WriteLine(t1.Ticks);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        Console.WriteLine(t4);
        Console.WriteLine(t5);
        Console.WriteLine(t6);
        Console.WriteLine(t7);
        Console.WriteLine(t8);
        Console.WriteLine(t9);
        Console.WriteLine(t10);
        Console.WriteLine(t11);
        Console.WriteLine(t12);
    }
}