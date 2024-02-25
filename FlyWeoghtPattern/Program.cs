// See https://aka.ms/new-console-template for more information
using FlyWeightPattern.Example1;
using FlyWeightPattern.Example2;

FlyweightFactoryExample1 factoryExample1 = new FlyweightFactoryExample1();
var obj1= factoryExample1.GetFlyWeight("Test1");
var obj2 = factoryExample1.GetFlyWeight("Test2");
var obj3 = factoryExample1.GetFlyWeight("Test1");
obj1.Opertation("kilidkhareji1");
obj2.Opertation("kilidkhareji2");
obj3.Opertation("kilidkhareji3");
UnsharedConcreateFlyWeightExample1 concreateFlyWeightExample1=new UnsharedConcreateFlyWeightExample1(new FlyWeightExample1[]
{
    factoryExample1.GetFlyWeight("test1"),
     factoryExample1.GetFlyWeight("test1"),
      factoryExample1.GetFlyWeight("test1"),
       factoryExample1.GetFlyWeight("test1")
});
concreateFlyWeightExample1.Opertation("vaziyat khareji vase in list");

Console.WriteLine("________________________________________________________________");
SoliderFactiry soliderFactiry = new SoliderFactiry();
for (int i = 0; i < 100000000; i++)
{
    var temp = soliderFactiry.GetSoldier("Sarbaz");
    temp.Render(10,50,20,i);
}