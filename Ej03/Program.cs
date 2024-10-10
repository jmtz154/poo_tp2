using System;

class Programa
{
    public static void Main()
    {
        int valor1 = 3;
        int valor2 = 5;

        Console.WriteLine($"Valores originales:");
        Console.WriteLine($"valor1 = {valor1}");
        Console.WriteLine($"valor2 = {valor2}");
        Console.WriteLine();

        DobleNormal(valor1);
        Doble(ref valor2);

        Console.WriteLine($"Con el método DobleNormal(valor1) => valor1 = {valor1}");
        Console.WriteLine($"Con el método Doble(ref valor2):  => valor2 = {valor2}");
    }

    public static void Doble(ref int numero)    // Método que usa parámetro por referencia
    {
        numero = 2 * numero;
    }
   
    public static void DobleNormal(int numero)  // Método que usa parámetro por valor
    {
        numero = 2 * numero;
    }

    // Al usar un "parámetro por referencia" con la palabra clave "ref", permite que el método modifique directamente el valor de la variable pasada como argumento.
    // Al usar ref:
    //   *  La variable debe estar inicializada antes de pasarla al método
    //   *  El método puede modificar el valor de la variable original
    //   *  Debemos usar "ref" tanto en la declaración del método como en la llamada al método.
    // ¿Por qué usar "ref"?
    //   Sin "ref", C# pasaría el valor por copia y los cambios no afectarían a la variable original. 
    //   Con "ref", estamos trabajando directamente con la ubicación de memoria de la variable original.
    //   Cualquier cambio al parámetro afecta a la variable original.
    //
    // Método Doble(ref int numero):
    //   *  El parámetro "numero" se pasa por referencia usando la palabra clave "ref". Esto permite que cualquier cambio realizado dentro del método afecte la variable original que se
    //      pasa al método.
    //   *  El método no retorna ningún valor (es de tipo void), ya que el valor se modifica directamente en la variable original que se pasa como argumento.
    //   *  Dentro del método, se duplica el valor de numero con la operación "numero = 2 * numero".


}