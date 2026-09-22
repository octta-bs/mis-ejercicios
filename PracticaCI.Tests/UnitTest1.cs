using Xunit;

public class CalculadoraTests
{
    [Fact]
    public void Sumar_DosMasTres_DaCinco()
    {
        int resultado = Calculadora.Sumar(2, 3);
        Assert.Equal(5, resultado);
    }
}