namespace _06_ByteBank {
  public class CheckingAccount {
    public Client Owner { get; set; }
    public int Agency { get; set; }
    public int Number { get; set; }
    private double _balance = 100;
    public double Balance {
      get {
        return _balance;
      }
      set {
        if (value < 0) {
          return;
        }

        _balance = value;
      }
    }

    public bool Withdraw(double value) {
      if (_balance < value) {
        return false;
      }
      _balance -= value;
      return true;
    }

    public void Deposit(double value) {
      _balance += value;
    }

    public bool Transfer(double value, CheckingAccount destAccount) {
      if (_balance < value) {
        return false;
      }
      _balance -= value;
      destAccount.Deposit(value);
      return true;
    }
  }
}