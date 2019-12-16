using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
