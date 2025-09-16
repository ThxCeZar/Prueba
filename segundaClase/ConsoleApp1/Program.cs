using System;

class Program
{
    public static void Main(String[] args)
    {
        Gato Felix = new Gato();
        Perro Firu = new Perro();
        Pato Lucas = new Pato();
        Console.WriteLine(Felix.Dormir());
        Console.WriteLine(Felix.Respirar());
        Console.WriteLine(Firu.Dormir());
        Console.WriteLine(Firu.Respirar());
        Console.WriteLine(Lucas.Dormir());
        Console.WriteLine(Lucas.Respirar());
    }
}