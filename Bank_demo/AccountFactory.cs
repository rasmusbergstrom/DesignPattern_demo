using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
    public class AccountFactory
    {
        public IAccount GetAccount(string type)
        {
            IAccount acc = null;

            switch (type)
            {
                case "saving":
                    acc = new SavingAccount();
                    break;
                case "budget":
                    acc = new BudgetAccount();
                    break;
                case "private":
                    acc = new PrivateAccount();
                    break;
            }
            return acc;
        }
    }
}
