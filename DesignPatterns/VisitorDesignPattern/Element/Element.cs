using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
