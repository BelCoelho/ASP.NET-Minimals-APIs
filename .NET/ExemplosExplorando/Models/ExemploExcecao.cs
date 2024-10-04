using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try{
            Metodo2();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exceção tratada.\n{ex.StackTrace} ");//StackTrace é um rastro da stack
            }
        }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }

        public void Metodo4()
        {
            throw new Exception("Ocorreu um erro!\n");
            //throw rele o programa de baixo para cima em busca do Trycatch
            //Caso o catch não seja achado, ele retorna a exceção
        }
    }
}