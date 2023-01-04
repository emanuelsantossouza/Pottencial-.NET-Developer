using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExeplorando.Models
{
    public class ExemploExcecao
    {
        public void Metdo1()
        {
            Metdo2();
          
        }   

        public void Metdo2()
        {
            Metdo3(); 
        } 

        public void Metdo3()
        {
            Metdo4(); 
        } 

        public void Metdo4()
        {
            throw new Exception("Ocorreu uma excecão");
        }    
    }

    
}