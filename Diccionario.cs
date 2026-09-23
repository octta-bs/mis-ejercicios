using System.Collections.Generic;

Dictionary<string, string> contactos = new Dictionary<string, string>();

contactos["Ana"] = "555-1234";
contactos["Luis"] = "555-5678";

Console.WriteLine("Teléfono de Ana: " + contactos["Ana"]);
Console.WriteLine("Teléfono de Luis: " + contactos["Luis"]);