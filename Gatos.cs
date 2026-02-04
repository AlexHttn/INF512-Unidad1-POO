using System;

public class Gato
{
    // Atributos (estado)
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Color { get; set; }
    
    // Constructor
    public Gato(string nombre, int edad, string color)
    {
        Nombre = nombre;
        Edad = edad;
        Color = color;
    }
    
    // Métodos (comportamiento)
    public void Maullar()
    {
        Console.WriteLine($"{Nombre} esta maullando: Miau!");
    }
    
    public void Comer()
    {
        Console.WriteLine($"{Nombre} esta comiendo su comida favorita.");
    }
    
    public void Dormir()
    {
        Console.WriteLine($"{Nombre} esta durmiendo placidamente.");
    }
}
