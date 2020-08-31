using System;
using VisitorDesignPattern.Elements;

namespace VisitorDesignPattern.Visitor
{
    internal class FruitSoldVisitor : IVisitor
    {
        public void Visit(Mango mango)
        {
            Console.WriteLine($"Mangoes sold : {mango.Quantity}");
        }

        public void Visit(Apple apple)
        {
            Console.WriteLine($"Apple sold : {apple.Quantity}");
        }
    }
}