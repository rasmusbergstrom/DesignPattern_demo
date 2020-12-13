using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
   
    public class AccountFactory 
    {
        TransactionManager transactionManager = new TransactionManager();
        
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
        public string ReadAccount(IAccount acc)
        {
            return $"Accountname: {acc.ReadName()} -  Money: {acc.ReadMoney()} ";
        }
        public string Rename(IAccount acc, string name)
        {
            if(name != acc.Name)
            {
                acc.Name = name;
                return "Name changed";
            }
            else
            {
               return "Error";
            }
        }
        public string ReadMoney(IAccount acc)
        {
            return $"Money: {acc.ReadMoney()} ";
        }
        public string Deposit(IAccount acc, decimal money)
        {
            Deposit deposit = new Deposit(acc, money);
            transactionManager.AddTransaction(deposit);
            transactionManager.ProcessPendingTransactions();
            Console.WriteLine("Saldo :" + acc.Money);
            if (transactionManager.HasPendingTransactions == true)
            {
                transactionManager.ProcessPendingTransactions();
                transactionManager.RemoveOldTransactions();
                return "Money from old transfer has been sent!";
            }

            else
            {
                return "OK";
            }
        }
        public string Withdraw(IAccount acc, decimal money)
        {
            Console.WriteLine("pengar nu : " + acc.Money);
            Withdraw withdraw = new Withdraw(acc, money);
            transactionManager.AddTransaction(withdraw);
            transactionManager.ProcessPendingTransactions();
            

            if (transactionManager.HasPendingTransactions == true)
            {
                transactionManager.ProcessPendingTransactions();
                transactionManager.RemoveOldTransactions();
                return "Transaction saved - will continue when enough money";
            }

            else
            {
                return "OK";
            }


        }
        public void UndoTransaction(int index )
        {
            transactionManager.UndoTransactionNumber(index);
        }
        public string Transfer(IAccount fromAccount, IAccount toAccount, decimal amount)
        {
            Transfer transfer = new Transfer(fromAccount, toAccount, amount);
            transactionManager.AddTransaction(transfer);
            transactionManager.ProcessPendingTransactions();

            if (transactionManager.HasPendingTransactions == true)
            {
                return "Not enough money - Transaction will continue when you have enough money";
            }
            else
            {
                return "Ok";
            }
        }
        public List<ITransaction> PendingTransaction()
        {
      
            return transactionManager.ReturnTransactionList();
        }
     
     




    }
}
