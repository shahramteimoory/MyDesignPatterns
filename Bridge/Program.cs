// See https://aka.ms/new-console-template for more information
using Bridge.Abstractions;
using Bridge.Example2.MailService;

RefoundAbstraction impelomentor = new RefoundAbstraction();

impelomentor.Function();
RefindMailService refindMailService = new RefindMailService();
refindMailService.Send(new EmailInformationDto
{
    Message="this Message from my app",
    Reciver="darn.shan@gmail.com",
    Title="Alert Mail"
});
Console.ReadLine();