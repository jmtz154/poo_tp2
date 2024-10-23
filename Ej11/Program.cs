using System;

class Program
{
    public static void Main()
    {
        Console.Write("Cantidad de personas?");
        int cantidad = int.Parse(Console.ReadLine());
                
        Persona[] personas = new Persona[cantidad];     // Crear un arreglo de personas (instancias) de largo "cantidad"

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nIngrese los datos de la persona {i + 1} en el formato: Nombre <TAB> DNI <TAB> Edad <ENTER>");
                        
            string entrada = Console.ReadLine();    // Leer la línea de entrada de datos
            string[] datos = entrada.Split('\t');   // Separar los datos por tabulación y los mete en un arreglo
            string nombre = datos[0];               // 
            string dni = datos[1];
            int edad = int.Parse(datos[2]);
            personas[i] = new Persona(nombre, edad, dni);   // Crear una nueva persona y la pone en el arreglo "personas"
        }
        
        Console.WriteLine("\nListado de Personas:");
        for (int i = 0; i < personas.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {personas[i].nombre} ({personas[i].edad})\t{personas[i].dni}");
        }
    }
}
class Persona
{
    // Campos privados
    public string nombre { get; set; }
    public int edad { get; set; }
    public string dni { get; set; }

    public Persona(string nombre, int edad, string dni)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
    }
}