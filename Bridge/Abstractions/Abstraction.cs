using Bridge.Impelomentors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstractions
{
    public abstract class Abstraction
    {
        private Impelomentor impelomentor;
        public Abstraction()
        {
            impelomentor = new ConcreteImpelomentor();
        }
        public virtual void Function()
        {
            impelomentor.Implemention();
        }
    }
    public class RefoundAbstraction: Abstraction
    {

    }
}
