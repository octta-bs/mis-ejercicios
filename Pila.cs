using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<string> platos = new Stack<string>();

        platos.Push("Plato 1");
        platos.Push("Plato 2");
        platos.Push("Plato 3");

        Console.WriteLine("Quito: " + platos.Pop());
        Console.WriteLine("Quito: " + platos.Pop());
    }
}