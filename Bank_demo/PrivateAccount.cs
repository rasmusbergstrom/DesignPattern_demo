using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
    public class PrivateAccount : IAccount
    {
        public PrivateAccount()
        {

        }
        public string Name { get; set; }
        public int Money { get; set; }

        public string Type = "Private";

  

        public void Withdraw(int amount)
        {
            Money -= amount;
            Console.WriteLine("Money withdrawed: {0}. Total money on account: {0}", amount, this.Money);
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
