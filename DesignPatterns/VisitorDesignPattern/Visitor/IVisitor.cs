using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    interface IVisitor
    {
        void Visit(Element element);
    }
}
