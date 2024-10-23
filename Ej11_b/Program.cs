using System;
using System.Collections;       // Para poder usar "ArrayList"

class Program
{
    public static void Main()
    {        
        ArrayList personas = new ArrayList();   // Crear un ArrayList para almacenar las personas
                
        while (true)
        {
            Console.WriteLine("\nIngrese los datos en el formato: Nombre <TAB> DNI <TAB> Edad <ENTER> (deje en blanco para finalizar)");
            string entrada = Console.ReadLine();
                        
            if (string.IsNullOrWhiteSpace(entrada))     // Si la entrada está vacía, terminar el ciclo
            {
                break;
            }
            
            string[] datos = entrada.Split('\t');   // Separar los datos por tabulación            
            string nombre = datos[0];
            string dni = datos[1];
            string edad = datos[2];
            
            personas.Add(new Persona(nombre, edad, dni));   // Crear una nueva persona y agregarla al ArrayList
        }

        Console.WriteLine("\nListado de Personas:");
        for (int i = 0; i < personas.Count; i++)
        {
            Persona persona = (Persona)personas[i];
            Console.WriteLine($"{i + 1}) {persona.nombre} ({persona.edad})\t{persona.dni}");
        }        
    }
}
class Persona
{    
    public string nombre { get; set; }
    public string edad { get; set; }
    public string dni { get; set; }

    public Persona(string nombre, string edad, string dni)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
    }   

}