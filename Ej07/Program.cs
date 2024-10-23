using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    public static void Main()
    {
        Empleado emp1 = new Empleado("Pedro", 25000);
        //emp1.Nombre = "Carlos";
        emp1.Sueldo = 40000;

        emp1.ImprimirDatos();
        emp1.ImprimirImpuesto();
    }
}
class Empleado
{
    // Campos privados
    private string nombre;
    private double sueldo;
    
    // CONSTRUCTOR
    public Empleado(string nombre, double sueldo)
    {
        this.nombre = nombre;
        this.sueldo = sueldo;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public double Sueldo
    {
        get { return sueldo; }
        set { sueldo = value; }
    }
        
    // METODO para imprimir los datos
    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Salario: {sueldo}");
        
    }

    // METODO para imprimir si deba pagar impuestos
    public void ImprimirImpuesto()
    {
        if (sueldo >= 30000)
        {
            Console.WriteLine($">> Este empleado debe pagar impuestos!! <<");
            Console.WriteLine();
        }        
        else
        {
            Console.WriteLine();
        }
    }

}