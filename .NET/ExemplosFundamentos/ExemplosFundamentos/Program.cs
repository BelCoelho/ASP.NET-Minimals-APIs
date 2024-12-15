using ExemploFundamentos.Common.Models; //usando a "pessoa" do namespace "models"
                                        //o namespace é um caminho para sua classe

//////////////////////////////////////////LISTAS///////////////////////////////////////////////////
/*
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RS");

Console.WriteLine("Percorrendo a lista com FOR");
for (int contador = 0;contador < listaString.Count; contador++)//Count retorna o valor maximo de casas
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

Console.WriteLine($"Itens da sua lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("RJ");//adicionando no meio do código

Console.WriteLine("Percorrendo a lista com FOREACH");
int contadorForech = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição N° {contadorForech} - {item}");
    contadorForech++;
}

Console.WriteLine($"Itens da sua lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
*/
///////////////////////////////////////////////////////////////////////////////////////////////////




//////////////////////////////////////////ARRAYS///////////////////////////////////////////////////
/****************************************************************************************************************************************************************
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 66;
arrayInteiros[1] = 35;
arrayInteiros[2] = 74;

Console.WriteLine("Valores no array");

Console.WriteLine($"{arrayInteiros[0]}, {arrayInteiros[1]}, {arrayInteiros[2]}");*/



//COPIANDO OS VALORES DE UM ARRAY PARA UM OUTRO ARRAY
/****************************************************************************************************************************************************************
int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
//declarando um novo array com a capacidade maxima sendo o dobro do primeiro array

Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);
//copia arraisInteiros para arraysInteirosDobrados com a capacidade de arraisInteiros
*/



//REDIMENSIONANDO UM ARRAY

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
//Array é uma clasee
//Resize vai redimensionar arrayInteiros
//Depois pega a capacidade maxima de casas e dobra



//PERCORREBNDO UM ARRAY
/****************************************************************************************************************************************************************
Console.WriteLine("Percorrendo o array com FOR");
for (int contador = 0 ; contador < arrayInteiros.Length ; contador++)// Length pega o valor maximo de casas da array
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o array com FOREACH");
foreach (int valor in arrayInteiros)// faz a mesma coisa que o FOR, mas não da para colocar um contador (Posição N°...)
{
    Console.WriteLine(valor);
}
*/
//////////////////////////////////////////////////////////////////////////////////////////////////




/*****************************FAZENDO UM MENU INTERATIVO************************************/
/***********************************NÃO FUNCIONOU*******************************************/

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
}

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
/*
Pessoa p = new Pessoa ();        // "p" é uma variável

p.nome = "Isa";                  // variável "nome" recebe o valor "Isa"
p.idade = 20;                    // variável "idade" recebe o valor "20"
p.Apresentar();                  // executa o método "Apresentar"
*/
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

