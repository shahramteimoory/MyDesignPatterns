using AbstrackFactory.Services.ProductA;
using AbstrackFactory.Services.ProductB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrackFactory.MyFactory
{
    public interface IMyAbstrackFactory
    {
        IAbstrackProductA CreateProductA();
        IAbstrackProductB CreateProductB();
    }
    public class ConcreateFactory1 : IMyAbstrackFactory
    {
        public IAbstrackProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IAbstrackProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    public class ConcreateFactory2 : IMyAbstrackFactory
    {
        public IAbstrackProductA CreateProductA()
        {
            return new ProductA2 ();
        }

        public IAbstrackProductB CreateProductB()
        {
           return new ProductB2 ();
        }
    }
}
