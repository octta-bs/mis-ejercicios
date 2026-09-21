using System;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + Nombre + " y tengo " + Edad + " años");
    }
}

public class Program
{
    public static void Main()
    {
        Persona ana = new Persona();
        ana.Nombre = "Ana";
        ana.Edad = 25;

        Persona luis = new Persona();
        luis.Nombre = "Luis";
        luis.Edad = 30;

        ana.Saludar();
        luis.Saludar();
    }
}
