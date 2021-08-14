using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank {
  class Program {
    static void Main(string[] args) {
      CheckingAccount account = new CheckingAccount();
      Client john = new Client();

      john.Name = "John";
      john.CPF = "458.975.235.64";
      john.Occupation = "Dev";

      account.Owner = john;

      account.Balance = -10;
      Console.WriteLine(account.Owner.Name);
      Console.WriteLine(account.Balance);

      Console.ReadLine();
    }
  }
}
