using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1
{
    public abstract class Product
    {
        public abstract void Execute();
    }
    public class ConcreateProduct1 : Product
    {
        public override void Execute()
        {
            Console.WriteLine("ConcreateProduct 1 Run ...");
        }
    }
    public class ConcreateProduct2 : Product
    {
        public override void Execute()
        {
            Console.WriteLine("ConcreateProduct 2 Run ...");
        }
    }
    public class DefaultProduct : Product
    {
        public override void Execute()
        {
            Console.WriteLine("DefaultProduct Run ...");
        }
    }
}
