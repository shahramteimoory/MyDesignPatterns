namespace StrategyPattern.Example1.Concreate
{
    public class ConcreateStrategyB : FirstStrategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreateStrategyB Running");
        }
    }
}
