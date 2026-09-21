using System;
using System.Collections.Generic;

public class Program
{
    public static double CalcularPromedio(List<double> notas)
    {
        double suma = 0;

        foreach (double nota in notas)
        {
            suma = suma + nota;
        }

        return suma / notas.Count;
    }

    public static void Main()
    {
        List<double> notas = new List<double> { 8, 9.5, 7, 10 };
        double promedio = CalcularPromedio(notas);

        Console.WriteLine("Promedio: " + promedio);

        if (promedio >= 6)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}
