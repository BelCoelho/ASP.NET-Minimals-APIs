using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class VendaDeserializando
    {
        // O programa em JSON deveráser mapeado visualmente e suas propriedades colocadas em uma classe
        public int ID { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; } 
    }
}