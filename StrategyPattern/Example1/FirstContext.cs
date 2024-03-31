using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Example1
{
    public class FirstContext
    {
        private FirstStrategy FirstStrategy;
        public FirstContext(FirstStrategy firstStrategy)
        {
            FirstStrategy=firstStrategy;
        }
        public void ContextInterface()
        {
            FirstStrategy.AlgorithmInterface();
        }
    }
}
