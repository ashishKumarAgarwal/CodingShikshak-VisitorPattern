using System;
using System.Collections.Generic;
using System.Text;
using VisitorDesignPattern.Visitor;

namespace VisitorDesignPattern.Elements
{
    interface IVisitableElement
    {
        void Accept(IVisitor visitor);
    }
}
