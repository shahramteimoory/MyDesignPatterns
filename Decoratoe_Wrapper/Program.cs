// See https://aka.ms/new-console-template for more information
using Decoratoe_Wrapper;

ConcreateComponent concreateComponent = new ConcreateComponent();
ConcreateDecoretor concreateDecoretor=new ConcreateDecoretor(concreateComponent); // بجای نمونه از کامپوننت اصلی میتونیم اینجا نمونه از فرزندش بش بدیم
concreateDecoretor.Operation();
//concreateComponent.Operation();
Console.ReadLine();
