using System;

public class Program
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }

    public static void Main()
    {
        int resultado1 = Sumar(2, 3);
        int resultado2 = Sumar(10, 25);

        Console.WriteLine("2 + 3 = " + resultado1);
        Console.WriteLine("10 + 25 = " + resultado2);
    }
}
