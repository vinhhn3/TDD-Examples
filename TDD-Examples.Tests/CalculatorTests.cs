using NUnit.Framework;

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

    }

    [Test]
    public void Substract_ValidInputs_ReturnSubstraction()
    {

    }

    [Test]
    public void Multiply_ValidInputs_ReturnMultiplication()
    {

    }

    [Test]
    public void Divide_ValidInput_ReturnDivision()
    {

    }

    [Test]
    public void Divide_DenominatorEqualZero_ThrowExcetopion()
    {

    }
  }
}