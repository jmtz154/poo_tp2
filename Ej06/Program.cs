using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    public static void Main()
    {
        Triangulo tri1 = new Triangulo(25, 25, 25);   // Crear una instancia de Triangulo llamada "tri1"
        Triangulo tri2 = new Triangulo(1, 1, 1);      // Crear una instancia de Triangulo llamada "tri2"
        tri2.Lado1 = 10;
        tri2.Lado2 = 20;
        tri2.Lado3 = 30;

        tri1.ImprimirLadoMayor();
        tri1.ImprimirTipoDeTriangulo();
    }
}
class Triangulo
{
    // Campos privados
    private double lado1;
    private double lado2;
    private double lado3;

    // CONSTRUCTOR
    public Triangulo(double lado1, double lado2, double lado3)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    public double Lado1
    {
        get { return lado1; }
        set { lado1 = value; }
    }
    public double Lado2
    {
        get { return lado2; }
        set { lado2 = value; }
    }
    public double Lado3
    {
        get { return lado3; }
        set { lado3 = value; }
    }

    // FALTA un metodo para comprobar si los lados cierran un triangulo

    // METODO para imprimir el lado mayor
    public void ImprimirLadoMayor()
    {
        double mayor = Math.Max(lado1, Math.Max(lado2, lado3));
        Console.WriteLine($"El lado mayor es: {mayor}");
    }

    // METODO para imprimir el tipo de triangulo
    public void ImprimirTipoDeTriangulo()
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triángulo es equilátero.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triángulo es isósceles.");
        }
        else
        {
            Console.WriteLine("El triángulo es escaleno.");
        }
    }

}