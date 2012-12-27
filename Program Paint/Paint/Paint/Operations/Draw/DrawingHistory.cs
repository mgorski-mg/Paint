using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paint.Operations.Draw
{
    public class DrawingHistory
    {
        public DrawingHistory()
        {
            History = new Stack<AUndoable>();
            CanceledShares = new Stack<AUndoable>();
        }

        public Stack<AUndoable> History
        {
            get;
            set;
        }

        public Stack<AUndoable> CanceledShares
        {
            get;
            set;
        }
    }
}
