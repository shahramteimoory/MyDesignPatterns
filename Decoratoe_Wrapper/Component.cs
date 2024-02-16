using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoratoe_Wrapper
{
    public abstract class Component // این میتونی اینترفیسم باشه حتما لازم نیست ابسترک کلاس باشه
    {
        public abstract void Operation();
    }

    public class ConcreateComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreateComponent.Operation Runed");
        }
    }
    
}
