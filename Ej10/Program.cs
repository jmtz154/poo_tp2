using System;

class Program
{
    public static void Main(string[] args)
    {
        Hora h1 = new Hora(23, 30, 15);
        Hora h2 = new Hora("14:25:47");
        Console.WriteLine();
        h1.ImprimirHora();
        h2.ImprimirHora();
        Console.WriteLine();
        Console.ReadKey(true);
    }
}
class Hora
{
    // Campos privados
    private int hs;
    private int min;
    private int sec;

    // CONSTRUCTOR 1
    public Hora(int hs, int min, int sec)
    {
        this.hs = hs;
        this.min = min;
        this.sec = sec;
    }

    // CONSTRUCTOR 2 para recibir una cadena en formato "HH:MM:SS"
    public Hora(string hora)
    {      
        string[] partes = hora.Split(':');  // Dividir la cadena usando el delimitador ":"
        this.hs = int.Parse(partes[0]);  // Convertir la primera parte en horas
        this.min = int.Parse(partes[1]); // Convertir la segunda parte en minutos
        this.sec = int.Parse(partes[2]); // Convertir la tercera parte en segundos
    }


    // METODO para imprimir
    public void ImprimirHora()
    {        
        Console.WriteLine($"{hs} HORAS, {min} MINUTOS Y {sec} SEGUNDOS");       
    }
}