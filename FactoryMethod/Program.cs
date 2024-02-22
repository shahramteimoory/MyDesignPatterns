// See https://aka.ms/new-console-template for more information
using FactoryMethod.Example1;
using FactoryMethod.Example2.FactoryMethod;
using FactoryMethod.Example2.Sms;

var factory = new ConcreateFactory();
Product p;
p = factory.FactoryMethod(0);
p.Execute();

Console.WriteLine("---------------------------------------------------------------------------");
ISmsManager sms;
IFactory factorynew =new Factory2();
sms = factorynew.FactoryMethod();
sms.Send(new SmsDto
{
    Message = "test",
    Reciver = "62324332"
});
