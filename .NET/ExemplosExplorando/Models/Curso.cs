using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{

    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

            public void AdicionarAluno(Pessoa aluno)//tirando o public, os demais itens dessa linha fazem parte de um método
                                      //dentro dos parenteses tem os parâmetros/argumentos
            {
                Alunos.Add(aluno);//Adiciona alunos
            }
            public int ObterQuantidadeDeAlunosMatriculados()
            {
                int quantidade = Alunos.Count;
                return quantidade;
            }

            public void RemoverAluno(Pessoa aluno)//Se for usado outro parametro diferente de void, há de adicionar um return no método
            {
                Alunos.Remove(aluno);//Remove alunos
            }

            public void ListarAluno()
            {

                for(int posicaoAluno = 0; posicaoAluno < Alunos.Count; posicaoAluno++)
                {
                    string texto = $"N° {posicaoAluno + 1}° ";//Interpolação de strings
                    Console.WriteLine(texto + Alunos[posicaoAluno].NomeCompleto);// Contatenação de strings
                }
            }
        }
    }
