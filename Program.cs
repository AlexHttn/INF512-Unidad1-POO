using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un gato
        Gato miGato = new Gato("Michi", 3, "Naranja");
        
        // Usar los métodos
        miGato.Maullar();
        miGato.Comer();
        miGato.Dormir();
        
        // Crear otro gato
        Gato otroGato = new Gato("Luna", 2, "Blanco");
        
        Console.WriteLine("\nInformación del segundo gato:");
        Console.WriteLine($"Nombre: {otroGato.Nombre}");
        Console.WriteLine($"Edad: {otroGato.Edad} años");
        Console.WriteLine($"Color: {otroGato.Color}");
        
        otroGato.Maullar();
        otroGato.Comer();
        otroGato.Dormir();
        
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
