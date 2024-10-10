using System;

class Programa
{    
    public static int Suma(int a, int b)
    {
        return a + b;
    }

    public static void Main()
    {
        int x = 3;
        int y = 5;
        Console.WriteLine();
        Console.WriteLine(" " + Suma(x, y));
    }
}