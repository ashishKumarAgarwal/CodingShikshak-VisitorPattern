using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern.Elements
{
    public interface IFruit
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
