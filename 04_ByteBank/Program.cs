using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank {
  class Program {
    static void Main(string[] args) {
      CheckingAccount accountJohn = new CheckingAccount();

      accountJohn.owner = "John";
      
      Console.WriteLine("John's Balance: " + accountJohn.balance);
      bool result = accountJohn.Withdraw(500);
      Console.WriteLine("John's Balance: " + accountJohn.balance);
      Console.WriteLine(result);


      accountJohn.Deposit(500);

      Console.WriteLine("John's Balance: " + accountJohn.balance);
      result = accountJohn.Withdraw(500);
      Console.WriteLine("John's Balance: " + accountJohn.balance);
      Console.WriteLine(result);

      accountJohn.Deposit(500);
      CheckingAccount accountBill = new CheckingAccount();
      accountBill.owner = "Bill";

      Console.WriteLine("John's Balance: " + accountJohn.balance);
      Console.WriteLine("Bill's Balance: " + accountBill.balance);
      result = accountJohn.Transfer(200, accountBill);
      Console.WriteLine(result);
      Console.WriteLine("John's Balance: " + accountJohn.balance);
      Console.WriteLine("Bill's Balance: " + accountBill.balance);

      Console.WriteLine("John's Balance: " + accountJohn.balance);
      Console.WriteLine("Bill's Balance: " + accountBill.balance);
      result = accountBill.Transfer(100, accountJohn);
      Console.WriteLine(result);
      Console.WriteLine("John's Balance: " + accountJohn.balance);
      Console.WriteLine("Bill's Balance: " + accountBill.balance);

      Console.ReadLine();
    }
  }
}
