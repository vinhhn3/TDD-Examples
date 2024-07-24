using NUnit.Framework;

using System;

namespace TDD_Examples.Tests
{
  [TestFixture]
  public class CalculatorTests
  {
    private Calculator calculator;

    [SetUp]
    public void SetUp()
    {
      calculator = new Calculator();
    }

    [Test]
    public void Add_ValidInputs_ReturnSum()
    {
      // Assert
      var a = 10;
      var b = 20;
      var expectedReuslt = 30;

      // Act
      var actualResult = calculator.Add(a, b);

      // Assert
      Assert.AreEqual(expectedReuslt, actualResult);
    }

    [Test]
    public void Substract_ValidInputs_ReturnSubstraction()
    {
      // Arrange
      var a = 20;
      var b = 10;
      var expectedReuslt = 10;

      // Act
      var actualResult = calculator.Subtract(a, b);

      // Assert
      Assert.AreEqual(expectedReuslt, actualResult);
    }

    [Test]
    public void Multiply_ValidInputs_ReturnMultiplication()
    {
      // Arrange
      var a = 20;
      var b = 10;
      var expectedReuslt = 200;

      // Act
      var actualResult = calculator.Multiply(a, b);

      // Assert
      Assert.AreEqual(expectedReuslt, actualResult);
    }

    [Test]
    public void Divide_ValidInput_ReturnDivision()
    {
      // Arrange
      var a = 10;
      var b = 20;
      var expectedReuslt = 0.5;

      // Act
      var actualResult = calculator.Divide(a, b);

      // Assert
      Assert.AreEqual(expectedReuslt, actualResult);
    }

    [Test]
    public void Divide_DenominatorEqualZero_ThrowExcetopion()
    {
      // Arrange
      var a = 10;
      var b = 0;

      // Act

      // Assert
      Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
    }
  }
}
