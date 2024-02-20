using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Impelomentors
{
    public abstract class Impelomentor
    {
        public abstract void Implemention();
    }
    public class ConcreteImpelomentor: Impelomentor
    {
        public override void Implemention()
        {
            Console.WriteLine("Run ConcreteImpelomentor !");
        }
    }
}
