using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine(CheckingAccount.Qtd);

      CheckingAccount accountJohn = new CheckingAccount(863, 863452);
      accountJohn.Balance = 200;
      Console.WriteLine(CheckingAccount.Qtd);

      CheckingAccount accountBill = new CheckingAccount(863, 863715);
      accountBill.Balance = 300;
      Console.WriteLine(CheckingAccount.Qtd);

      Console.WriteLine("John's Agency: " + accountJohn.Agency);
      Console.WriteLine("John's Number: " + accountJohn.Number);
      Console.WriteLine("Bill's Agency: " + accountBill.Agency);
      Console.WriteLine("Bill's Number: " + accountBill.Number);

      Console.ReadLine();
    }
  }
}
