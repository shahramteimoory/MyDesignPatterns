// See https://aka.ms/new-console-template for more information
using Decoratoe_Wrapper;
using Decoratoe_Wrapper.Example2;

ConcreateComponent concreateComponent = new ConcreateComponent();
ConcreateDecoretor concreateDecoretor=new ConcreateDecoretor(concreateComponent); // بجای نمونه از کامپوننت اصلی میتونیم اینجا نمونه از فرزندش بش بدیم
concreateDecoretor.Operation();
//concreateComponent.Operation();

SendEmail sendEmail = new SendEmail();
SendEmailDecorator sendEmailDecorator = new SendEmailDecorator(sendEmail);
sendEmailDecorator.send();
Console.ReadLine();
