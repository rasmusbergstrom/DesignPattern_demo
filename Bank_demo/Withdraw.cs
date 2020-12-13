using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
    public class Withdraw : ITransaction
    {
        private readonly IAccount _account;
        private readonly decimal _amount;
        public int ID { get; set; }
        
        public DateTime CreatedOn { get; set; }
        public CommandState Status { get; set; }

      
        public Withdraw(IAccount account, decimal amount)
        {
            
            CreatedOn = DateTime.UtcNow;

            _account = account;
            _amount = amount;

            Status = CommandState.Unprocessed;
        }

        public void Execute()
        {
            if(_account.Money >= _amount)
            {
                _account.Money -= _amount;

                Status = CommandState.ExecuteSucceeded;
            }
            else
            {
                Status = CommandState.ExecuteFailed;
            }
        }

        public void Undo()
        {
            _account.Money += _amount;
            Status = CommandState.UndoSucceeded;
        }
    }
}
