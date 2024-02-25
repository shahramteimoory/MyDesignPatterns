using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Example1
{
    public abstract class FlyWeightExample1
    {
        public abstract void Opertation(string extrisicstate);
    }
    public class ConcreateFlyWeightExample1 : FlyWeightExample1
    {
        private string interinsincState;
        public ConcreateFlyWeightExample1(string interinsincState)
        {
            this.interinsincState = interinsincState;
        }
        public override void Opertation(string extrisicstate)
        {
            Console.WriteLine("ConcreateflyWeightExample1.operation('"+interinsincState + "'):\"" +extrisicstate +"\"");
        }
    }
    public class FlyweightFactoryExample1
    {
        private Dictionary<string,FlyWeightExample1> flyweights=new Dictionary<string,FlyWeightExample1>();
        public FlyWeightExample1 GetFlyWeight(string key)
        {
            FlyWeightExample1 flyWeight = null;
            if (flyweights.TryGetValue(key, out flyWeight)) { }
            else
            {
                flyweights.Add(key, new ConcreateFlyWeightExample1(key));
            }
            return flyweights[key];
        }
    }
    public class UnsharedConcreateFlyWeightExample1 : FlyWeightExample1
    {
        private IEnumerable<FlyWeightExample1> flyweights;
        public UnsharedConcreateFlyWeightExample1(IEnumerable<FlyWeightExample1> flyWeightExamples)
        {
            flyweights=flyWeightExamples;
        }
        public override void Opertation(string extrisicstate)
        {
            Console.WriteLine("Unshared Concreate FlyWeight --------------------");
            foreach (var item in flyweights)
            {
                item.Opertation(extrisicstate);
            }
        }
    }
}
