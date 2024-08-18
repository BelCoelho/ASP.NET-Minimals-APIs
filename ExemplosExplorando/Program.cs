// See https://aka.ms/new-console-template for more information


using System.Runtime.Serialization;
using ExemplosExplorando.Models;

Pessoa p1 = new Pessoa();

Console.WriteLine("Escreva seu nome: ");
p1.Nome = Console.ReadLine();

Console.WriteLine("Escreva seu sobrenome: ");
p1.Sobrenome = Console.ReadLine();


Pessoa p2 = new Pessoa(nome: "isa", sobrenome: "bela");
//"nome:" e "sobrenome:" são opcionais

/*
Console.WriteLine("Escreva o nome: ");
p2.nome = Console.ReadLine();

Console.WriteLine("Escreva o sobrenome: ");
p2.sobrenome = Console.ReadLine();
*/

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Inglês";
CursoDeIngles.Alunos = new List<Pessoa>();


Console.WriteLine("Alunos do curso de inglês: ");
CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAluno();









/////////////////REFERENTE A CLASSE PESSOA///////////////////

/*Pessoa p = new Pessoa();

Console.WriteLine("Escreva seu nome: ");
p.nome = Console.ReadLine();

Console.WriteLine("Escreva seu sobrenome: ");
p.sobrenome = Console.ReadLine();

//Console.WriteLine("Escreva sua idade: ");
//p.idade = Console.ReadLine();
p.idade = 20;

p.Apresentar();*/