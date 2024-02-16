namespace Decoratoe_Wrapper
{
    public abstract class Decoretor: Component
    {
        // به صورت پرایوت Component رو باید اینجا پیاده سازی کنم
        private readonly Component _component;
        public Decoretor(Component component)
        {
            _component=component;
        }
        public override void Operation()
        {
            
            _component.Operation();
        }
    }
    public class ConcreateDecoretor: Decoretor
    {
        public ConcreateDecoretor(Component component):base(component)
        {
            //یدونه کامپوننت میسازیم و میدیمش به کلاس پدر
        }
        public override void Operation()
        {
            //الان میتونیم یه ویژگی جدید اضافه کنیم
            // که قبل یا بعد متد اصلی صداش بزنیم 
            //این بدرد زمانی میخوره که نمیخوایم به متد اصلی دست بزنیم یا کد متد اصلی رو نداریم
            NewFeather();
            base.Operation();
        }
        public void NewFeather()
        {
            Console.WriteLine("This write from NewFeather");
        }
    }
}
