using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosC.Commom.Models
{
    public class Pessoa //PascalCase
    {
        public string ?Nome { get; set; } // Propriedade sempre maiusculo
         public int Idade { get; set; }
          public decimal Peso { get; set; }

        public void Aprasentar() // Metodo sempre maiusculo
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, minha idade é {Idade} anos "+
            $"\n meu peso atual é de {Peso}");
        }
    }
}