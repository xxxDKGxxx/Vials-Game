using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2WinForms
{
    /// <summary>
    /// Singleton that manages undo action throughout the game
    /// </summary>
    public class UndoManager
    {
        /// <summary>
        /// Private field for lazy initializing the instance
        /// </summary>
        private static Lazy<UndoManager> _undoManager = new(() => new UndoManager());

        private UndoManager() 
        {
            _stack = new Stack<(VialControl from, VialControl to, int amount)> ();
        }

        /// <summary>
        /// Undo Stack
        /// </summary>
        private Stack<(VialControl from, VialControl to, int amount)> _stack;
        
        
        /// <summary>
        /// Static property used to retrieve the Singleton instance
        /// </summary>
        public static UndoManager Instance { get { return _undoManager.Value; } }

        /// <summary>
        /// Adds last move to the stack (drag-drop action on last VialControls)
        /// </summary>
        /// <param name="from">A VialControl that we have moved from</param>
        /// <param name="to">A VialControl that we have moved to</param>
        /// <param name="amount">Amount of Segments that we have moveed between Vials</param>
        public void AddMove(VialControl from, VialControl to, int amount)
        {
            _stack.Push((from, to, amount));
        }

        /// <summary>
        /// Performs undo logic on last two Vial drag-drop
        /// </summary>
        public bool Undo()
        {
            if (_stack.Count == 0) return false;

            var context = _stack.Pop();
            for(int i = 0; i < context.amount; i++)
            {
                context.from.Segments.Insert(0, context.to.Segments.ElementAt(0));
                context.to.Segments.RemoveAt(0);
            }
            context.from.Refresh();
            context.to.Refresh();
            return true;
        }

        /// <summary>
        /// Resetes last undos
        /// </summary>
        public void Reset()
        {
            _stack.Clear();
        }
    }
}
