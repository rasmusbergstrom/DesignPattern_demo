using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_demo
{
    public enum CommandState
    {
        Unprocessed,
        ExecuteFailed,
        ExecuteSucceeded,
        UndoFailed,
        UndoSucceeded
    }
}
