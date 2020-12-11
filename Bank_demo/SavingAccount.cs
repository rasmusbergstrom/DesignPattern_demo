using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
    public class SavingAccount : IAccount
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public string Type = "Saving";

        public void Withdraw(int sum)
        {
            throw new NotImplementedException();
        }

        public void Transfer(IAccount transferTo, int money)
        {
            throw new NotImplementedException();
        }

        public void Despoit(int sum)
        {
            throw new NotImplementedException();
        }
    }
}
