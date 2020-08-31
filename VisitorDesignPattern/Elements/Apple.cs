using VisitorDesignPattern.Visitor;

namespace VisitorDesignPattern.Elements
{
    public class Apple : IFruit,IVisitableElement
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}