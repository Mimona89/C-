using System;

public class Animale
{
    public void duck()
    {
        Console.WriteLine("\n\n Enter duck often called is pack pack...\n\n");
    }
}

public class Aliphant: Animale
{
    public void Child()
    {
        Console.WriteLine("\n\n Enter Elephant often called is pack pack...\n\n");
    }
}

internal class Program
    {
        static void Main(string[] args)
        {

        Animale a1 = new Animale();
        a1.duck();

        Aliphant AB = new Aliphant();
        AB.Child();

        }
    }

