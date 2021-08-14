using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank {
  class Program {
    static void Main(string[] args) {
      //Client John = new Client();
      //John.name = "John";
      //John.cpf = "125.254.789-45";
      //John.occupation = "Dev";

      CheckingAccount account = new CheckingAccount();
      account.owner = new Client();

      //account.owner = John;
      account.owner.name = "John";
      account.owner.cpf = "125.254.789-45";
      account.owner.occupation = "Dev";
      account.agency = 863;
      account.number = 863542;
      account.balance = 500;

      //Console.WriteLine(John.name);
      Console.WriteLine(account.owner.name);

      Console.ReadLine();
    }
  }
}
