using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Example1.Concreate
{
    public class ConcreateStrategyA : FirstStrategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreateStrategyA Running");
        }
    }
}
