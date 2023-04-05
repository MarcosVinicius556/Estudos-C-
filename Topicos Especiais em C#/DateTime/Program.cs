using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //DateTime é do tipo Struct
        //ticks --> Unidade de medida de tempo no c# (100 nano segundos)
        //Possui varias sobrecargas
        DateTime d1 = DateTime.Now; //Devolve o momento atual do sistema
        DateTime d2 = new DateTime(2018, 11, 25);
        DateTime d3 = new DateTime(2018 ,11 ,25, 20, 45, 3);
        DateTime d4 = new DateTime(2018 ,11 ,25, 20, 45, 3, 500); //Pode Utilizando kind --> Fuso Horário
        DateTime d5 = DateTime.Today; //Data de hoje, sem horário
        DateTime d6 = DateTime.UtcNow; 
        DateTime d7 = DateTime.Parse("2000-08-15"); //Pode receber diferentes tipos de formatação por padrão
        DateTime d8 = DateTime.Parse("2000-08-15 13:05:08");
        DateTime d9 = DateTime.Parse("15/08/2000");
        DateTime d10 = DateTime.Parse("15/08/2000 13:05:08");
        DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); //Formata em um tipo específico
        DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:08", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        Console.WriteLine(d1);
        Console.WriteLine(d1.Ticks);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);
        Console.WriteLine(d5);
        Console.WriteLine(d6);
        Console.WriteLine(d7);
        Console.WriteLine(d8);
        Console.WriteLine(d9);
        Console.WriteLine(d10);
        Console.WriteLine(d11);
        Console.WriteLine(d12);

        
    }
}