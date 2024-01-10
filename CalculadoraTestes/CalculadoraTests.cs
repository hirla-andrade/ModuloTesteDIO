using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests 
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        
        // Arrange //os numeros que vamos passar
        int num1 = 5;
        int num2 = 10;

        // Act //Ação, vai fazer a soma e colocar na variavel resultado
        int resultado = _calc.Somar(num1, num2);

        // Assert //validançao do resultado
        Assert.Equal(15, resultado);

    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        
        // Arrange //os numeros que vamos passar
        int num1 = 10;
        int num2 = 10;

        // Act //Ação, vai fazer a soma e colocar na variavel resultado
        int resultado = _calc.Somar(num1, num2);

        // Assert //validançao do resultado
        Assert.Equal(20, resultado);

    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro() {

        //Arrange
        int numero = 4;

        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory] //executar teste várias vezes ou para vários valores
    [InlineData(new int[] { 2, 4})] 
    [InlineData(new int[] { 6, 8, 10})] 
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros){ // coloquei o [] depois do int porque é um array

        //Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}