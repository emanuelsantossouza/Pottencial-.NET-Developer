using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExeplorando.Models
{
    public class Venda
    { 

        public Venda(int id, string produto, decimal preco, DateTime horaDVenda, decimal? desconto)
        {   
            Id = id;
            Produto = produto;
            Preco = preco;
            HoradDVenda = horaDVenda;
            Desconto = desconto;
        }
    
    
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime HoradDVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}