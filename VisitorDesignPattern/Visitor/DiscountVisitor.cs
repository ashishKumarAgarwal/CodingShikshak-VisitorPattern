using System;
using VisitorDesignPattern.Elements;

namespace VisitorDesignPattern.Visitor
{
    internal class DiscountVisitor : IVisitor
    {
        public void Visit(Mango mango)
        {
            Console.WriteLine($"Price after discount is {0.7*mango.Price}");
        }

        public void Visit(Apple apple)
        {
            Console.WriteLine($"Price after discount is {0.8 * apple.Price}");
        }
    }
}