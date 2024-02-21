using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example2
{
    public interface IComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }
        int DisplayPrice();
    }
    public class Taki : IComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Taki(string name,int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public int DisplayPrice()
        {
            Console.WriteLine(Name+" : "+Price);
            return Price;
        }
    }

    public class Majmoe: IComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }
        List<IComponent> components=new List<IComponent>();
        public Majmoe(string Name,int Price)
        {
            this.Name=Name;
            this.Price = Price;
        }
        public void Add(IComponent component)
        {
            components.Add(component);
        }
        public void Remove(IComponent component)
        {
            components.Remove(component);
        }
        public int DisplayPrice()
        {
            int sumprice = Price;
            foreach (var item in components)
            {
                sumprice+= item.DisplayPrice();
            }
            Console.WriteLine(Name+" : "+sumprice);
            return sumprice;
        }
    }
}
