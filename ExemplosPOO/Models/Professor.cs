using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome}, Sou um professor e Atualmento tenho {Idade}, Meu salario é de: {Salario:C}");
        } 
    }

    
}