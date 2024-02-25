using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Example2
{
    public abstract class SoldierFlyWeight
    {
        public string SoldeirType { get; set; } = string.Empty;
        public abstract void Render(int x, int y, int z, int number);
        public void SetSoldierType(string soldierType)
        {
            this.SoldeirType = soldierType;
        }

    }
    internal class ConcreateSoldierFlyWeight : SoldierFlyWeight
    {
        public override void Render(int x, int y, int z, int number)
        {
            //نمایش سرباز در محل متاسب
            Console.WriteLine($"SoliderType-->{SoldeirType}"+$"Show in location--> x:{x} Y:{y} z:{z}---->Number: {number}");
        }
    }
    public class SoliderFactiry
    {
        public static Dictionary<string, SoldierFlyWeight> SoliderFlyWeights = new Dictionary<string, SoldierFlyWeight>();
        
        public SoldierFlyWeight GetSoldier(string soliderType)
        {
            SoldierFlyWeight soldierFlyWeight = null;
            if (SoliderFlyWeights.TryGetValue(soliderType, out soldierFlyWeight)) { }
            else
            {
                SoldierFlyWeight soldierFlyWeight1=new ConcreateSoldierFlyWeight();
                soldierFlyWeight1.SetSoldierType(soliderType);
                SoliderFlyWeights.Add(soliderType, soldierFlyWeight1);
            }
            return SoliderFlyWeights[soliderType];
        }
    }
}
