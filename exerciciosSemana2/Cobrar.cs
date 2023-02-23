using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cobranca
{
    public class Cobrar
    {
        private decimal Valor { get; }
        private decimal Multa { get; }

         public Cobrar(decimal valor, decimal multa)
    {
        Valor = valor;
        Multa = multa;
    }

    private decimal CalcularMulta()
    {
        return Valor + Multa;
    }

    public void Calcular()
    {
        decimal somaValor = CalcularMulta();
        Console.WriteLine($"Valor Cobrado {Valor}, Multa {Multa}, Soma Valor {somaValor}");
    }
    }
   


}