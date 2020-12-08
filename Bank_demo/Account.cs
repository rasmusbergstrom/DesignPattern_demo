using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_demo
{
    public class Account : IBankMethods
    {
        public string AccountName { get; set; }
        public int Money { get; set; }

        public Account(string name, int money)
        {

            this.AccountName = name;
            this.Money = money;
            
        }


        //Methods
        public string FullAccountInfo
        {
            get
            {
                return AccountName + "                     " + Money.ToString();
            }
       
        }

        public void Withdraw(int sum)
        {
            if (this.Money >= sum)
            {
                this.Money -= sum;
            }
            else
            {

            }
        }
        public void Transfer(Account to, int money)
        {
            this.Money = this.Money - money;
            to.Money = to.Money + money;
        }

        public void Despoit(int sum)
        {
            this.Money += sum;
        }

        public void changeName(Account acc, string name)
        {
            this.AccountName = name; 
        }
    }
}