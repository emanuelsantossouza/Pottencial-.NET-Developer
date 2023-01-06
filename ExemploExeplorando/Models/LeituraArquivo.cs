using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExeplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int Quantidade) LerArquivo(string caminho) 
        { 
            try{
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch(Exception){
                return (false, new string[0], 0);
            }
            
        }
    }
}