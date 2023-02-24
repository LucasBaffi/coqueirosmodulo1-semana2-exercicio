using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace animacao
{

public static class Animacao
{
    public static void Animação()
    {
        Console.WriteLine("Animação Frozen");
    }

    public static void Animação(string nomeAnimacao)
    {
        Console.WriteLine($"Animação {nomeAnimacao}");
    }
}
}