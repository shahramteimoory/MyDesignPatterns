// See https://aka.ms/new-console-template for more information
using Decoratoe_Wrapper;
using Decoratoe_Wrapper.Example2;
using Decoratoe_Wrapper.UseDecratorWithOutSource;

ConcreateComponent concreateComponent = new ConcreateComponent();
ConcreateDecoretor concreateDecoretor=new ConcreateDecoretor(concreateComponent); // بجای نمونه از کامپوننت اصلی میتونیم اینجا نمونه از فرزندش بش بدیم
concreateDecoretor.Operation();
//concreateComponent.Operation();

SendEmail sendEmail = new SendEmail();
SendEmailDecorator sendEmailDecorator = new SendEmailDecorator(sendEmail);
sendEmailDecorator.send();
WithOutSorceExample withOutSorceExample = new WithOutSorceExample();
string test1= withOutSorceExample.DownloadWeb("https://www.google.com/");
string test2= withOutSorceExample.DownloadWeb("https://github.com/shahramteimoory"); //متد downloadstring webclient رو به این شکل تغییر دادیم
Console.ReadLine();
