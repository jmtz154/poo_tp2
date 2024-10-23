using System;

class Test
{
    static void Main()
    {
        Persona p = new Persona();
        //Persona p;
        Persona p1, p2;
        p.edad = 20;
        p1 = p;
        p2 = p;
        p1.edad += 1;
        p2.edad += 1;
    }
}
class Persona
{
    // Campos privados
    public int edad;
}