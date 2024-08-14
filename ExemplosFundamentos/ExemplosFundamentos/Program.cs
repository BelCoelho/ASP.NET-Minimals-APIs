using ExemploFundamentos.Common.Models; //usando a "pessoa" do namespace "models"
                                 //o namespace é um caminho para sua classe


/*****************************FAZENDO UM MENU INTERATIVO************************************/
/***********************************NÃO FUNCIONOU*******************************************/
/*
String option;

while (true)
{
    Console.Clear();// vai limpar o menu
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
}

switch (option)
{
    case "1":
        Console.WriteLine("Cadastrar cliente");
    case "2":
        Console.WriteLine("Buscar cliente");
    case "3":
        Console.WriteLine("Apagar cliente");
    case "4":
        Console.WriteLine("Encerrar");
        Environment.Exit(0);
        break;

    default:
        Console.WriteLine("Opção inálida!");
        break;
}*/

/*****************************************************************************************/








//////////////////////////////////////////ESTRUTURA DE REPETIÇÃO _do while_///////////////////////////////////////////////////
/*
string a;

do
{
    Console.WriteLine("Digite qualquer letra para prosseguir ou 'n' para parar: ");
    a = Console.ReadLine();
} 
while (a != "n");
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




//////////////////////////////////////////ESTRUTURA DE REPETIÇÃO _while_///////////////////////////////////////////////////
/*
Console.WriteLine("Digite qualquer letra para prosseguir ou 'n' para parar: ");
string a = Console.ReadLine();

while (a != "n")// Se for digitado 'n' então o look para
{
    Console.WriteLine("Digite qualquer letra para prosseguir ou 'n' para parar: ");
    a = Console.ReadLine();

    if (a == "p")// Se for digitado 'p' então o look para
    {
        break;
    }
}
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




//////////////////////////////////////////ESTRUTURA DE REPETIÇÃO _for_///////////////////////////////////////////////////
/*
int numero = 2;

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} X 1 = {numero * contador}");
}
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





//////////////////////////////////////////OPERADORES ARITMÉTICOS E CLASSE MATH///////////////////////////////////////////////////
/*
Calculadora calc = new Calculadora();

calc.Somar(2,6);
calc.Subtrair(2,6);
calc.Multiplicar(2,6);
calc.Dividir(2,6);
calc.Potencia(6,2);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

int num = 5;

Console.WriteLine($"\nNúmero = {num}");
num++;
Console.WriteLine($"Número incrementado = {num}");
num--;
Console.WriteLine($"Número decrementado = {num}");
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





//////////////////////////////////////////OBJETO///////////////////////////////////////////////////

Pessoa p = new Pessoa ();        // "p" é uma variável

p.nome = "Isa";                  // variável "nome" recebe o valor "Isa"
p.idade = 20;                    // variável "idade" recebe o valor "20"
p.Apresentar();                  // executa o método "Apresentar"

///////////////////////////////////////////////////////////////////////////////////////////////////





//////////////////////////////////////////DATA///////////////////////////////////////////////////
/*
DateTime dataAtual = DateTime.Now; //mostra a data e a hora atual do computador
Console.WriteLine(dataAtual);
*/
/////////////////////////////////////////////////////////////////////////////////////////////////





//////////////////////////////////////////CASTING///////////////////////////////////////////////////
/*
int a = int.Parse ("5");
double h = 5.7;
int a = h;

Console.WriteLine (a);
*/
///////////////////////////////////////////////////////////////////////////////////////////////////





//////////////////////////////////////////OPERADORES CONDICIONAIS///////////////////////////////////////////////////
/*
Console.WriteLine("Digite uma letra: ");
string a = Console.ReadLine();

Console.WriteLine("Digite uma letra: ");
string b = Console.ReadLine();  

if (a == b)
{
    Console.WriteLine("Iguais");
}
else
{
    Console.WriteLine("Diferentes");
}

switch (a)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":   
        Console.WriteLine("Primeira letra é vogal");
        break;

    default:
        Console.WriteLine("Primeira letra é consoante");
        break;
}
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

