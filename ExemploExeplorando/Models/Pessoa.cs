using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExeplorando.Models
{
    public class Pessoa
    {
        public  Pessoa()
        {

        }
        public Pessoa (string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome) 
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;

        public string ?Nome 
        {
            get // =>return _nome.ToUpper(); //Body Expressions unica linha 
            {
                return _nome.ToUpper();
            }

            set
            {
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 


        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        

        public void Apesentar ()
        {
            Console.WriteLine($"Meu nome é {NomeCompleto}, minha idada é {Idade}");
        }
    }
}