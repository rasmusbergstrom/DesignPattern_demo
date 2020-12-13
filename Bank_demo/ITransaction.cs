using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
    public interface ITransaction
    {
        int ID { get; set; }
        DateTime CreatedOn { get; set; }
        CommandState Status { get; set; }
        void Undo();
  
        void Execute();
    }
}
