using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    public static void Main()
    {
        Triangulo tri1 = new Triangulo(25, 25, 25);   // Crear una instancia de Triangulo llamada "tri1"
        Triangulo tri2 = new Triangulo(1, 1, 1);      // Crear una instancia de Triangulo llamada "tri2"
    }
}
class Triangulo
{
    // Campos privados
    private int lado1;
    private int lado2;
    private int lado3;

    // CONSTRUCTOR
    public Triangulo(int lado1, int lado2, int lado3)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    public int Lado1                        // Propiedades
    {
        get { return lado1; }
        set { lado1 = value; }
    }
}