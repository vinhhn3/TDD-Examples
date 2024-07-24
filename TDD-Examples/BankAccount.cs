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


    /// <summary>
    /// Deposits a specified amount into the account.
    /// </summary>
    /// <param name="amount">The amount to deposit. Must be positive.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when the deposit amount is less than or equal to zero.
    /// </exception>
    public void Deposit(decimal amount)
    {

    }

    /// <summary>
    /// Withdraws a specified amount from the account.
    /// </summary>
    /// <param name="amount">
    /// The amount to withdraw. Must be positive and less than or equal to the current balance.
    /// </param>
    /// <exception cref="ArgumentException">
    /// Thrown when the withdrawal amount is less than or equal to zero.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the withdrawal amount exceeds the current balance.
    /// </exception>
    public void Withdraw(decimal amount)
    {

    }
  }
}
