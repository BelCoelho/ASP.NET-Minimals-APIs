using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar (int n1, int n2)
        {
            return n1 + n2;
        }

        public bool EhPar (int n)
        {
            return n % 2 == 0;
            //Verifica se o resto da divisão como o número é 0
            //Caso for 0 é par, caso contrário é impar
        }
    }
}