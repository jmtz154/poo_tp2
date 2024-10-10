using System;

class Programa
{
    public static void Main()
    {
        int x = 5;
        int y = 3;

        Console.WriteLine();
        Console.WriteLine($"Valores originales: X = {x}, Y = {y}");
        Console.WriteLine();

        Swap(ref x, ref y);

        Console.WriteLine("Valores cambiados: X = {0}, Y = {1}", x, y);
    }

    public static void Swap(ref int x, ref int y)
    {
        int u = x;
        int v = y;
        x = v;
        y = u;
    }
}