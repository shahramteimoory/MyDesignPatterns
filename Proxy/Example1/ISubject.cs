using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example1
{
    public interface ISubject
    {
        void DoAction();
    }
    internal class RealSubject : ISubject
    {
        public void DoAction()
        {
            Console.WriteLine("Run DoAction From RealSubject");
        }
    }
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;
        //بجای اینکه تو متد سازنده مقدار دهیش کنیم وقتی متد مد نظرمون رو صدا کردن مقدار دهی میشه
        public void DoAction()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.DoAction();
        }
    }
}
