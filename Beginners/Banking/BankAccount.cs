class BankAccount
{
  string accountNumber;
  decimal balance;
  string owner;
  public BankAccount(string accountNumber, decimal balance, string owner)
  {
    this.accountNumber = accountNumber;
    this.balance = balance;
    this.owner = owner;
  }

  public void Deposit(decimal amount)
  {
    balance += amount;
  }
  public bool Withdraw(decimal amount)
  {
    if (balance < amount)
    {
      return false;
    }
    balance -= amount;
    return true;
  }
  public decimal GetBalance()
  {
    return balance;
  }

  public void Transfer(BankAccount destinationAccount, decimal amount)
  {
    if (Withdraw(amount))
    {
      destinationAccount.Deposit(amount);
    }
  }
}