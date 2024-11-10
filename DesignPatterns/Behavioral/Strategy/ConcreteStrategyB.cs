namespace Behavioral.Strategy
{
    internal class ConcreteStrategyB : IStrategy
    {
        public List<string> DoAlgorithm(List<string> data)
        {
            Console.WriteLine("Implementing Strategy B. Press any key to proceed...");
            _ = Console.ReadKey();
            data.Sort();
            data.Reverse();
            return data;
        }
    }
}
