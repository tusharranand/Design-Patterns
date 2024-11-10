namespace Behavioral.Strategy
{
    internal class ConcreteStrategyA : IStrategy
    {
        public List<string> DoAlgorithm(List<string> data)
        {
            Console.WriteLine("Implementing Strategy A. Press any key to proceed...");
            _ = Console.ReadKey();
            data.Sort();
            return data;
        }
    }
}
