using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class ValidacaoString
    {
        public int ContarCaracteres (string texto)
        {
            int num = texto.Length;//conta a quantidade de caracteres na string
            return num;
        }
    }
}