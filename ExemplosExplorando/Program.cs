// See https://aka.ms/new-console-template for more information


using System.Reflection.Metadata;
using System.Runtime.Serialization;
using ExemplosExplorando.Models;


//IF TERNÁRIO

int x = 15;
bool ePar = false;

ePar = x % 2 == 0;
Console.WriteLine($"O número {x} é " + (ePar ? "par" : "impar"));
// Considera if e else (dois resultados)
// Se a condição for verdadeira ela considera a primeira string, do contrário, a segunda




//IF NORMAL
/*
int x = 1;

if (x % 2 == 0)
{
    Console.WriteLine($"Número {x} é par");
}
else
{
    Console.WriteLine($"Número {x} não é par");
}
*/
















////////////////////////////////////////////////USANDO TUPLAS/////////////////////////////////////////////////
/*
LeituraArquivos arquivo = new LeituraArquivos();

var (sucesso, linhasArquivo, QuantidadeLinhas) = arquivo.LerArquivos("Arquivos/arquivosLeitura.txt");
// var não necessita de especificar tipo de variável
// Caso não haja a necessidade de não precisar de alguma informação é só colocar um _ no local da variável

if (sucesso)
{
    Console.WriteLine("Quantidade linhas do arquivo: " + QuantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine($"Não foi possivel ler arquivos :(\n");
}
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////////////


























//////////////////////////////////////////MEXENDO COM DICIONÁRIOS////////////////////////////////////////////////
/*
Dictionary<string, string> estados = new Dictionary<string, string>();
// Possibilita a criação de uma chave e um valor para essa chave
// Cada item é único de acordo com a chave (o valor pode ser repetido)

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
*/
////////////////////////////////////////////////////////////////////////////////////////////////////






///////////////////////////////MEXENDO COM PILHAS///////////////////////////////////////////////////////////
/*
Stack<int> pilha = new Stack<int>();// Cria a variável para Queue

pilha.Push(5);// Adiciona á Stack
pilha.Push(3);
pilha.Push(8);
pilha.Push(6);
pilha.Push(0);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo item {pilha.Pop()} da pilha");// Remove o primeiro item da Queue sem precisar declara-lo

foreach (var item in pilha)
{
    Console.WriteLine(item);
}
*/
////////////////////////////////////////////////////////////////////////////////////////////////////////








///////////////////////////////MEXENDO COM FILAS///////////////////////////////////////////////////////////
/*
Queue<int> fila = new Queue<int>();// Cria a variável para Queue

fila.Enqueue(5);// Adiciona 1 á Queue
fila.Enqueue(3);
fila.Enqueue(8);
fila.Enqueue(6);
fila.Enqueue(0);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo item {fila.Dequeue()} da fila");// Remove o primeiro item da Queue sem precisar declara-lo

foreach (var item in fila)
{
    Console.WriteLine(item);
}
*/
////////////////////////////////////////////////////////////////////////////////////////




/////////////////MEXENDO COM THROW///////////////////
/*
new ExemploExcecao().Metodo1();
*/
////////////////////////////////////////////////////







//////////////////////USANDO TRY CATCH/////////////////////////////////////////////////////////////////////////////
/*
try
{
    string[] linhas = File.ReadAllLines("Arquivos/sarquivosLeitura.txt");// Essa linha é passivel de exceção
    //Lê os arquivos e transforma cada linha em sring

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);//Imprime cada linha
    }
} 
catch(FileNotFoundException ex)
{
    Console.Write($"Arquivo não encontrado. \nMenagem de erro:\n{ex.Message}\n");
}
catch(Exception ex) //Capta a exceção/erro
{
    Console.WriteLine($"Ocorreu umaa exceção genérica. \nMenagem de erro:\n{ex.Message}\n");
    //mostra o texto caso haja algum erro
    //ex.Message mostra o erro ocorrido
}
finally
{
    Console.WriteLine("Chegou aqui dando erro ou não!!!");
}
*/
///////////////////////////////////////////////////////////////////////////////////////////////////////////



/**************************************************************
Pessoa p1 = new Pessoa();

Console.WriteLine("Escreva seu nome: ");
p1.Nome = Console.ReadLine();

Console.WriteLine("Escreva seu sobrenome: ");
p1.Sobrenome = Console.ReadLine();


Pessoa p2 = new Pessoa(nome: "isa", sobrenome: "bela");
//"nome:" e "sobrenome:" são opcionais


//Console.WriteLine("Escreva o nome: ");
//p2.nome = Console.ReadLine();

//Console.WriteLine("Escreva o sobrenome: ");
//p2.sobrenome = Console.ReadLine();


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
