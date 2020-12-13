using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
    public class Transfer : ITransaction
    {
        private readonly decimal _amount;
        private readonly IAccount _fromAccount;
        private readonly IAccount _toAccount;
       
        public int ID { get; set; }
        public DateTime CreatedOn { get; set; }
        public CommandState Status { get; set; }

        public Transfer(IAccount fromAccount, IAccount toAccount, decimal amount)
        {
            ID++;
            CreatedOn = DateTime.UtcNow;

            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;

            Status = CommandState.Unprocessed;
        }
        public void Execute()
        {
            if(_fromAccount.Money >= _amount)
            {
                _fromAccount.Money -= _amount;
                _toAccount.Money += _amount;

                Status = CommandState.ExecuteSucceeded;
            }
            else
            {
                Status = CommandState.ExecuteFailed;
            }
        }

        public void Undo()
        {
            if(_toAccount.Money >= _amount)
            {
                _toAccount.Money -= _amount;
                _fromAccount.Money += _amount;
                Status = CommandState.UndoSucceeded;
            }
            else
            {
                Status = CommandState.UndoFailed;
            }
        }
    }
}
