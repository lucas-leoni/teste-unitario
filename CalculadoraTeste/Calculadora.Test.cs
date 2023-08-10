namespace CalculadoraTeste;

public class UnitTest1
{
  Programa.Calculadora calculadora = new Programa.Calculadora();

  [Fact]
  public void TestSumTwoNumbers()
  {
    double result;
    
    result = calculadora.Somar(1, 2);
    Assert.Equal(3, result);
    
    result = calculadora.Somar(1.5, 1.6);
    Assert.Equal(3.1, result);

    result = calculadora.Somar(-1, 1);
    Assert.Equal(0, result);

    result = calculadora.Somar(0, -1.6);
    Assert.Equal(-1.6, result);
  }

  [Fact]
  public void TestSubTwoNumbers()
  {
    double result;

    result = calculadora.Subtrair(2, 1);
    Assert.Equal(1, result);
 
    result = calculadora.Subtrair(-2, 1);
    Assert.Equal(-3, result);

    // Deu erro nas casas decimais
    result = calculadora.Subtrair(0.7, 1.6);
    Assert.Equal(-0.9, result);

    result = calculadora.Subtrair(0.8, -1.3);
    Assert.Equal(-2.1, result);
  }

  [Fact]
  public void TestMulTwoNumbers()
  {
    double result;

    result = calculadora.Multiplicar(1, 2);
    Assert.Equal(2, result);

    result = calculadora.Multiplicar(-1, 2);
    Assert.Equal(-2, result);

    result = calculadora.Multiplicar(0.5, 4.5);
    Assert.Equal(2.25, result);

    result = calculadora.Multiplicar(0, -1.5);
    Assert.Equal(0, result);
  }

  [Fact]
  public void TestDivTwoNumbers()
  {
    double result;

    result = calculadora.Dividir(1, 2);
    Assert.Equal(0.5, result);

    result = calculadora.Dividir(-1, -2);
    Assert.Equal(0.5, result);

    result = calculadora.Dividir(2.5, 0.5);
    Assert.Equal(5, result);

    result = calculadora.Dividir(2, 0);
    Assert.Equal(0, result);
  }
}