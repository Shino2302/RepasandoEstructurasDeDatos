using Listasss;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Listasss.Lista lista = new Listasss.Lista();
        for (int i = 0; i < 5; i++)
        {
            Persona persona = new Persona();
            Console.WriteLine($"Ingresa a la persona {i + 1}");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine($"Ingrese la edad de la persona {i + 1}");
            persona.Edad = int.Parse(Console.ReadLine());
            lista.IngresarEnLista(persona);
            Console.Clear();
        }
        lista.Listar();
        Console.ReadKey();
        lista.OrdenarPorEdad();
        Console.ReadKey();
        lista.Listar(); ;
        Console.ReadKey();
    }
}