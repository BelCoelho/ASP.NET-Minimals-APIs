using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class LeituraArquivos
    {
        public (bool Sucesso, string[] Linhas, int Quantidade) LerArquivos(string caminho)
        // O método vai ler um arquivo, e o retorno será uma tupla
        {
            try
            {
            string[] linhas = File.ReadAllLines(caminho);
            return(true, linhas, linhas.Count());
            // Se a leitura for bem sucedida, será retornada uma tupla
            // vai retornar o bool true, as linhas lidas e a quantidade de linhas
            }
            catch (Exception ex)
            {
                return(false, new string[0], 0);
                // Se a leitura mal bem sucedida, será retornada uma tupla
                // vai retornar o bool false, um array vazio (porque não leu nada) e a quantidade de linhas nula
            }
        }
    }
}