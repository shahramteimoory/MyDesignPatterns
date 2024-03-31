using StrategyPattern.Example1;
using StrategyPattern.Example1.Concreate;
using StrategyPattern.Example2;
using StrategyPattern.Example2.Entities;
#region Example1
FirstContext firstContext;

firstContext = new FirstContext(new ConcreateStrategyA());
firstContext.ContextInterface();
firstContext = new FirstContext(new ConcreateStrategyB());
firstContext.ContextInterface();
firstContext = new FirstContext(new ConcreateStrategyC());
firstContext.ContextInterface();
#endregion
//با یه متد الگوریتم های مختلفی اجرا شد 
// مثلا میشه بهش ورودی داد که انتیتی رو دربافت کنه  و الگوربتم مربوط به اون انتیتی رو انجام بده


#region Example2
//میخوام متد خود ماکروسافت که از استراتژی استفاده کرده رو برسی کنم
//Array.Sort();
#region meghdardehi
var user = new User[]
{
    new User{Id=4,FirstName="MohammadHosein",LastName="Teimoory",Balance=5000},
    new User{Id=2,FirstName="Shahram",LastName="Teimoory",Balance=4000000},
    new User{Id=40,FirstName="Darren",LastName="Shan",Balance=10}
};
#endregion

Console.WriteLine("----------------Before Sort Balance-----------------");
foreach (var item in user)
{
    item.DisplayUser();
}

Array.Sort(user,new UserByBalance());
Console.WriteLine("----------------After Sort Balance------------------");
foreach (var item in user)
{
    item.DisplayUser();
}
Array.Sort(user, new UserByIId());
Console.WriteLine("----------------After Sort Id------------------");
foreach (var item in user)
{
    item.DisplayUser();
}
#endregion