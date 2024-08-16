using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa // public diz que qualquer um pode acessar a classe ou propriedade
    {
        private string _nome;// private só pode ser usado na propria classe (nesse caso, é a Pessoa)
                             //é um meio de proteger a variável. Isso é chamado de encapsulamento
        private int _idade;

        public string nome // Essa é a Propriedadde, e seu atalho é "prop"
                           //A principal característica de uma Propriedade é ter o GET e o SET 
        {
            get//é usado quando a variável é chamada
            {
                return _nome.ToUpper();// tambem da para tirar as chaves e o return e substituir por =>
                                       //get => _nome.ToUpper(); 
            }
            set//é usado quando um valor é atribuido
            {
                if (value == "")//value é um argumento que está recebendop um nome (é o que a variável recebe)
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                    //é uma excessão, onde se não for tratada o programa se encerra-rá
                }
                _nome = value;//se o nome não for vazio, o valor será atribuido para _nome
            }
        }

        public string sobrenome { get; set; }
        public string NomeCompleto => $"{nome} {sobrenome}".ToUpper();

        public int idade 
        {
            get => _idade;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa!");
                }
                _idade = value;
            }
        }

        public void Apresentar()//Esse é o Método
        {
            Console.WriteLine($"Seu nome é {NomeCompleto}, e você tem {idade} anos de idade.");//aqui é um exemplo de GET
        }
    }
}