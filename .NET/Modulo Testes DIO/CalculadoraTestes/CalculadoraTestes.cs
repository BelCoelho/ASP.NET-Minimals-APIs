using Calculadora.Services;
//Importando de outro projeto

namespace CalculadoraTestes;

public class calculadoraTestes
{
    private CalculadoraImp _calc;
    //Importando CalculadoraImp

    public calculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]//É obrigatório para tornar essa classe em Teste
    public void DeveSomar8Com2EDeveRetornar10()
    {
        //Conceitos para criar o teste
        //Arrange -> Preparar o cenário
        int n1 = 8;
        int n2 = 2;

        //Act -> Executa a ação
        int resultado = _calc.Somar(n1, n2);

        //Assert -> Valida se os outros dois passos deram certo
        Assert.Equal(10, resultado);
        //Valida se o resultade é 10
    }
/*COM FACT
    [Fact]
    public void DeveVerificarSeEhPar()
    {
        //Arrange
        int n = 4;

        //Act
        bool resultado = _calc.EhPar(n);

        //Assert
        Assert.True(resultado);
    }
    */
    [Theory]
    [InlineData(2)]
    [InlineData(8)]
    [InlineData(4)]
    [InlineData(6)]
    public void DeveVerificarSeEhPar(int n)
    {
        //Arrange

        //Act
        bool resultado = _calc.EhPar(n);

        //Assert
        Assert.True(resultado);
    }
}
