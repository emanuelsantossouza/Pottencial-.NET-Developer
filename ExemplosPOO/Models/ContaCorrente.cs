using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial )
        {
            NumeroConta = numeroConta;   
            saldo = saldoInicial;

        }

        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        { 
            if(saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque ralizado com sucesso");
            }
            else
            {
                Console.WriteLine(" Valor desejado indisponivel, o saldo é menor que o valor requerido.");
            }
            
        }

        public void MostraSaldo() 
        { 
            Console.WriteLine($"O teu saldo é disponivel é de: {saldo}");
        }
    }
}