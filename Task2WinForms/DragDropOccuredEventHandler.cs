using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2WinForms
{

    public delegate void DragDropOccuredEventHandler(object sender, DragDropOccuredEventArgs e);
    public class DragDropOccuredEventArgs: EventArgs
    {
        public VialControl from;
        public VialControl to;
        public int amount;

        public DragDropOccuredEventArgs(VialControl from, VialControl to, int amount)
        {
            this.from = from;
            this.to = to;
            this.amount = amount;
        }
    }
}
