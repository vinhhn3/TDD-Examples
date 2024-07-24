using NUnit.Framework;

namespace TDD_Examples.Tests
{
  [TestFixture]
  public class BankAccountTests
  {
    private BankAccount _bankAccount;
    [SetUp]
    public void SetUp()
    {
      _bankAccount = new BankAccount();
    }

    [Test]
    public void InitialBalance_ShouldBeZero()
    {
    }

    [Test]
    public void Deposit_ValidAmount_ShouldIncreaseBalance()
    {
    }

    [Test]
    public void Deposit_NegativeAmount_ShouldThrowArgumentException()
    {
    }

    [Test]
    public void Withdraw_ValidAmount_ShouldDecreaseBalance()
    {
    }

    [Test]
    public void Withdraw_AmountExceedingBalance_ShouldThrowInvalidOperationException()
    {
    }

    [Test]
    public void Withdraw_NegativeAmount_ShouldThrowArgumentException()
    {
    }
  }
}
