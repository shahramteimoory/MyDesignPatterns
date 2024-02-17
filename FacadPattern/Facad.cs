using FacadPattern.SubSystem1;
using FacadPattern.SubSystem2;
using FacadPattern.SubSystem3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadPattern
{
    public class Facad
    {
        public void Dosomething()
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            Class3 class3 = new Class3();

            class1.Action1();
            class2.Action2();
            class3.Action3();
            // اینجا میتونیم توی عملیات تعیراتی هم بدیم
            // و یا با اضافه کردن یک زیر سیستم جدید رو همه تاثیر میذاره
        }
    }
}
