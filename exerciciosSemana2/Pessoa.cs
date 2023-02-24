
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pessoaIdade
{
    public class Pessoa
    {
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }


        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }
        public int CalcularIdade()
        {
            var dataNascimento = new DateTime(1984, 1, 2);
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
        public void MostrarIdade()
        {
            int idade = CalcularIdade();
            Console.WriteLine($"Nome {Nome} tem a Idade {idade}");
        }

    }
}

