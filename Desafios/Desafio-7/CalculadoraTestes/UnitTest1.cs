namespace Calculadora.Services;

public class UnitTest1
{
    [Fact]
    public void Somar()
    {
            Calculadora _calc = new Calculadora();

            //Arrange
            int x = 5;
            int y = 10;

            //Act
            int resultado = _calc.Somar(x, y);

            //Assert
            Assert.Equal(15, resultado);
    }

    [Fact]
    public void Multiplicar()
    {
            Calculadora _calc = new Calculadora();

            //Arrange
            int x = 5;
            int y = 10;

            //Act
            int resultado = _calc.Multiplicar(x, y);

            //Assert
            Assert.Equal(50, resultado);
    }

    [Fact]
    public void Subitrair()
    {
            Calculadora _calc = new Calculadora();

            //Arrange
            int x = 5;
            int y = 10;

            //Act
            int resultado = _calc.Subtrair(x, y);

            //Assert
            Assert.Equal(-5, resultado);
    }

    [Fact]
    public void Dividir()
    {
            Calculadora _calc = new Calculadora();

            //Arrange
            float x = 5;
            float y = 10;

            //Act
            float resultado = _calc.Dividir(x, y);

            //Assert
            Assert.Equal(0.5, resultado);
    }

    [Fact]
    public void Historico()
    {
            Calculadora _calc = new Calculadora();

            //Arrange
            var lista = _calc.Historico();

            //Act
            _calc.Somar(2, 3);
            _calc.Subtrair(5, 3);
            _calc.Multiplicar(2, 8);
            _calc.Dividir(5, 2);

            //Assert
            Assert.NotEmpty(lista);
    }
}