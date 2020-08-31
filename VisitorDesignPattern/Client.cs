using System;
using System.Collections.Generic;
using VisitorDesignPattern.Elements;
using VisitorDesignPattern.ObjectStructure;
using VisitorDesignPattern.Visitor;

namespace VisitorDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            List<IVisitableElement> elements=new List<IVisitableElement>
            {
                new Apple{Name = "ShimlaApple",Price = 100,Quantity = 50},
                new Mango{Name = "RatnagiriMango",Price = 90,Quantity = 60}
            };

            FruitStructure fruitStructure=new FruitStructure(elements);

            fruitStructure.ApplyVisitor(new DiscountVisitor());
            fruitStructure.ApplyVisitor(new FruitSoldVisitor());
          
        }
    }
}
