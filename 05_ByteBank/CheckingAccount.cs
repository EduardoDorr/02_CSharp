namespace _05_ByteBank {
  public class CheckingAccount {
    public Client owner;
    public int agency;
    public int number;
    public double balance = 100;

    public bool Withdraw(double value) {
      if (this.balance < value) {
        return false;
      }
      this.balance -= value;
      return true;
    }

    public void Deposit(double value) {
      this.balance += value;
    }

    public bool Transfer(double value, CheckingAccount destAccount) {
      if (this.balance < value) {
        return false;
      }
      this.balance -= value;
      destAccount.Deposit(value);
      return true;
    }
  }
}