using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example1
{
    public abstract class Component
    {
        protected string Name;
        public Component(string Name)
        {
            this.Name = Name;
        }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int Depth);
    }

    public class Composite: Component
    {
        private List<Component> _components = new List<Component>();
        public Composite(string Name):base(Name) 
        {
            
        }
        public Composite(string Name, Component[] components):base(Name)
        {
            foreach (Component component in components)
            {
                Add(component);
            }
        }
        public override void Add(Component component)
        {
            _components.Add(component);
        }
        public override void Remove(Component component)
        {
            _components.Remove(component);
        }
        public override void Display(int Depth)
        {
            Console.WriteLine(new string('-',Depth)+Name);
            foreach (Component component in _components)
            {
                component.Display(Depth+2);
            }
        }
    }
    public class Leaf: Component
    {
        public Leaf(string Name ):base(Name)
        {
            
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Display(int Depth)
        {
            Console.WriteLine(new string('-', Depth) + Name); 
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
