using System;
using VisitorDesignPattern.Elements;

namespace VisitorDesignPattern.Visitor
{
    internal class FruitSoldVisitor : IVisitor
    {
        public void Visit(Mango mango)
        {
            Console.WriteLine($"Total mangoes sold is {mango.Quantity}");
        }

        public void Visit(Apple apple)
        {
            Console.WriteLine($"Total apples sold is {apple.Quantity}");
        }
    }
}