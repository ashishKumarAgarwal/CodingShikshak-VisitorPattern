using VisitorDesignPattern.Elements;

namespace VisitorDesignPattern.Visitor
{
    public interface IVisitor
    {
        void Visit(Mango mango);

        void Visit(Apple apple);
    }
}