using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExeplorando.Models
{
    public class Venda1
    {
        public int Id  { get; set; }

        [JsonProperty("Nome_Produto")]
        public string Produto  { get; set; }


        public decimal Preco  { get; set; }
        public DateTime HoradDVenda  { get; set; }

        public decimal? Desconto { get; set; }
    }
}