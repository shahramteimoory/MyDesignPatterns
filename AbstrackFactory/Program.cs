// See https://aka.ms/new-console-template for more information

using AbstrackFactory.MyFactory;

IMyAbstrackFactory myAbstrackFactory1 = new ConcreateFactory1();
IMyAbstrackFactory myAbstrackFactory2 = new ConcreateFactory2();
var resulta1= myAbstrackFactory1.CreateProductA();
var resultb1=myAbstrackFactory1.CreateProductB();
resulta1.Execute();
resultb1.Execute();
Console.WriteLine("---------");
var resulta2=myAbstrackFactory2.CreateProductA();
var resultb2=myAbstrackFactory2.CreateProductB();
resulta2.Execute();
resultb2.Execute();