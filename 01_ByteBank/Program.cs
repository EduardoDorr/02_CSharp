using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank {
  class Program {
    static void Main(string[] args) {
      CheckingAccount accountJohn = new CheckingAccount();

      accountJohn.owner = "John";
      accountJohn.agency = 386;
      accountJohn.account = 863452;
      accountJohn.balance = 100;

      Console.WriteLine(accountJohn.owner);
      Console.WriteLine("Agency: " + accountJohn.agency);
      Console.WriteLine("Account: " + accountJohn.account);
      Console.WriteLine("Balance: " + accountJohn.balance);

      Console.ReadLine();
    }
  }
}
