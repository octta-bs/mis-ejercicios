using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> amigos = new List<string> { "Ana", "Luis", "Marta" };

        foreach (string amigo in amigos)
        {
            Console.WriteLine("Hola, " + amigo);
        }

        Console.WriteLine("Total de amigos: " + amigos.Count);
    }
}
