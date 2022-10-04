using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploC.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Aprasentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, minha idade é {Idade} anos");
        }
    }
}