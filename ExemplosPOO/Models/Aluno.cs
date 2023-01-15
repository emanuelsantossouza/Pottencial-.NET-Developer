using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        { 
            Console.WriteLine($"Olá meu nome é {Nome}, sou um aluno e tenho {Idade} anos. A minha nota é {Nota}");
        }
    }
}