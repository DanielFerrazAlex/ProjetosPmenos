using System;
using System.Linq;

namespace HarmonicNumber;

class Programa
{
    static void Main(string[] args)
    {
        Console.Write("Quantidade de números: ");
        int n = Console.Read();
        foreach (int i in Enumerable.Range(1, 1 + n))
        {
            n = i;
            float h = (1 / i);
            Console.Write($"Resultdado: {h} \n");
        }
    }
}