using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace somGuitarra
{
    public class Guitarra
    {
        private static string Afinacao;

        static Guitarra()
        {
            Afinacao = "Sol";

        }
        private static void TomAfinado()
        {
            Console.WriteLine($"A guitarra está com afinação em  {Afinacao}");
        }
        public void Tocar()
        {
            TomAfinado();
        }
        public void Tocar(string afinaçãoAtual)
        {
            Afinacao = afinaçãoAtual;
            TomAfinado();
        }


    }
}