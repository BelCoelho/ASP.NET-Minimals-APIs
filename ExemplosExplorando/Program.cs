﻿// See https://aka.ms/new-console-template for more information


using ExemplosExplorando.Models;

Pessoa p = new Pessoa();

Console.WriteLine("Escreva seu nome: ");
p.nome = Console.ReadLine();

Console.WriteLine("Escreva seu sobrenome: ");
p.sobrenome = Console.ReadLine();

/*Console.WriteLine("Escreva sua idade: ");
p.idade = Console.ReadLine();*/
p.idade = 20;

p.Apresentar();