using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank {
  class Program {
    static void Main(string[] args) {
      CheckingAccount accountJohn = new CheckingAccount();
      accountJohn.owner = "John";
      accountJohn.agency = 863;
      accountJohn.account = 863452;
      accountJohn.balance = 100;

      CheckingAccount accountJohnRambo = new CheckingAccount();
      accountJohn.owner = "John";
      accountJohn.agency = 863;
      accountJohn.account = 863452;
      accountJohn.balance = 100;

      Console.WriteLine(accountJohnRambo == accountJohn);

      Console.ReadLine();
    }
  }
}
