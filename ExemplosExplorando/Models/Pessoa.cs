using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        public string nome {get;set;}// Essa é a Propriedadde e o atalho é "prop"
        public string idade {get;set;}// = é SET, quando só chama o valor é GET

        public void Apresentar()//Esse é o Método
        {
            Console.WriteLine($"Seu nome é {nome}, e você tem {idade} anos de idade.");//aqui é um exemplo de GET
        }
    }
}