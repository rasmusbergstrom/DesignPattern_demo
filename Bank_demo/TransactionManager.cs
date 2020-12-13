using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
    public class TransactionManager
    {
        public List<ITransaction> transactions = new List<ITransaction>();

        public bool HasPendingTransactions
        {
            get 
            {
                return transactions.Any(x =>
                                        x.Status == CommandState.Unprocessed ||
                                        x.Status == CommandState.ExecuteFailed ||
                                        x.Status == CommandState.UndoFailed);
            }

        }
        public void AddTransaction(ITransaction transaction)
        {
            transactions.Add(transaction);
            RemoveOldTransactions();
        }
        public List<ITransaction> ReturnTransactionList()
        {
            return transactions;
        }
        public void ProcessPendingTransactions()
        {
            foreach (ITransaction transaction in transactions.Where( x =>
                                                                     x.Status == CommandState.Unprocessed ||
                                                                     x.Status == CommandState.ExecuteFailed))
            {
                transaction.Execute();
            }
            foreach (ITransaction transaction in transactions.Where(x => x.Status == CommandState.UndoFailed))
            {
                transaction.Undo();
            }        
        }
        public void UndoTransactionNumber(int id)
        {
        
            ITransaction transaction = transactions.FirstOrDefault(x => x.ID == id);

            if (transaction == null)
            {
                throw new ArgumentException(string.Format("There is no transaction number: {0}", id));
            }
            transaction.Undo();
            if (transaction.Status == CommandState.UndoSucceeded)
            {
                transactions.Remove(transaction);
            }
        }

        public void RemoveOldTransactions()
        {
            transactions.RemoveAll(x =>
                x.Status == CommandState.ExecuteSucceeded);
        }
    }

}

