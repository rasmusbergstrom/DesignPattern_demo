using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
    class Deposit : ITransaction
    {
        private readonly IAccount _account;
        private readonly decimal _amount;
        public bool IsCompleted { get; set; }
        public int ID { get; set; }
        public DateTime CreatedOn { get; set; }
        public CommandState Status { get; set; }

        public Deposit(IAccount account, decimal amount)
        {
            ID++;
            CreatedOn = DateTime.UtcNow;

            _account = account;
            _amount = amount;

            Status = CommandState.Unprocessed;  
        }
        public void Execute()
        {
            _account.Money += _amount;
            Status = CommandState.ExecuteSucceeded;
        }

        public void Undo()
        {
            if(_account.Money >= _amount)
            {
                _account.Money -= _amount;
                Status = CommandState.UndoSucceeded;
            }
            else
            {
                Status = CommandState.UndoFailed;
            }
        }
    }
}
