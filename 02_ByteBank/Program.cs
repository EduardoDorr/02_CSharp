using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank {
  class Program {
    static void Main(string[] args) {
      CheckingAccount accountJohn = new CheckingAccount();

      accountJohn.owner = "John";

      Console.WriteLine(accountJohn.owner);
      Console.WriteLine("Balance: " + accountJohn.balance);

      Console.ReadLine();
    }
  }
}
