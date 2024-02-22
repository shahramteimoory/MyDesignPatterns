namespace FactoryMethod.Example1
{
    public abstract class Factory
    {
        public abstract Product FactoryMethod(int i);
    }
    public class ConcreateFactory : Factory
    {
        public override Product FactoryMethod(int i)
        {
            if (i > 0)
            {
                return new ConcreateProduct1();
            }else if (i < 0)
            {
                return new ConcreateProduct2();
            }
            else
            {
                return new DefaultProduct();
            }
        }
    }
}
