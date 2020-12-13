using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
 
        public class BudgetAccount : IAccount
        {
      
            public string accName { get; set; }
            public decimal Money { get; set; }
            public string Type { get; set; }
          
        public BudgetAccount()
        {
            Name = "Your budget account";
            Money = 0;
            Type = "Budget";
        }

        public string Name
        {
            get
            {
                return accName;
            }
            set
            {
                accName = value;
            }
        }

        public string ReadMoney()
        {
            return this.Money.ToString();
        }

        public string ReadName()
        {
            return this.accName.ToString();
        }
    }
}
