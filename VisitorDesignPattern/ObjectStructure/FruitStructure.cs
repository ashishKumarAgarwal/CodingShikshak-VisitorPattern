using System;
using System.Collections.Generic;
using VisitorDesignPattern.Elements;
using VisitorDesignPattern.Visitor;

namespace VisitorDesignPattern.ObjectStructure
{
    internal class FruitStructure
    {
        private readonly List<IVisitableElement> _fruits;

        public FruitStructure(List<IVisitableElement> items)
        {
            _fruits = items;
        }

        public void ApplyVisitor(IVisitor visitor)
        {
            Console.WriteLine("\n------- Visitor details -------");
            _fruits.ForEach(fruit => fruit.Accept(visitor));
        }
    }
}