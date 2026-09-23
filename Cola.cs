using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Queue<string> fila = new Queue<string>();

        fila.Enqueue("Cliente 1");
        fila.Enqueue("Cliente 2");
        fila.Enqueue("Cliente 3");

        Console.WriteLine("Atiendo a: " + fila.Dequeue());
        Console.WriteLine("Atiendo a: " + fila.Dequeue());
    }
}