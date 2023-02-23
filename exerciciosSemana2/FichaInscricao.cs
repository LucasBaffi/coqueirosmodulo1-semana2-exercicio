using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Ficha
{
    
        
public class FichaInscricao
{
    public int Id { get; set; }
    public string Nome { get; set; }="";
    public DateTime DataNascimento { get; set; }
    public bool MenorIdade { get; set; }

    public void ImprimirDados()
    {
        Console.WriteLine("Código {0}, Nome {1}, Data Nascimento {2}", Id, Nome, DataNascimento, MenorIdade);
    }
}
    }
