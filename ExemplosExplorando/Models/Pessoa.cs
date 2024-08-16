using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        public string nome // Essa é a Propriedadde e o atalho é "prop"
        {
            get//é usado quando a variável é chamada
            {
                return _nome.ToUpper();
            }

            set//é usado quando um valor é atribuido
            {
                if (value == "")//value é um argumento que está recebendop um nome (é o que a variável recebe)
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                    //é uma excessão, onde se não for tratada o programa se encerra-rá
                }
                _nome = value;//se o nome não for vazio, o valor será atribuido para _nome
            }
        }
        public string idade {get;set;}

        public void Apresentar()//Esse é o Método
        {
            Console.WriteLine($"Seu nome é {nome}, e você tem {idade} anos de idade.");//aqui é um exemplo de GET
        }
    }
}