
namespace ExemploFundamentos.Models //o namespace é um caminho para sua classe (Pessoa)
{
    public class Pessoa //nome da classe é pessoa
    {

        public string nome { get; set; }
        public int idade { get; set; }

        public void Apresentar ()// Essa é a classe
        {

            Console.WriteLine ($"Olá, meu nome é {nome}, e a minha idade é {idade} anos.");// Esse é o método, ele é um pedaço de programa que faz alg
            //O texto é um parâmetro/argumento que fica dentro do Método (writeLine) 
            
        }

    }

}