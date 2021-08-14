namespace _07_ByteBank {
  public class CheckingAccount {
    private int _agency;
    private int _number;
    private double _balance = 100;

    public Client Owner { get; set; }
    public static int Qtd { get; private set; }
    public int Agency {
      get {
        return _agency;
      }
      set {
        if (value <= 0) {
          return;
        }

        _agency = value;
      }
    }
    public int Number {
      get {
        return _number;
      }
      set {
        if (value <= 0) {
          return;
        }

        _number = value;
      }
    }
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

    public CheckingAccount(int agency, int number) {
      Agency = agency;
      Number = number;

      Qtd++;
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