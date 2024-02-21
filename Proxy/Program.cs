// See https://aka.ms/new-console-template for more information
using Proxy.Example1;

//انواع پروکسی
// Virtual Proxy مثل همین مثال
// Protection Proxy ممکنه بخوایم اول شرایط استفاده از کلاسو برسی کنیم  از این مدل استفاده کنیم قبل نمونه شزایط احراز هویت رو باید چک کرد
// Remote Proxy زمانی که ما یک شیع راه دور داریم با استفاده از شرایط گرفتنش باید ازش استفاده کنیم  اینجا اول شرایط استفاده شبگه ای رو درست میکنیم
// LogginProxy واسه لاگ گرفتن
//CachingProxy مثل بالا عه همش ولی این واسه کش کردنه

ISubject subject = new Proxy.Example1.Proxy();
if (1==1) //این شرط هرچیزی میتونی باشه و ممکنه برقرار نباشه  اینجوری تو نمونه ای که میسازیم  دیگه منایع نمونه سازی از کلاس RealSubject مصرق نمیشه
{
    subject.DoAction();
}
Console.ReadLine();
