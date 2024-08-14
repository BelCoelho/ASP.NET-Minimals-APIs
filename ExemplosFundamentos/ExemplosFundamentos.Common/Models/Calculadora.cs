namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
           double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double rad = angulo * Math.PI/180;
            double seno = Math.Sin(rad);
            Console.WriteLine($"Seno de {angulo}° = {seno}");
        }

        public void Cosseno(double angulo)
        {
            double rad = angulo * Math.PI/180;
            double cos = Math.Cos(rad);
            Console.WriteLine($"Cosseno de {angulo}° = {cos}");
        }

        public void Tangente(double angulo)
        {
            double rad = angulo * Math.PI/180;
            double tan = Math.Tan(rad);
            Console.WriteLine($"Tangente de {angulo}° = {tan}");
        }

        public void RaizQuadrada(double x)
        {
           double raiz = Math.Sqrt(x);
            Console.WriteLine($"√{x} = {raiz}");
        }
    }
}