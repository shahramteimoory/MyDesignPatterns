namespace StrategyPattern.Example1.Concreate
{
    public class ConcreateStrategyC : FirstStrategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreateStrategyC Running");
        }
    }
}
