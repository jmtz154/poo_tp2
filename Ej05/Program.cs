using System;
class Program
{
    public static void Main()
    {
        Persona persona1 = new Persona("Juan", 25);     // Crear una instancia de Persona llamada "persona1"
        Persona persona2 = new Persona("Ana", 15);      // Crear una instancia de Persona llamada "persona2"
        persona2.Nombre = "Ana María";                  // Modifica un dato de la instancia "persona2"
        persona2.Edad = 16;                             // Modifica un dato de la instancia "persona2"

        persona1.ImprimirDatos();
        persona2.ImprimirDatos();
    }
}
class Persona
{
    // Campos privados
    private string nombre;
    private int edad;

    
    public Persona(string nombre, int edad)     // Constructor
    {
        this.nombre = nombre;
        this.edad = edad;
    }
       
    public string Nombre                        // Propiedades
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }
        
    public void ImprimirDatos()             // Método para imprimir datos
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");

        if (edad >= 18)
        {
            Console.WriteLine("Esta persona es mayor de edad");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Esta persona es menor de edad");
            Console.WriteLine();
        }
    }
}