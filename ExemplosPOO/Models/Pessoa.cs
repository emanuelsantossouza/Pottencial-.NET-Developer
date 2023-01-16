using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar() 
        { 
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, o meu email é: {Email}");
        }

    }
}