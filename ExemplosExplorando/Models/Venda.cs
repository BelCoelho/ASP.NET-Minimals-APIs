using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemplosExplorando.Models
{
    public class Venda
    {
        public Venda (int id, string produto, decimal preco, DateTime dataVenda)
        {
            ID = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;

        }

        public int ID { get; set; }
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        // O ATRIBUTO vai dizer que que a propriedade vai vir nomeada como está nas ("")
        // Mas ele será convertido para Produto
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}