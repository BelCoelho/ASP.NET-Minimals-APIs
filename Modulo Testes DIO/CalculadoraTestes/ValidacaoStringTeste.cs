using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacaoStringTeste
    {
        private ValidacaoString _validacao;

        public ValidacaoStringTeste()
        {
            _validacao = new ValidacaoString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOLAERetornar3()
        {
            //Arrange
            string texto = "Ola";

            //Act
            int resultado = _validacao.ContarCaracteres(texto);
            //Conta a quantidade de caracteres na string texto (ola)

            //Assert
            Assert.Equal(3, resultado);
            //Valida se o resultado retorna a quantidade de caracteres 3
        }

    }
}