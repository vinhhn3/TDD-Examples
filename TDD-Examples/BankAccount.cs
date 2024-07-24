namespace TDD_Examples
{
  public class BankAccount
  {
    private decimal _balance;

    public BankAccount()
    {
      _balance = 0;
    }

    public decimal Balance
    {
      get { return _balance; }
    }


    // Adds the specified amount to the bank account balance.
    // Throws an ArgumentException if the amount is less than or equal to zero.
    public void Deposit(decimal amount)
    {

    }

    // Subtracts the specified amount from the bank account balance.
    // Throws an ArgumentException if the amount is less than or equal to zero,
    // and an InvalidOperationException if the amount exceeds the current balance.
    public void Withdraw(decimal amount)
    {

    }
  }
}
