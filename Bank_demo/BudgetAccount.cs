using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
 
        public class BudgetAccount : IAccount
        {
            public string Name { get; set; }
            public int Money { get; set; }
            public string Type = "Budget";
            public void Add(int amount)
            {
                Money += amount;
                Console.WriteLine("Money added by: {0}. Total money on account: {0}", amount, this.Money);
            }


            public void Withdraw(int amount)
            {
                Money -= amount;
                Console.WriteLine("Money withdrawed: {0}. Total money on account: {0}", amount, this.Money);
            }

            public void Despoit(int sum)
            {
                throw new NotImplementedException();
            }

            public void Transfer(IAccount transferTo, int money)
            {
                throw new NotImplementedException();
            }
    }
}
