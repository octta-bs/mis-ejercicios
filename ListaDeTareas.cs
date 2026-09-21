using System;
using System.Collections.Generic;

public class Tarea
{
    public string Descripcion { get; set; }
    public bool Completada { get; set; }

    public void Mostrar()
    {
        if (Completada)
        {
            Console.WriteLine("[x] " + Descripcion);
        }
        else
        {
            Console.WriteLine("[ ] " + Descripcion);
        }
    }
}

public class Program
{
    public static void Main()
    {
        List<Tarea> tareas = new List<Tarea>();

        tareas.Add(new Tarea { Descripcion = "Estudiar C#", Completada = true });
        tareas.Add(new Tarea { Descripcion = "Subir ejercicio a GitHub", Completada = true });
        tareas.Add(new Tarea { Descripcion = "Descansar", Completada = false });

        foreach (Tarea tarea in tareas)
        {
            tarea.Mostrar();
        }
    }
}
