using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class Calculadora
    {

        private List<string> ListaHistorico;

        public Calculadora()
        {
            ListaHistorico = new List<string>();
        }

        public int Somar(int x, int y)
        {

            int r = x + y;
            ListaHistorico.Insert(0, "Resultado Soma" + r);
            return r;
        }

        public int Subtrair(int x, int y)
        {
            int r = x - y;
            ListaHistorico.Insert(0, "Resultado Subtração" + r);
            return r;
        }

        public int Multiplicar(int x, int y)
        {
            int r = x * y;
            ListaHistorico.Insert(0, "Resultado Multiplicação" + r);
            return r;
        }

        public float Dividir(float x, float y)
        {
            float r = x / y;
            ListaHistorico.Insert(0, "Resultado Divisão" + r);
            return r;
        }

        public List<string> Historico()
        {
            List<string> r;
            //ListaHistorico.RemoveRange(3, ListaHistorico.Count); 
            //Pega apenas os 3 primeiros digitos 0, 1 e 2. O resto é removido
            return ListaHistorico;
        }
    }
}