using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public  class Diretor : Professor
    {   
        

        public Diretor(string nome, int idade, string email) : base(nome, idade, email)
        {
            
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }
        
    }
}