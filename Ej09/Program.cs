using System;

class Program
{
    public static void Main(string[] args)
    {
        Hora h = new Hora(23, 30, 15);
        h.ImprimirHora();
        Console.ReadKey(true);
    }
}
class Hora
{
    // Campos privados
    private int hs;
    private int min;
    private int sec;

    // CONSTRUCTOR
    public Hora(int hs, int min, int sec)
    {
        this.hs = hs;
        this.min = min;
        this.sec = sec;
    }

    // METODO para imprimir
    public void ImprimirHora()
    {
        Console.WriteLine();
        Console.WriteLine($"{hs} HORAS, {min} MINUTOS Y {sec} SEGUNDOS");
        Console.WriteLine();

    }
}