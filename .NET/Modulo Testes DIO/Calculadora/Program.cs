using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int n1 = 8;
int n2 = 2;

Console.WriteLine($"{n1} + {n2} = {c.Somar(n1, n2)}");